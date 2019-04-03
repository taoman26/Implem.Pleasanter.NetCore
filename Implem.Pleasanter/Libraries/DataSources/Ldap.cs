using Implem.DefinitionAccessor;
using Implem.Libraries.DataSources.SqlServer;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.General;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Security;
using Implem.Pleasanter.Libraries.Settings;
using Implem.Pleasanter.Models;
using System;
using System.Collections.Generic;
using Novell.Directory.Ldap;
namespace Implem.Pleasanter.Libraries.DataSources
{
    public static class Ldap
    {
        public static bool Authenticate(IContext context, string loginId, string password)
        {
            foreach (var ldap in Parameters.Authentication.LdapParameters)
            {
                try
                {
                    using (var con = LdapConnection(loginId, password, ldap))
                    {
                        var entry = con.Search(
                            con.DN(ldap),
                            Novell.Directory.Ldap.LdapConnection.SCOPE_SUB,
                            $"({ldap.LdapSearchProperty}={loginId})",
                            null,
                            false).FindOne();
                        if (entry != null)
                        {
                            UpdateOrInsert(
                                context: context,
                                loginId: loginId,
                                entry: entry,
                                ldap: ldap,
                                synchronizedTime: DateTime.Now);
                            return true;
                        }
                    }
                }
                catch (Exception e)
                {
                    new SysLogModel(context: context, e: e);
                    return false;
                }
            }
            return false;
        }

        public static void UpdateOrInsert(IContext context, string loginId)
        {
            foreach (var ldap in Parameters.Authentication.LdapParameters)
            {
                try
                {
                    using (var con = LdapConnection(loginId, null, ldap))
                    {
                        var entry = con.Search(
                            con.DN(ldap),
                            Novell.Directory.Ldap.LdapConnection.SCOPE_SUB,
                            "({0}={1})".Params(ldap.LdapSearchProperty, loginId.Split_2nd('\\')),
                            null,
                            false).FindOne();
                        if (entry != null)
                        {
                            UpdateOrInsert(
                                context: context,
                                loginId: loginId,
                                entry: entry,
                                ldap: ldap,
                                synchronizedTime: DateTime.Now);
                        }
                    }
                }
                catch (Exception e)
                {
                    new SysLogModel(context: context, e: e);
                }
            }
        }

