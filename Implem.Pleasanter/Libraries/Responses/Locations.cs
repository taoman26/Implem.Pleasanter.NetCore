using Implem.DefinitionAccessor;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Security;
using System.Linq;
namespace Implem.Pleasanter.Libraries.Responses
{
    public static class Locations
    {
        public static string Top(IContext context)
        {
            return Get(context: context);
        }

        public static string BaseUrl(IContext context)
        {
            return Get(
                context: context,
                parts: context.Controller) + "/";
        }

        public static string Login(IContext context)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "Users",
                    "Login"
                });
        }

        public static string Logout(IContext context)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "Users",
                    "Logout"
                }); 
        }

        public static string Admins(IContext context)
        {
            return Get(
                context: context,
                parts: "Admins");
        }

        public static string Index(IContext context, string controller)
        {
            return Get(
                context: context,
                parts: controller);
        }

        public static string ItemIndex(IContext context, long id)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    context.Publish
                        ? "Publishes"
                        : "Items",
                    id.ToString(),
                    "Index"
                });
        }

        public static string ItemTrashBox(IContext context, long id)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "Items",
                    id.ToString(),
                    "TrashBox"
                });
        }

        public static string New(IContext context, string controller)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    controller,
                    "New"
                });
        }

        public static string ItemNew(IContext context, long id)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "Items",
                    id.ToString(),
                    "New"
                });
        }

        public static string Edit(IContext context, string controller)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    controller,
                    "Edit"
                });
        }

        public static string Edit(IContext context, string controller, long id)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    controller,
                    id.ToString(),
                    "Edit"
                });
        }

        public static string ItemEdit(IContext context, long id)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    context.Publish
                        ? "Publishes"
                        : "Items",
                    id.ToString(),
                    "Edit"
                });
        }

        public static string ItemEditAbsoluteUri(IContext context, long id)
        {
            return Parameters.Service.AbsoluteUri != null
                ? Parameters.Service.AbsoluteUri + "/items/" + id
                : context.AbsoluteUri.Replace(
                    context.AbsolutePath,
                    ItemEdit(
                        context: context,
                        id: id));
        }

        public static string DemoUri(IContext context, string passphrase)
        {
            var path = "/demos/login?passphrase=" + passphrase;
            return Parameters.Service.AbsoluteUri != null
                ? Parameters.Service.AbsoluteUri + path
                : context.AbsoluteUri.Replace(
                    context.AbsolutePath,
                    Get(
                        context: context,
                        parts: path));
        }

        public static string ItemView(IContext context, long id, string action)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "Items",
                    id.ToString(),
                    action
                });
        }

        public static string Images(IContext context, params string[] parts)
        {
            var imageUrl = parts.ToList();
            imageUrl.Insert(0, "Images");
            return Get(
                context: context,
                parts: imageUrl.ToArray());
        }

        public static string Action(IContext context, string controller)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    controller,
                    "_action_"
                });
        }

        public static string Action(IContext context, string controller, long id)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    controller,
                    id.ToString(),
                    "_action_"
                });
        }

        public static string Action(IContext context, string table, long id, string controller)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    table,
                    id.ToString(),
                    controller,
                    "_action_"
                });
        }

        public static string ItemAction(IContext context, long id)
        {
            return id != -1
                ? Get(
                    context: context,
                    parts: new string[]
                    {
                        context.Publish
                            ? "Publishes"
                            : "Items",
                        id.ToString(),
                        "_action_"
                    })
                : Get(
                    context: context,
                    parts: new string[]
                    {
                        "Items",
                        "_action_"
                    });
        }

        public static string DeleteImage(IContext context, string guid)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "binaries",
                    guid,
                    "deleteimage"
                });
        }

        public static string DownloadFile(IContext context, string guid, bool temp = false)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "binaries",
                    guid,
                    !temp
                        ? "/download"
                        : "/downloadtemp"
                });
        }

        public static string ShowFile(IContext context, string guid, bool temp = false)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "binaries",
                    guid,
                    !temp
                        ? "/show"
                        : "/showtemp"
                });
        }

        public static string BadRequest(IContext context)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "Errors",
                    "BadRequest"
                });
        }

        public static string InvalidIpAddress(IContext context)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "Errors",
                    "InvalidIpAddress"
                });
        }

        public static string LoginIdAlreadyUse(IContext context)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "Errors",
                    "LoginIdAlreadyUse"
                });
        }

        public static string ParameterSyntaxError(IContext context)
        {
            return Get(
                context: context,
                parts: new string[]
                {
                    "Errors",
                    "ParameterSyntaxError"
                });
        }

        public static string ApplicationError(IContext context)
        {
            return Get(
                context: context,
                parts: "Errors");
        }

        public static string Get(IContext context, params string[] parts)
        {
            return Raw(
                context: context,
                parts: parts).ToLower();
        }

        public static string Raw(IContext context, params string[] parts)
        {
            return context.ApplicationPath + parts
                .Select(o => Trim(o))
                .Where(o => o != string.Empty)
                .Join("/");
        }

        private static string Trim(string data)
        {
            var ret = data;
            ret = ret.StartsWith("/") ? ret.Substring(1) : ret;
            ret = ret.EndsWith("/") ? ret.Substring(0, ret.Length - 1) : ret;
            return ret;
        }
    }
}
