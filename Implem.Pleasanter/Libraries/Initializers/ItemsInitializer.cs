﻿using Implem.DefinitionAccessor;
using Implem.Libraries.DataSources.SqlServer;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.DataSources;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Responses;
using Implem.Pleasanter.Libraries.Settings;
using Implem.Pleasanter.Models;
using System;
using System.Data;
using System.Linq;
namespace Implem.Pleasanter.Libraries.Initializers
{
    public static class ItemsInitializer
    {
        public static void Initialize(Context context)
        {
            if (!context.HasPrivilege) return;
            var sqlExists = "exists (select * from {0} where {1}={2})";
            Rds.ExecuteNonQuery(
                context: context,
                statements: Rds.PhysicalDeleteItems(
                    where: Rds.ItemsWhere().Add(raw: sqlExists.Params(
                        "[Items_Deleted]",
                        "[Items_Deleted].[ReferenceId]",
                        "[Items].[ReferenceId]"))));
            Rds.ExecuteNonQuery(
                context: context,
                statements: Rds.PhysicalDeleteSites(
                    where: Rds.ItemsWhere().Add(raw: sqlExists.Params(
                        "[Sites_Deleted]",
                        "[Sites_Deleted].[SiteId]",
                        "[Sites].[SiteId]"))));
            Rds.ExecuteNonQuery(
                context: context,
                statements: Rds.DeleteSites(
                    where: Rds.ItemsWhere().Add(raw: sqlExists.Params(
                        "[Items_Deleted]",
                        "[Items_Deleted].[ReferenceId]",
                        "[Sites].[SiteId]"))));
            new SiteCollection(
                context: context,
                where: Rds.SitesWhere().Add(raw: "not " + sqlExists.Params(
                    "[Items]",
                    "[Items].[ReferenceId]",
                    "[Sites].[SiteId]")),
                tableType: Sqls.TableTypes.Normal)
                    .ForEach(siteModel =>
                    {
                        if (siteModel.SiteSettings != null)
                        {
                            var fullText = siteModel.FullText(
                                context: context.CreateContext(tenantId: siteModel.TenantId),
                                ss: siteModel.SiteSettings);
                            Rds.ExecuteNonQuery(
                                context: context.CreateContext(tenantId: siteModel.TenantId),
                                connectionString: Parameters.Rds.OwnerConnectionString,
                                statements: new SqlStatement[]
                                {
                                    Rds.IdentityInsertItems(on: true),
                                    Rds.InsertItems(
                                        param: Rds.ItemsParam()
                                            .ReferenceId(siteModel.SiteId)
                                            .ReferenceType("Sites")
                                            .SiteId(siteModel.SiteId)
                                            .Title(siteModel.Title.Value)
                                            .FullText(fullText, _using: fullText != null)
                                            .SearchIndexCreatedTime(DateTime.Now)),
                                    Rds.IdentityInsertItems(on: false)
                                });
                        }
                    });
            new SiteCollection(
                context: context,
                where: Rds.SitesWhere().Add(raw: "not " + sqlExists.Params(
                    "[Items_Deleted]",
                    "[Items_Deleted].[ReferenceId]",
                    "[Sites].[SiteId]")),
                tableType: Sqls.TableTypes.Deleted)
                    .ForEach(siteModel =>
                    {
                        if (siteModel.SiteSettings != null)
                        {
                            Rds.ExecuteNonQuery(
                                context: context.CreateContext(tenantId: siteModel.TenantId),
                                statements: new SqlStatement[]
                                {
                                    Rds.InsertItems(
                                        tableType: Sqls.TableTypes.Deleted,
                                        param: Rds.ItemsParam()
                                            .ReferenceId(siteModel.SiteId)
                                            .Ver(siteModel.Ver)
                                            .ReferenceType("Sites")
                                            .SiteId(siteModel.SiteId)
                                            .Title(siteModel.Title.Value))
                                });
                }
            });
            Rds.ExecuteNonQuery(
                context: context,
                statements: Rds.PhysicalDeleteIssues(
                    where: Rds.ItemsWhere().Add(raw: sqlExists.Params(
                        "[Issues_Deleted]",
                        "[Issues_Deleted].[IssueId]",
                        "[Issues].[IssueId]"))));
            Rds.ExecuteNonQuery(
                context: context,
                statements: Rds.DeleteIssues(
                    where: Rds.ItemsWhere().Add(raw: sqlExists.Params(
                        "[Items_Deleted]",
                        "[Items_Deleted].[ReferenceId]",
                        "[Issues].[IssueId]"))));
            Rds.ExecuteTable(
                context: context,
                statements: Rds.SelectIssues(
                    tableType: Sqls.TableTypes.Normal,
                    column: Rds.IssuesColumn()
                        .SiteId()
                        .IssueId()
                        .Ver()
                        .Sites_TenantId(),
                    join: Rds.IssuesJoinDefault()
                        .Add(
                            tableName: "Items",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Items].[ReferenceId]=[Issues].[IssueId]")
                        .Add(
                            tableName: "Sites",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Sites].[SiteId]=[Issues].[SiteId]"),
                    where: Rds.ItemsWhere()
                        .ReferenceId(
                            tableName: "Items",
                            _operator: " is null")))
                                .AsEnumerable()
                                .ForEach(dataRow =>
                                {
                                    var siteId = dataRow.Long("SiteId");
                                    var ss = new SiteModel().Get(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        where: Rds.SitesWhere().SiteId(siteId))?
                                            .IssuesSiteSettings(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                referenceId: dataRow.Long("IssueId"));
                                    var issueModel = new IssueModel(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        ss: ss)
                                            .Get(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                ss: ss,
                                                tableType: Sqls.TableTypes.Normal,
                                                where: Rds.IssuesWhere()
                                                    .SiteId(dataRow.Long("SiteId"))
                                                    .IssueId(dataRow.Long("IssueId"))
                                                    .Ver(dataRow.Int("Ver")));
                                    if (ss != null &&
                                        issueModel.AccessStatus == Databases.AccessStatuses.Selected)
                                    {
                                        var fullText = issueModel.FullText(
                                            context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                            ss: ss);
                                        Rds.ExecuteNonQuery(
                                            context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                            connectionString: Parameters.Rds.OwnerConnectionString,
                                            statements: new SqlStatement[]
                                            {
                                                Rds.IdentityInsertItems(on: true),
                                                Rds.InsertItems(
                                                    param: Rds.ItemsParam()
                                                        .ReferenceId(issueModel.IssueId)
                                                        .ReferenceType("Issues")
                                                        .SiteId(issueModel.SiteId)
                                                        .Title(issueModel.Title.DisplayValue)
                                                        .FullText(fullText, _using: fullText != null)
                                                        .SearchIndexCreatedTime(DateTime.Now)),
                                                Rds.IdentityInsertItems(on: false)
                                            });
                                    }
                                });
            Rds.ExecuteTable(
                context: context,
                statements: Rds.SelectIssues(
                    tableType: Sqls.TableTypes.Deleted,
                    column: Rds.IssuesColumn()
                        .SiteId()
                        .IssueId()
                        .Ver(),
                    join: Rds.IssuesJoinDefault()
                        .Add(
                            tableName: "Items_Deleted",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Items_Deleted].[ReferenceId]=[Issues].[IssueId]")
                        .Add(
                            tableName: "Sites",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Sites].[SiteId]=[Issues].[SiteId]"),
                    where: Rds.ItemsWhere()
                        .ReferenceId(
                            tableName: "Items_Deleted",
                            _operator: " is null")))
                                .AsEnumerable()
                                .ForEach(dataRow =>
                                {
                                    var siteId = dataRow.Long("SiteId");
                                    var ss = new SiteModel().Get(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        where: Rds.SitesWhere().SiteId(siteId))?
                                            .IssuesSiteSettings(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                referenceId: dataRow.Long("IssueId"));
                                    var issueModel = new IssueModel(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        ss: ss)
                                            .Get(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                ss: ss,
                                                tableType: Sqls.TableTypes.Deleted,
                                                where: Rds.IssuesWhere()
                                                    .SiteId(dataRow.Long("SiteId"))
                                                    .IssueId(dataRow.Long("IssueId"))
                                                    .Ver(dataRow.Int("Ver")));
                                    if (ss != null &&
                                        issueModel.AccessStatus == Databases.AccessStatuses.Selected)
                                    {
                                        Rds.ExecuteNonQuery(
                                            context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                            statements: new SqlStatement[]
                                            {
                                                Rds.InsertItems(
                                                    tableType: Sqls.TableTypes.Deleted,
                                                    param: Rds.ItemsParam()
                                                        .ReferenceId(issueModel.IssueId)
                                                        .Ver(issueModel.Ver)
                                                        .ReferenceType("Issues")
                                                        .SiteId(issueModel.SiteId)
                                                        .Title(issueModel.Title.DisplayValue))
                                            });
                                    }
                                });
            Rds.ExecuteNonQuery(
                context: context,
                statements: Rds.PhysicalDeleteResults(
                    where: Rds.ItemsWhere().Add(raw: sqlExists.Params(
                        "[Results_Deleted]",
                        "[Results_Deleted].[ResultId]",
                        "[Results].[ResultId]"))));
            Rds.ExecuteNonQuery(
                context: context,
                statements: Rds.DeleteResults(
                    where: Rds.ItemsWhere().Add(raw: sqlExists.Params(
                        "[Items_Deleted]",
                        "[Items_Deleted].[ReferenceId]",
                        "[Results].[ResultId]"))));
            Rds.ExecuteTable(
                context: context,
                statements: Rds.SelectResults(
                    tableType: Sqls.TableTypes.Normal,
                    column: Rds.ResultsColumn()
                        .SiteId()
                        .ResultId()
                        .Ver()
                        .Sites_TenantId(),
                    join: Rds.ResultsJoinDefault()
                        .Add(
                            tableName: "Items",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Items].[ReferenceId]=[Results].[ResultId]")
                        .Add(
                            tableName: "Sites",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Sites].[SiteId]=[Results].[SiteId]"),
                    where: Rds.ItemsWhere()
                        .ReferenceId(
                            tableName: "Items",
                            _operator: " is null")))
                                .AsEnumerable()
                                .ForEach(dataRow =>
                                {
                                    var siteId = dataRow.Long("SiteId");
                                    var ss = new SiteModel().Get(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        where: Rds.SitesWhere().SiteId(siteId))?
                                            .ResultsSiteSettings(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                referenceId: dataRow.Long("ResultId"));
                                    var resultModel = new ResultModel(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        ss: ss)
                                            .Get(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                ss: ss,
                                                tableType: Sqls.TableTypes.Normal,
                                                where: Rds.ResultsWhere()
                                                    .SiteId(dataRow.Long("SiteId"))
                                                    .ResultId(dataRow.Long("ResultId"))
                                                    .Ver(dataRow.Int("Ver")));
                                    if (ss != null &&
                                        resultModel.AccessStatus == Databases.AccessStatuses.Selected)
                                    {
                                        var fullText = resultModel.FullText(
                                            context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                            ss: ss);
                                        Rds.ExecuteNonQuery(
                                            context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                            connectionString: Parameters.Rds.OwnerConnectionString,
                                            statements: new SqlStatement[]
                                            {
                                                Rds.IdentityInsertItems(on: true),
                                                Rds.InsertItems(
                                                    param: Rds.ItemsParam()
                                                        .ReferenceId(resultModel.ResultId)
                                                        .ReferenceType("Results")
                                                        .SiteId(resultModel.SiteId)
                                                        .Title(resultModel.Title.DisplayValue)
                                                        .FullText(fullText, _using: fullText != null)
                                                        .SearchIndexCreatedTime(DateTime.Now)),
                                                Rds.IdentityInsertItems(on: false)
                                            });
                                    }
                                });
            Rds.ExecuteTable(
                context: context,
                statements: Rds.SelectResults(
                    tableType: Sqls.TableTypes.Deleted,
                    column: Rds.ResultsColumn()
                        .SiteId()
                        .ResultId()
                        .Ver(),
                    join: Rds.ResultsJoinDefault()
                        .Add(
                            tableName: "Items_Deleted",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Items_Deleted].[ReferenceId]=[Results].[ResultId]")
                        .Add(
                            tableName: "Sites",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Sites].[SiteId]=[Results].[SiteId]"),
                    where: Rds.ItemsWhere()
                        .ReferenceId(
                            tableName: "Items_Deleted",
                            _operator: " is null")))
                                .AsEnumerable()
                                .ForEach(dataRow =>
                                {
                                    var siteId = dataRow.Long("SiteId");
                                    var ss = new SiteModel().Get(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        where: Rds.SitesWhere().SiteId(siteId))?
                                            .ResultsSiteSettings(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                referenceId: dataRow.Long("ResultId"));
                                    var resultModel = new ResultModel(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        ss: ss)
                                            .Get(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                ss: ss,
                                                tableType: Sqls.TableTypes.Deleted,
                                                where: Rds.ResultsWhere()
                                                    .SiteId(dataRow.Long("SiteId"))
                                                    .ResultId(dataRow.Long("ResultId"))
                                                    .Ver(dataRow.Int("Ver")));
                                    if (ss != null &&
                                        resultModel.AccessStatus == Databases.AccessStatuses.Selected)
                                    {
                                        Rds.ExecuteNonQuery(
                                            context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                            statements: new SqlStatement[]
                                            {
                                                Rds.InsertItems(
                                                    tableType: Sqls.TableTypes.Deleted,
                                                    param: Rds.ItemsParam()
                                                        .ReferenceId(resultModel.ResultId)
                                                        .Ver(resultModel.Ver)
                                                        .ReferenceType("Results")
                                                        .SiteId(resultModel.SiteId)
                                                        .Title(resultModel.Title.DisplayValue))
                                            });
                                    }
                                });
            Rds.ExecuteNonQuery(
                context: context,
                statements: Rds.PhysicalDeleteWikis(
                    where: Rds.ItemsWhere().Add(raw: sqlExists.Params(
                        "[Wikis_Deleted]",
                        "[Wikis_Deleted].[WikiId]",
                        "[Wikis].[WikiId]"))));
            Rds.ExecuteNonQuery(
                context: context,
                statements: Rds.DeleteWikis(
                    where: Rds.ItemsWhere().Add(raw: sqlExists.Params(
                        "[Items_Deleted]",
                        "[Items_Deleted].[ReferenceId]",
                        "[Wikis].[WikiId]"))));
            Rds.ExecuteTable(
                context: context,
                statements: Rds.SelectWikis(
                    tableType: Sqls.TableTypes.Normal,
                    column: Rds.WikisColumn()
                        .SiteId()
                        .WikiId()
                        .Ver()
                        .Sites_TenantId(),
                    join: Rds.WikisJoinDefault()
                        .Add(
                            tableName: "Items",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Items].[ReferenceId]=[Wikis].[WikiId]")
                        .Add(
                            tableName: "Sites",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Sites].[SiteId]=[Wikis].[SiteId]"),
                    where: Rds.ItemsWhere()
                        .ReferenceId(
                            tableName: "Items",
                            _operator: " is null")))
                                .AsEnumerable()
                                .ForEach(dataRow =>
                                {
                                    var siteId = dataRow.Long("SiteId");
                                    var ss = new SiteModel().Get(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        where: Rds.SitesWhere().SiteId(siteId))?
                                            .WikisSiteSettings(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                referenceId: dataRow.Long("WikiId"));
                                    var wikiModel = new WikiModel(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        ss: ss)
                                            .Get(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                ss: ss,
                                                tableType: Sqls.TableTypes.Normal,
                                                where: Rds.WikisWhere()
                                                    .SiteId(dataRow.Long("SiteId"))
                                                    .WikiId(dataRow.Long("WikiId"))
                                                    .Ver(dataRow.Int("Ver")));
                                    if (ss != null &&
                                        wikiModel.AccessStatus == Databases.AccessStatuses.Selected)
                                    {
                                        var fullText = wikiModel.FullText(
                                            context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                            ss: ss);
                                        Rds.ExecuteNonQuery(
                                            context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                            connectionString: Parameters.Rds.OwnerConnectionString,
                                            statements: new SqlStatement[]
                                            {
                                                Rds.IdentityInsertItems(on: true),
                                                Rds.InsertItems(
                                                    param: Rds.ItemsParam()
                                                        .ReferenceId(wikiModel.WikiId)
                                                        .ReferenceType("Wikis")
                                                        .SiteId(wikiModel.SiteId)
                                                        .Title(wikiModel.Title.DisplayValue)
                                                        .FullText(fullText, _using: fullText != null)
                                                        .SearchIndexCreatedTime(DateTime.Now)),
                                                Rds.IdentityInsertItems(on: false)
                                            });
                                    }
                                });
            Rds.ExecuteTable(
                context: context,
                statements: Rds.SelectWikis(
                    tableType: Sqls.TableTypes.Deleted,
                    column: Rds.WikisColumn()
                        .SiteId()
                        .WikiId()
                        .Ver(),
                    join: Rds.WikisJoinDefault()
                        .Add(
                            tableName: "Items_Deleted",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Items_Deleted].[ReferenceId]=[Wikis].[WikiId]")
                        .Add(
                            tableName: "Sites",
                            joinType: SqlJoin.JoinTypes.LeftOuter,
                            joinExpression: "[Sites].[SiteId]=[Wikis].[SiteId]"),
                    where: Rds.ItemsWhere()
                        .ReferenceId(
                            tableName: "Items_Deleted",
                            _operator: " is null")))
                                .AsEnumerable()
                                .ForEach(dataRow =>
                                {
                                    var siteId = dataRow.Long("SiteId");
                                    var ss = new SiteModel().Get(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        where: Rds.SitesWhere().SiteId(siteId))?
                                            .WikisSiteSettings(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                referenceId: dataRow.Long("WikiId"));
                                    var wikiModel = new WikiModel(
                                        context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                        ss: ss)
                                            .Get(
                                                context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                                ss: ss,
                                                tableType: Sqls.TableTypes.Deleted,
                                                where: Rds.WikisWhere()
                                                    .SiteId(dataRow.Long("SiteId"))
                                                    .WikiId(dataRow.Long("WikiId"))
                                                    .Ver(dataRow.Int("Ver")));
                                    if (ss != null &&
                                        wikiModel.AccessStatus == Databases.AccessStatuses.Selected)
                                    {
                                        Rds.ExecuteNonQuery(
                                            context: context.CreateContext(tenantId: dataRow.Int("TenantId")),
                                            statements: new SqlStatement[]
                                            {
                                                Rds.InsertItems(
                                                    tableType: Sqls.TableTypes.Deleted,
                                                    param: Rds.ItemsParam()
                                                        .ReferenceId(wikiModel.WikiId)
                                                        .Ver(wikiModel.Ver)
                                                        .ReferenceType("Wikis")
                                                        .SiteId(wikiModel.SiteId)
                                                        .Title(wikiModel.Title.DisplayValue))
                                            });
                                    }
                                });
        }
    }
}
