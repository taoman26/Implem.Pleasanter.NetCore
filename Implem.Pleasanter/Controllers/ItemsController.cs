using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Responses;
using Implem.Pleasanter.Models;
using System.Web;
using System.Web.Mvc;
namespace Implem.Pleasanter.Controllers
{
    public class ItemsController
    {
        public string Index(IContext context, long id = 0)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).Index(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).IndexJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string TrashBox(IContext context, long id = 0)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).TrashBox(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).TrashBoxJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string Calendar(IContext context, long id = 0)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).Calendar(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).CalendarJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string Crosstab(IContext context, long id = 0)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).Crosstab(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).CrosstabJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string Gantt(IContext context, long id = 0)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).Gantt(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).GanttJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string BurnDown(IContext context, long id = 0)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).BurnDown(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).BurnDownJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string TimeSeries(IContext context, long id = 0)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).TimeSeries(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).TimeSeriesJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string Kamban(IContext context, long id = 0)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).Kamban(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).KambanJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string ImageLib(IContext context, long id = 0)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).ImageLib(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).ImageLibJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string New(IContext context, long id = 0)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).New(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).NewJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string Edit(IContext context, long id)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = new ItemModel(context: context, referenceId: id).Editor(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = new ItemModel(context: context, referenceId: id).EditorJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string LinkTable(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).LinkTable(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Import(IContext context, long id, IHttpPostedFile[] file)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).Import(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string OpenExportSelectorDialog(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).OpenExportSelectorDialog(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public FileContentResult Export(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var responseFile = new ItemModel(context: context, referenceId: id).Export(context: context);
            if (responseFile != null)
            {
                log.Finish(context: context, responseSize: responseFile.Length);
                return responseFile.ToFile();
            }
            else
            {
                log.Finish(context: context);
                return null;
            }
        }

        public FileContentResult ExportCrosstab(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var responseFile = new ItemModel(context: context, referenceId: id).ExportCrosstab(context: context);
            if (responseFile != null)
            {
                log.Finish(context: context, responseSize: responseFile.Length);
                return responseFile.ToFile();
            }
            else
            {
                log.Finish(context: context);
                return null;
            }
        }

        public string Search(IContext context)
        {
            if (!context.Ajax)
            {
                var log = new SysLogModel(context: context);
                var html = SearchIndexUtilities.Search(context: context);
                log.Finish(context: context, responseSize: html.Length);
                return html;
            }
            else
            {
                var log = new SysLogModel(context: context);
                var json = SearchIndexUtilities.SearchJson(context: context);
                log.Finish(context: context, responseSize: json.Length);
                return json;
            }
        }

        public string SearchDropDown(IContext context, long id = 0)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).SearchDropDown(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SelectSearchDropDown(IContext context, long id = 0)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).SelectSearchDropDown(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string GridRows(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).GridRows(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string TrashBoxGridRows(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).TrashBoxGridRows(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string ImageLibNext(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).ImageLibNext(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Create(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).Create(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string PreviewTemplate(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = SiteUtilities.PreviewTemplate(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Templates(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).Templates(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string CreateByTemplate(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).CreateByTemplate(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SiteMenu(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).SiteMenu(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Update(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).Update(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Copy(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).Copy(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string MoveTargets(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).MoveTargets(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Move(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).Move(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string MoveSiteMenu(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = SiteUtilities.MoveSiteMenu(context: context, id: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string CreateLink(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = SiteUtilities.CreateLink(context: context, id: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SortSiteMenu(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = SiteUtilities.SortSiteMenu(context: context, siteId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string BulkMove(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).BulkMove(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Delete(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).Delete(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string BulkDelete(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).BulkDelete(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string DeleteComment(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).DeleteComment(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string DeleteHistory(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).DeleteHistory(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string PhysicalDelete(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).PhysicalDelete(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Restore(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).Restore(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string RestoreFromHistory(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).RestoreFromHistory(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string EditSeparateSettings(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).EditSeparateSettings(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Separate(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).Separate(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SetSiteSettings(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new SiteModel(context: context, siteId: id)
                .SetSiteSettings(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string RebuildSearchIndexes(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = SearchIndexUtilities.RebuildSearchIndexes(
                context: context,
                siteModel: new SiteModel(
                    context: context,
                    siteId: id));
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Histories(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).Histories(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string History(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).History(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string Permissions(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.Permission(context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SearchPermissionElements(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.SearchPermissionElements(
                context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SetPermissions(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.SetPermissions(context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string OpenPermissionsDialog(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.OpenPermissionsDialog(
                context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string PermissionForCreating(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.PermissionForCreating(
                context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SetPermissionForCreating(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.SetPermissionForCreating(
                context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string OpenPermissionForCreatingDialog(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.OpenPermissionForCreatingDialog(
                context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string ColumnAccessControl(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.ColumnAccessControl(context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SetColumnAccessControl(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.SetColumnAccessControl(
                context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string OpenColumnAccessControlDialog(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.OpenColumnAccessControlDialog(
                context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SearchColumnAccessControl(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = PermissionUtilities.SearchColumnAccessControl(
                context: context, referenceId: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string BurnDownRecordDetails(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).BurnDownRecordDetailsJson(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string UpdateByCalendar(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).UpdateByCalendar(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string UpdateByKamban(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).UpdateByKamban(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SynchronizeTitles(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).SynchronizeTitles(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SynchronizeSummaries(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).SynchronizeSummaries(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string SynchronizeFormulas(IContext context, long id)
        {
            var log = new SysLogModel(context: context);
            var json = new ItemModel(context: context, referenceId: id).SynchronizeFormulas(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }
    }
}
