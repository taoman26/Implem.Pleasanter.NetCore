using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using Implem.Pleasanter.Models;
using System.Configuration;
namespace Implem.Pleasanter.Libraries.Security
{
    public static class Authentications
    {
        public static string SignIn(IContext context, string returnUrl)
        {
            return new UserModel(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                setByForm: true)
                    .Authenticate(context: context, returnUrl: returnUrl);
        }

        public static bool Try(IContext context, string loginId, string password)
        {
            return new UserModel(
                context: context,
                ss: SiteSettingsUtilities.UsersSiteSettings(context: context),
                setByForm: true)
                    .Authenticate(context: context);
        }

        public static void SignOut(IContext context)
        {
            context.FormsAuthenticationSignOut();
            context.FederatedAuthenticationSessionAuthenticationModuleDeleteSessionTokenCookie();
            context.SessionAbandon();
        }

        public static bool Windows(IContext context)
        {
            return context.AuthenticationsWindows();
        }
    }
}