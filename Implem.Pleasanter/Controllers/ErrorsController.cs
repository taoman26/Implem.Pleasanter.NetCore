using Implem.DefinitionAccessor;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.General;
using Implem.Pleasanter.Libraries.HtmlParts;
using Implem.Pleasanter.Libraries.Requests;
using System.Web.Mvc;
namespace Implem.Pleasanter.Controllers
{
    public class ErrorsController
    {
        public string Index(IContext context)
        {
            if (!context.Ajax)
            {
                var html = HtmlTemplates.Error(
                    context: context,
                    errorType: Error.Types.ApplicationError);
                return html;
            }
            else
            {
                return Error.Types.ApplicationError.MessageJson(context: context);
            }
        }

        public string InvalidIpAddress(IContext context)
        {
            var html = HtmlTemplates.Error(
                context: context,
                errorType: Error.Types.InvalidIpAddress);
            return html;
        }

        public string BadRequest(IContext context)
        {
            // Response.StatusCode = (int)HttpStatusCode.BadRequest;
            if (!context.Ajax)
            {
                var html = HtmlTemplates.Error(
                    context: context,
                    errorType: Error.Types.BadRequest);
                return html;
            }
            else
            {
                return Error.Types.NotFound.MessageJson(context: context);
            }
        }

        public string NotFound(IContext context)
        {
            // Response.StatusCode = (int)HttpStatusCode.NotFound;
            if (!context.Ajax)
            {
                var html = HtmlTemplates.Error(
                    context: context,
                    errorType: Error.Types.NotFound);
                return html;
            }
            else
            {
                return Error.Types.NotFound.MessageJson(context: context);
            }
        }

        public string ParameterSyntaxError(IContext context)
        {
            var messageData = new string[]
            {
                Parameters.SyntaxErrors?.Join(",")
            };
            if (!context.Ajax)
            {
                var html = HtmlTemplates.Error(
                    context: context,
                    errorType: Error.Types.ParameterSyntaxError,
                    messageData: messageData);
                return html;
            }
            else
            {
                return Error.Types.ParameterSyntaxError.MessageJson(
                    context: context,
                    data: messageData);
            }
        }

        public string InternalServerError(IContext context)
        {
            // Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            if (!context.Ajax)
            {
                var html = HtmlTemplates.Error(
                    context: context,
                    errorType: Error.Types.InternalServerError);
                return html;
            }
            else
            {
                return Error.Types.InternalServerError.MessageJson(context: context);
            }
        }

        public string LoginIdAlreadyUse(IContext context)
        {
            var html = HtmlTemplates.Error(
                context: context,
                errorType: Error.Types.LoginIdAlreadyUse);
            return html;
        }
    }
}
