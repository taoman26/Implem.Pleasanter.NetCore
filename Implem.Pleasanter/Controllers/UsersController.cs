using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Responses;
using Implem.Pleasanter.Libraries.Security;
using Implem.Pleasanter.Libraries.Settings;
using Implem.Pleasanter.Models;
using System.Web;
using System.Web.Mvc;
using Implem.DefinitionAccessor;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.DataSources;
using System.Security.Claims;
namespace Implem.Pleasanter.Controllers
{
    public class UsersController
    {
        public string Index(IContext context)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = UserUtilities.Index(
                    context: context,
                    ss: SiteSettingsUtilities.UsersSiteSettings(context: context));
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = UserUtilities.IndexJson(
                    context: context,
                    ss: SiteSettingsUtilities.UsersSiteSettings(context: context));
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string New(IContext context, long id = 0)
        {
            var log = new SysLogModel(context: context);
            var html = UserUtilities.EditorNew(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context));
            log.Finish(context: context, responseSize: html.Length);
            return html;
        }

        public string Edit(IContext context, int id)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = UserUtilities.Editor(
                    context: context,
                    ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                    userId: id,
                    clearSessions: true);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = UserUtilities.EditorJson(
                    context: context,
                    ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                    userId: id);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string GridRows(IContext context)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.GridRows(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Create(IContext context)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.Create(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context));
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Update(IContext context, int id)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.Update(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                userId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Delete(IContext context, int id)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.Delete(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                userId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string DeleteComment(IContext context, int id)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.Update(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                userId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Histories(IContext context, int id)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.Histories(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                userId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string History(IContext context, int id)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.History(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                userId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string BulkDelete(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.BulkDelete(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context));
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Import(IContext context, long id, IHttpPostedFile[] file)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.Import(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string OpenExportSelectorDialog(IContext context)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.OpenExportSelectorDialog(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context));
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public FileContentResult Export(IContext context)
        {
            var log = new SysLogModel(context: context);
            var responseFile = UserUtilities.Export(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context));
            if (responseFile != null)
            {
                log.Finish(context: context, responseSize: responseFile.Length);
                return responseFile.ToFile();
            }
            else
            {
                log.Finish(context: context, responseSize: 0);
                return null;
            }
        }

        public (string redirectUrl, string redirectResultUrl, string html) Login(IContext context, string returnUrl, string ssocode = "")
        {
            var log = new SysLogModel(context: context);
            if (context.Authenticated)
            {
                if (context.QueryStrings.Bool("new"))
                {
                    Authentications.SignOut(context: context);
                }
                log.Finish(context: context);
                return (Locations.Top(context: context), null, null);
            }
            if (Parameters.Authentication.Provider == "SAML")
            {
                var tenant = new TenantModel().Get(
                    context: context,
                    ss: SiteSettingsUtilities.TenantsSiteSettings(context), 
                    where: Rds.TenantsWhere().Comments(ssocode));
                if (tenant.AccessStatus == Databases.AccessStatuses.Selected)
                {
                    var redirectUrl = Saml.SetIdpConfiguration(context, tenant.TenantId);
                    if (redirectUrl != null)
                    {
                        return (null, redirectUrl, null);
                    }
                }
            }
            var html = UserUtilities.HtmlLogin(
                context: context,
                returnUrl: returnUrl,
                message: context.QueryStrings.ContainsKey("expired") && context.QueryStrings["expired"] == "1" && !context.Ajax
                    ? Messages.Expired(context: context).Text
                    : string.Empty);
            log.Finish(context: context, responseSize: html.Length);
            return (null, null, html);
        }

        public RedirectResult SamlLogin(IContext context)
        {
            if (context.AuthenticationType == "Federation"
                && context.IsAuthenticated == true)
            {
                Authentications.SignOut(context: context);
                var loginId = ClaimsPrincipal.Current.FindFirst(ClaimTypes.NameIdentifier);
                var firstName = string.Empty;
                var lastName = string.Empty;
                var tenantManager = false;
                foreach(var claim in ClaimsPrincipal.Current.Claims)
                {
                    switch (claim.Type)
                    {
                        case "FirstName":
                            firstName = claim.Value;
                            break;
                        case "LastName":
                            lastName = claim.Value;
                            break;
                        case "TenantManager":
                            tenantManager = claim.Value.ToLower() == "true" ? true : false;
                            break;
                    }
                }
                var ssocode = loginId.Issuer.TrimEnd('/').Substring(loginId.Issuer.TrimEnd('/').LastIndexOf('/') + 1);
                var tenant = new TenantModel().Get(
                    context: context,
                    ss:SiteSettingsUtilities.TenantsSiteSettings(context), 
                    where: Rds.TenantsWhere().Comments(ssocode));
                try
                {
                    Saml.UpdateOrInsert(
                        context: context,
                        tenantId: tenant.TenantId,
                        loginId: loginId.Value,
                        name: lastName + "　" + firstName,
                        mailAddress: loginId.Value,
                        tenantManager: tenantManager,
                        synchronizedTime: System.DateTime.Now);
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    if (e.Number == 2601)
                    {
                        return new RedirectResult(Locations.LoginIdAlreadyUse(context: context));
                    }
                    throw;
                }
                var user = new UserModel().Get(
                    context: context,
                    ss: null,
                    where: Rds.UsersWhere()
                        .TenantId(tenant.TenantId)
                        .LoginId(loginId.Value)
                        .Disabled(0));
                if (user.AccessStatus == Databases.AccessStatuses.Selected)
                {
                    user.Allow(context: context, returnUrl: Locations.Top(context), createPersistentCookie: true);
                    return new RedirectResult(Locations.Top(context));
                }
            }
            return new RedirectResult(Locations.Login(context));
        }

        public string Authenticate(IContext context, string returnUrl)
        {
            var log = new SysLogModel(context: context);
            var json = Authentications.SignIn(context: context, returnUrl: returnUrl);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Logout(IContext context, string returnUrl)
        {
            var log = new SysLogModel(context: context);
            Authentications.SignOut(context: context);
            var url = Locations.Login(context: context);
            log.Finish(context: context);
            return url;
        }

        public string ChangePassword(IContext context, int id)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.ChangePassword(context: context, userId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string ChangePasswordAtLogin(IContext context)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.ChangePasswordAtLogin(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string ResetPassword(IContext context, int id)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.ResetPassword(context: context, userId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string AddMailAddress(IContext context, int id)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.AddMailAddresses(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                userId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string DeleteMailAddresses(IContext context, int id)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.DeleteMailAddresses(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                userId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SyncByLdap(IContext context)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.SyncByLdap(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string EditApi(IContext context)
        {
            var log = new SysLogModel(context: context);
            var html = UserUtilities.ApiEditor(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context));
            log.Finish(context: context, responseSize: html.Length);
            return html;
        }

        public string CreateApiKey(IContext context)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.CreateApiKey(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context));
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string DeleteApiKey(IContext context)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.DeleteApiKey(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context));
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SwitchUser(IContext context)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.SwitchUser(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string ReturnOriginalUser(IContext context)
        {
            var log = new SysLogModel(context: context);
            var json = UserUtilities.ReturnOriginalUser(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }
    }
}