        private static void UpdateOrInsert(
            IContext context,
            string loginId,
            LdapEntry entry,
            ParameterAccessor.Parts.Ldap ldap,
            DateTime synchronizedTime)
        {
            var deptCode = entry.Property(
                context: context,
                name: ldap.LdapDeptCode,
                pattern: ldap.LdapDeptCodePattern);
            var deptName = entry.Property(
                context: context,
                name: ldap.LdapDeptName,
                pattern: ldap.LdapDeptNamePattern);
            var deptExists = !deptCode.IsNullOrEmpty() && !deptName.IsNullOrEmpty();
            var deptSettings = !ldap.LdapDeptCode.IsNullOrEmpty() && !ldap.LdapDeptName.IsNullOrEmpty();
            var userCode = entry.Property(
                context: context,
                name: ldap.LdapUserCode,
                pattern: ldap.LdapUserCodePattern);
            var name = Name(
                context: context,
                loginId: loginId,
                entry: entry,
                ldap: ldap);
            var mailAddress = entry.Property(
                context: context,
                name: ldap.LdapMailAddress,
                pattern: ldap.LdapMailAddressPattern);
            var statements = new List<SqlStatement>();
            if (deptExists)
            {
                statements.Add(Rds.UpdateOrInsertDepts(
                    param: Rds.DeptsParam()
                        .TenantId(ldap.LdapTenantId)
                        .DeptCode(deptCode)
                        .DeptName(deptName),
                    where: Rds.DeptsWhere().DeptCode(deptCode)));
            }
            var param = Rds.UsersParam()
                .TenantId(ldap.LdapTenantId)
                .LoginId(loginId)
                .UserCode(userCode)
                .Name(name)
                .DeptId(
                    sub: Rds.SelectDepts(
                        column: Rds.DeptsColumn().DeptId(),
                        where: Rds.DeptsWhere().DeptCode(deptCode)),
                    _using: deptExists)
                .DeptId(0, _using: deptSettings && !deptExists)
                .LdapSearchRoot(ldap.LdapSearchRoot)
                .SynchronizedTime(synchronizedTime);
            ldap.LdapExtendedAttributes?.ForEach(attribute =>
                param.Add(
                    $"[Users].[{attribute.ColumnName}]",
                    attribute.ColumnName,
                    entry.Property(
                        context: context,
                        name: attribute.Name,
                        pattern: attribute.Pattern)));
            statements.Add(Rds.UpdateOrInsertUsers(
                param: param,
                where: Rds.UsersWhere().LoginId(loginId),
                addUpdatorParam: false,
                addUpdatedTimeParam: false));
            if (!mailAddress.IsNullOrEmpty())
            {
                statements.Add(Rds.PhysicalDeleteMailAddresses(
                    where: Rds.MailAddressesWhere()
                        .OwnerType("Users")
                        .OwnerId(sub: Rds.SelectUsers(
                            column: Rds.UsersColumn().UserId(),
                            where: Rds.UsersWhere().LoginId(loginId)))));
                statements.Add(Rds.InsertMailAddresses(
                    param: Rds.MailAddressesParam()
                        .OwnerId(sub: Rds.SelectUsers(
                            column: Rds.UsersColumn().UserId(),
                            where: Rds.UsersWhere().LoginId(loginId)))
                        .OwnerType("Users")
                        .MailAddress(mailAddress)));
            }
            var ss = new SiteSettings();
            statements.Add(StatusUtilities.UpdateStatus(
                tenantId: ldap.LdapTenantId, type: StatusUtilities.Types.DeptsUpdated));
            statements.Add(StatusUtilities.UpdateStatus(
                tenantId: ldap.LdapTenantId, type: StatusUtilities.Types.UsersUpdated));
            Rds.ExecuteNonQuery(
                context: context,
                transactional: true,
                statements: statements.ToArray());
        }

        public static void Sync(IContext context)
        {
            var synchronizedTime = DateTime.Now;
            Parameters.Authentication.LdapParameters
                .ForEach(ldap => ldap.LdapSyncPatterns?
                    .ForEach(pattern =>
                    {
                        Sync(
                          context: context,
                          ldap: ldap,
                          pattern: pattern,
                          synchronizedTime: synchronizedTime);
                        if (ldap.AutoDisable)
                        {
                            Rds.ExecuteNonQuery(
                                context: context,
                                statements: Rds.UpdateUsers(
                                    param: Rds.UsersParam().Disabled(true),
                                    where: Rds.UsersWhere()
                                        .Disabled(false)
                                        .LdapSearchRoot(ldap.LdapSearchRoot)
                                        .SynchronizedTime(_operator: " is not null")
                                        .SynchronizedTime(synchronizedTime, _operator: "<>"),
                                    addUpdatorParam: false,
                                    addUpdatedTimeParam: false));
                        }
                        if (ldap.AutoEnable)
                        {
                            Rds.ExecuteNonQuery(
                                context: context,
                                statements: Rds.UpdateUsers(
                                    param: Rds.UsersParam().Disabled(false),
                                    where: Rds.UsersWhere()
                                        .Disabled(true)
                                        .LdapSearchRoot(ldap.LdapSearchRoot)
                                        .SynchronizedTime(_operator: " is not null")
                                        .SynchronizedTime(synchronizedTime),
                                    addUpdatorParam: false,
                                    addUpdatedTimeParam: false));
                        }
                    }));
        }

