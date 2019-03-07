using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Responses;
using Implem.Pleasanter.Libraries.Settings;
using Implem.Pleasanter.Models;
using System.Web;
using System.Web.Mvc;
namespace Implem.Pleasanter.Controllers
{
    public class BinariesController
    {
        public ActionResult SiteImageThumbnail(IContext context, string reference, long id)
        {
            if (reference.ToLower() == "items")
            {
                var bytes = BinaryUtilities.SiteImageThumbnail(
                    context: context,
                    siteModel: new SiteModel(context: context, siteId: id));
                return new FileContentResult(bytes, "image/png");
            }
            else
            {
                return null;
            }
        }

        public ActionResult SiteImageIcon(IContext context, string reference, long id)
        {
            if (reference.ToLower() == "items")
            {
                var bytes = BinaryUtilities.SiteImageIcon(
                    context: context,
                    siteModel: new SiteModel(context: context, siteId: id));
                return new FileContentResult(bytes, "image/png");
            }
            else
            {
                return null;
            }
        }

        public ActionResult TenantImageLogo(IContext context)
        {
            var log = new SysLogModel(context: context);
            var bytes = BinaryUtilities.TenantImageLogo(
                context: context,
                tenantModel: new TenantModel(
                    context: context,
                    ss: SiteSettingsUtilities.TenantsSiteSettings(context)));
            log.Finish(
                context: context,
                responseSize: bytes.Length);
            return new FileContentResult(bytes, "image/png");
        }

        public string UpdateSiteImage(IContext context, string reference, long id, IHttpPostedFile[] file)
        {
            var log = new SysLogModel(context: context);
            var json = reference.ToLower() == "items"
                ? BinaryUtilities.UpdateSiteImage(
                    context: context,
                    siteModel: new SiteModel(context: context, siteId: id))
                : new ResponseCollection().ToJson();
            log.Finish(context: context);
            return json;
        }

        public string UpdateTenantImage(IContext context, IHttpPostedFile[] file)
        {
            var ss = SiteSettingsUtilities.TenantsSiteSettings(context);
            var tenantModel = new TenantModel(context, ss).Get(context, ss);
            var log = new SysLogModel(context: context);
            var json = BinaryUtilities.UpdateTenantImage(
                context: context,
                tenantModel: tenantModel);
            log.Finish(context: context);
            return json;
        }

        public string DeleteSiteImage(IContext context, string reference, long id)
        {
            var log = new SysLogModel(context: context);
            var json = reference.ToLower() == "items"
                ? BinaryUtilities.DeleteSiteImage(
                    context: context,
                    siteModel: new SiteModel(context: context, siteId: id))
                : new ResponseCollection().ToJson();
            log.Finish(context: context);
            return json;
        }

        public string DeleteTenantImage(IContext context)
        {
            var ss = SiteSettingsUtilities.TenantsSiteSettings(context);
            var tenantModel = new TenantModel(context, ss).Get(context, ss);
            var log = new SysLogModel(context: context);
            var json = BinaryUtilities.DeleteTenantImage(
                context: context,
                tenantModel: tenantModel);
            log.Finish(context: context);
            return json;
        }

        public string UploadImage(IContext context, string reference, long id, IHttpPostedFile[] file)
        {
            var log = new SysLogModel(context: context);
            var json = BinaryUtilities.UploadImage(
                context: context,
                id: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string DeleteImage(IContext context, string reference, string guid)
        {
            var log = new SysLogModel(context: context);
            var json = BinaryUtilities.DeleteImage(context: context, guid: guid);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public string MultiUpload(IContext context, string reference, long id, IHttpPostedFile[] file)
        {
            var log = new SysLogModel(context: context);
            var json = BinaryUtilities.MultiUpload(
                context: context,
                id: id);
            log.Finish(context: context, responseSize: json.Length);
            return json;
        }

        public FileContentResult Download(IContext context, string reference, string guid)
        {
            var log = new SysLogModel(context: context);
            var file = BinaryUtilities.Donwload(context: context, guid: guid);
            log.Finish(context: context, responseSize: file?.FileContents.Length ?? 0);
            return file;
        }

        public FileContentResult DownloadTemp(IContext context, string reference, string guid)
        {
            var log = new SysLogModel(context: context);
            var file = BinaryUtilities.DownloadTemp(context: context, guid: guid);
            log.Finish(context: context, responseSize: file?.FileContents.Length ?? 0);
            return file;
        }

        public FileContentResult Show(IContext context, string reference, string guid)
        {
            var log = new SysLogModel(context: context);
            var file = BinaryUtilities.Donwload(context: context, guid: guid);
            log.Finish(context: context, responseSize: file?.FileContents.Length ?? 0);
            return file;
        }

        public FileContentResult ShowTemp(IContext context, string reference, string guid)
        {
            var log = new SysLogModel(context: context);
            var file = BinaryUtilities.DownloadTemp(context: context, guid: guid);
            log.Finish(context: context, responseSize: file?.FileContents.Length ?? 0);
            return file;
        }

        public string DeleteTemp(IContext context, string reference, long id)
        {
            var log = new SysLogModel(context: context);
            var json = BinaryUtilities.DeleteTemp(context: context);
            log.Finish(context: context, responseSize: json.Length);
            return json.ToString();
        }
    }
}