        private static void Sync(
            IContext context,
            ParameterAccessor.Parts.Ldap ldap,
            string pattern,
            DateTime synchronizedTime)
        {
            var logs = new Logs()
            {
                new Log("pattern", pattern)
            };
            try
            {
                using (var con = LdapConnection(
                    ldap.LdapSyncUser,
                    ldap.LdapSyncPassword,
                    ldap))
                {
                    var results = con.Search(
                        con.DN(ldap),
                        Novell.Directory.Ldap.LdapConnection.SCOPE_SUB,
                        pattern,
                        null,
                        false,
                        new LdapSearchConstraints() { MaxResults = 1000 });
                    logs.Add("results", results.Count.ToString());
                    while (results.hasMore())
                    {
                        var entry = results.next();
                        if (Enabled(entry, ldap))
                        {
                            logs.Add("entry", entry.DN);
                            if (Authentications.Windows(context: context))
                            {
                                UpdateOrInsert(
                                    context: context,
                                    loginId: NetBiosName(
                                        context: context,
                                        entry: entry,
                                        ldap: ldap),
                                    entry: entry,
                                    ldap: ldap,
                                    synchronizedTime: synchronizedTime);
                            }
                            else
                            {
                                UpdateOrInsert(
                                    context: context,
                                    loginId: entry.Property(
                                        context: context,
                                        name: ldap.LdapSearchProperty),
                                    entry: entry,
                                    ldap: ldap,
                                    synchronizedTime: synchronizedTime);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                new SysLogModel(context: context, e: e, logs: logs);
            }
        }

        private static bool Enabled(LdapEntry entry, ParameterAccessor.Parts.Ldap ldap)
        {
            var accountDisabled = 2;
            return
                !ldap.LdapExcludeAccountDisabled ||
                (entry.getAttribute("UserAccountControl")?.ToLong() & accountDisabled) == 0;
        }

        private static LdapConnection LdapConnection(
            string loginId, string password, ParameterAccessor.Parts.Ldap ldap)
        {
            var url = new LdapUrl(ldap.LdapSearchRoot);
            var con = new LdapConnection();
            con.Connect(url.Host, url.Port);
            if (loginId != null && password != null)
                con.Bind($"{loginId}@{url.Host}", password);
            else
                con.Bind(null, null);
            return con;
        }

        private static string Property(
            this LdapEntry entry, IContext context, string name, string pattern = null)
        {
            var logs = new Logs()
            {
                new Log("entry", entry.DN),
                new Log("propertyName", name)
            };
            if (!name.IsNullOrEmpty())
            {
                try
                {
                    return entry.getAttribute(name)?.StringValue != null
                        ? pattern.IsNullOrEmpty()
                            ? entry.getAttribute(name).StringValue
                            : entry.getAttribute(name).StringValue.RegexFirst(pattern)
                        : string.Empty;
                }
                catch (Exception e)
                {
                    new SysLogModel(context: context, e: e, logs: logs);
                }
            }
            return string.Empty;
        }

        private static string Name(
            IContext context,
            string loginId,
            LdapEntry entry,
            ParameterAccessor.Parts.Ldap ldap)
        {
            var name = "{0} {1}".Params(
                entry.Property(
                    context: context,
                    name: ldap.LdapLastName,
                    pattern: ldap.LdapLastNamePattern),
                entry.Property(
                    context: context,
                    name: ldap.LdapFirstName,
                    pattern: ldap.LdapFirstNamePattern));
            return name != " "
                ? name.Trim()
                : loginId;
        }

        public static string NetBiosName(
            IContext context, LdapEntry entry, ParameterAccessor.Parts.Ldap ldap)
        {
            return ldap.NetBiosDomainName + "\\" + entry.Property(
                context: context,
                name: "sAMAccountName");
        }

        private static string DN(this LdapConnection con, ParameterAccessor.Parts.Ldap ldap)
        {
            return (new LdapUrl(ldap.LdapSearchRoot)).getDN();
        }

        private static LdapEntry FindOne(this LdapSearchResults results)
        {
            return results.hasMore() ? results.next() : null;
        }
    }
}