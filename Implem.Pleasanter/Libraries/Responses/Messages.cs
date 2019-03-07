using Implem.Libraries.Utilities;
using Implem.ParameterAccessor.Parts;
using Implem.Pleasanter.Libraries.Html;
using Implem.Pleasanter.Libraries.Requests;
using System.Linq;
namespace Implem.Pleasanter.Libraries.Responses
{
    public static class Messages
    {
        private static Message Get(string text, string css)
        {
            var hb = new HtmlBuilder();
            return new Message(text, css);
        }

        private static ResponseCollection ResponseMessage(Message message)
        {
            return new ResponseCollection().Message(message);
        }

        public static ResponseCollection ResponseMessage(this PasswordPolicy policy, IContext context)
        {
            return new ResponseCollection().Message(policy.Languages?.Any() == true
                ? new Message(
                    text: policy.Display(context: context),
                    css: "alert-error")
                : PasswordPolicyViolation(context: context));
        }

        public static Message AlreadyAdded(IContext context, params string[] data)
        {
            return Get(
                text: Displays.AlreadyAdded(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message AlreadyLinked(IContext context, params string[] data)
        {
            return Get(
                text: Displays.AlreadyLinked(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message ApiKeyCreated(IContext context, params string[] data)
        {
            return Get(
                text: Displays.ApiKeyCreated(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message ApiKeyDeleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.ApiKeyDeleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message ApplicationError(IContext context, params string[] data)
        {
            return Get(
                text: Displays.ApplicationError(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message Authentication(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Authentication(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message BadFormat(IContext context, params string[] data)
        {
            return Get(
                text: Displays.BadFormat(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message BadMailAddress(IContext context, params string[] data)
        {
            return Get(
                text: Displays.BadMailAddress(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message BadRequest(IContext context, params string[] data)
        {
            return Get(
                text: Displays.BadRequest(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message BulkDeleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.BulkDeleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message BulkMoved(IContext context, params string[] data)
        {
            return Get(
                text: Displays.BulkMoved(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message BulkRestored(IContext context, params string[] data)
        {
            return Get(
                text: Displays.BulkRestored(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message CanNotChangeInheritance(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CanNotChangeInheritance(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message CanNotDisabled(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CanNotDisabled(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message CanNotInherit(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CanNotInherit(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message CanNotLink(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CanNotLink(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message CanNotPerformed(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CanNotPerformed(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message CanNotUpdate(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CanNotUpdate(
                    context: context,
                    data: data),
                css: "alert-info");
        }

        public static Message CantSetAtTopOfSite(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CantSetAtTopOfSite(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message ChangingPasswordComplete(IContext context, params string[] data)
        {
            return Get(
                text: Displays.ChangingPasswordComplete(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message CodeDefinerBackupCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CodeDefinerBackupCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message CodeDefinerCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CodeDefinerCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message CodeDefinerCssCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CodeDefinerCssCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message CodeDefinerDefCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CodeDefinerDefCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message CodeDefinerInsertTestDataCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CodeDefinerInsertTestDataCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message CodeDefinerMvcCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CodeDefinerMvcCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message CodeDefinerRdsCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CodeDefinerRdsCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message CommentDeleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.CommentDeleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message Copied(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Copied(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message Created(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Created(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message DefinitionNotFound(IContext context, params string[] data)
        {
            return Get(
                text: Displays.DefinitionNotFound(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message DeleteConflicts(IContext context, params string[] data)
        {
            return Get(
                text: Displays.DeleteConflicts(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message Deleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Deleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message DeletedImage(IContext context, params string[] data)
        {
            return Get(
                text: Displays.DeletedImage(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message Duplicated(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Duplicated(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message Expired(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Expired(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message ExternalMailAddress(IContext context, params string[] data)
        {
            return Get(
                text: Displays.ExternalMailAddress(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message FailedReadFile(IContext context, params string[] data)
        {
            return Get(
                text: Displays.FailedReadFile(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message FileDeleteCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.FileDeleteCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message FileDragDrop(IContext context, params string[] data)
        {
            return Get(
                text: Displays.FileDragDrop(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message FileNotFound(IContext context, params string[] data)
        {
            return Get(
                text: Displays.FileNotFound(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message FileUpdateCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.FileUpdateCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message HasBeenDeleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.HasBeenDeleted(
                    context: context,
                    data: data),
                css: "alert-info");
        }

        public static Message HasBeenMoved(IContext context, params string[] data)
        {
            return Get(
                text: Displays.HasBeenMoved(
                    context: context,
                    data: data),
                css: "alert-info");
        }

        public static Message HasNotPermission(IContext context, params string[] data)
        {
            return Get(
                text: Displays.HasNotPermission(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message HistoryDeleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.HistoryDeleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message Imported(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Imported(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message ImportMax(IContext context, params string[] data)
        {
            return Get(
                text: Displays.ImportMax(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message InCompression(IContext context, params string[] data)
        {
            return Get(
                text: Displays.InCompression(
                    context: context,
                    data: data),
                css: "alert-info");
        }

        public static Message InCopying(IContext context, params string[] data)
        {
            return Get(
                text: Displays.InCopying(
                    context: context,
                    data: data),
                css: "alert-info");
        }

        public static Message IncorrectCurrentPassword(IContext context, params string[] data)
        {
            return Get(
                text: Displays.IncorrectCurrentPassword(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message IncorrectFileFormat(IContext context, params string[] data)
        {
            return Get(
                text: Displays.IncorrectFileFormat(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message IncorrectSiteDeleting(IContext context, params string[] data)
        {
            return Get(
                text: Displays.IncorrectSiteDeleting(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message InputMailAddress(IContext context, params string[] data)
        {
            return Get(
                text: Displays.InputMailAddress(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message InternalServerError(IContext context, params string[] data)
        {
            return Get(
                text: Displays.InternalServerError(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message InvalidCsvData(IContext context, params string[] data)
        {
            return Get(
                text: Displays.InvalidCsvData(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message InvalidFormula(IContext context, params string[] data)
        {
            return Get(
                text: Displays.InvalidFormula(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message InvalidIpAddress(IContext context, params string[] data)
        {
            return Get(
                text: Displays.InvalidIpAddress(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message InvalidRequest(IContext context, params string[] data)
        {
            return Get(
                text: Displays.InvalidRequest(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message ItemsLimit(IContext context, params string[] data)
        {
            return Get(
                text: Displays.ItemsLimit(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message LinkCreated(IContext context, params string[] data)
        {
            return Get(
                text: Displays.LinkCreated(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message LoginIdAlreadyUse(IContext context, params string[] data)
        {
            return Get(
                text: Displays.LoginIdAlreadyUse(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message LoginIn(IContext context, params string[] data)
        {
            return Get(
                text: Displays.LoginIn(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message MailAddressHasNotSet(IContext context, params string[] data)
        {
            return Get(
                text: Displays.MailAddressHasNotSet(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message MailTransmissionCompletion(IContext context, params string[] data)
        {
            return Get(
                text: Displays.MailTransmissionCompletion(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message Moved(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Moved(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message NoLinks(IContext context, params string[] data)
        {
            return Get(
                text: Displays.NoLinks(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message NotFound(IContext context, params string[] data)
        {
            return Get(
                text: Displays.NotFound(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message NotRequiredColumn(IContext context, params string[] data)
        {
            return Get(
                text: Displays.NotRequiredColumn(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message OverLimitQuantity(IContext context, params string[] data)
        {
            return Get(
                text: Displays.OverLimitQuantity(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message OverLimitSize(IContext context, params string[] data)
        {
            return Get(
                text: Displays.OverLimitSize(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message OverTenantStorageSize(IContext context, params string[] data)
        {
            return Get(
                text: Displays.OverTenantStorageSize(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message OverTotalLimitSize(IContext context, params string[] data)
        {
            return Get(
                text: Displays.OverTotalLimitSize(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message ParameterSyntaxError(IContext context, params string[] data)
        {
            return Get(
                text: Displays.ParameterSyntaxError(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message PasswordNotChanged(IContext context, params string[] data)
        {
            return Get(
                text: Displays.PasswordNotChanged(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message PasswordPolicyViolation(IContext context, params string[] data)
        {
            return Get(
                text: Displays.PasswordPolicyViolation(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message PasswordResetCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.PasswordResetCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message PermissionNotSelfChange(IContext context, params string[] data)
        {
            return Get(
                text: Displays.PermissionNotSelfChange(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message PhysicalDeleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.PhysicalDeleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message ReadOnlyBecausePreviousVer(IContext context, params string[] data)
        {
            return Get(
                text: Displays.ReadOnlyBecausePreviousVer(
                    context: context,
                    data: data),
                css: "alert-info");
        }

        public static Message RebuildingCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.RebuildingCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message RequireMailAddresses(IContext context, params string[] data)
        {
            return Get(
                text: Displays.RequireMailAddresses(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message RequireTo(IContext context, params string[] data)
        {
            return Get(
                text: Displays.RequireTo(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message RestoredFromHistory(IContext context, params string[] data)
        {
            return Get(
                text: Displays.RestoredFromHistory(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message Restricted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Restricted(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message SelectFile(IContext context, params string[] data)
        {
            return Get(
                text: Displays.SelectFile(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message SelectOne(IContext context, params string[] data)
        {
            return Get(
                text: Displays.SelectOne(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message SelectTargets(IContext context, params string[] data)
        {
            return Get(
                text: Displays.SelectTargets(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message SentAcceptanceMail (IContext context, params string[] data)
        {
            return Get(
                text: Displays.SentAcceptanceMail (
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message Separated(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Separated(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message SitesCreated(IContext context, params string[] data)
        {
            return Get(
                text: Displays.SitesCreated(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message SitesLimit(IContext context, params string[] data)
        {
            return Get(
                text: Displays.SitesLimit(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message SynchronizationCompleted(IContext context, params string[] data)
        {
            return Get(
                text: Displays.SynchronizationCompleted(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message TooManyCases(IContext context, params string[] data)
        {
            return Get(
                text: Displays.TooManyCases(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message TooManyColumnCases(IContext context, params string[] data)
        {
            return Get(
                text: Displays.TooManyColumnCases(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message TooManyRowCases(IContext context, params string[] data)
        {
            return Get(
                text: Displays.TooManyRowCases(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message Unauthorized(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Unauthorized(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message UpdateConflicts(IContext context, params string[] data)
        {
            return Get(
                text: Displays.UpdateConflicts(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message Updated(IContext context, params string[] data)
        {
            return Get(
                text: Displays.Updated(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static Message UserDisabled(IContext context, params string[] data)
        {
            return Get(
                text: Displays.UserDisabled(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message UserLockout(IContext context, params string[] data)
        {
            return Get(
                text: Displays.UserLockout(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message UsersLimit(IContext context, params string[] data)
        {
            return Get(
                text: Displays.UsersLimit(
                    context: context,
                    data: data),
                css: "alert-error");
        }

        public static Message UserSwitched(IContext context, params string[] data)
        {
            return Get(
                text: Displays.UserSwitched(
                    context: context,
                    data: data),
                css: "alert-success");
        }

        public static ResponseCollection ResponseAlreadyAdded(IContext context, params string[] data)
        {
            return ResponseMessage(AlreadyAdded(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseAlreadyLinked(IContext context, params string[] data)
        {
            return ResponseMessage(AlreadyLinked(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseApiKeyCreated(IContext context, params string[] data)
        {
            return ResponseMessage(ApiKeyCreated(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseApiKeyDeleted(IContext context, params string[] data)
        {
            return ResponseMessage(ApiKeyDeleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseApplicationError(IContext context, params string[] data)
        {
            return ResponseMessage(ApplicationError(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseAuthentication(IContext context, params string[] data)
        {
            return ResponseMessage(Authentication(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseBadFormat(IContext context, params string[] data)
        {
            return ResponseMessage(BadFormat(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseBadMailAddress(IContext context, params string[] data)
        {
            return ResponseMessage(BadMailAddress(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseBadRequest(IContext context, params string[] data)
        {
            return ResponseMessage(BadRequest(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseBulkDeleted(IContext context, params string[] data)
        {
            return ResponseMessage(BulkDeleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseBulkMoved(IContext context, params string[] data)
        {
            return ResponseMessage(BulkMoved(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseBulkRestored(IContext context, params string[] data)
        {
            return ResponseMessage(BulkRestored(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCanNotChangeInheritance(IContext context, params string[] data)
        {
            return ResponseMessage(CanNotChangeInheritance(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCanNotDisabled(IContext context, params string[] data)
        {
            return ResponseMessage(CanNotDisabled(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCanNotInherit(IContext context, params string[] data)
        {
            return ResponseMessage(CanNotInherit(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCanNotLink(IContext context, params string[] data)
        {
            return ResponseMessage(CanNotLink(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCanNotPerformed(IContext context, params string[] data)
        {
            return ResponseMessage(CanNotPerformed(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCanNotUpdate(IContext context, params string[] data)
        {
            return ResponseMessage(CanNotUpdate(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCantSetAtTopOfSite(IContext context, params string[] data)
        {
            return ResponseMessage(CantSetAtTopOfSite(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseChangingPasswordComplete(IContext context, params string[] data)
        {
            return ResponseMessage(ChangingPasswordComplete(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCodeDefinerBackupCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(CodeDefinerBackupCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCodeDefinerCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(CodeDefinerCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCodeDefinerCssCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(CodeDefinerCssCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCodeDefinerDefCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(CodeDefinerDefCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCodeDefinerInsertTestDataCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(CodeDefinerInsertTestDataCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCodeDefinerMvcCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(CodeDefinerMvcCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCodeDefinerRdsCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(CodeDefinerRdsCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCommentDeleted(IContext context, params string[] data)
        {
            return ResponseMessage(CommentDeleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCopied(IContext context, params string[] data)
        {
            return ResponseMessage(Copied(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseCreated(IContext context, params string[] data)
        {
            return ResponseMessage(Created(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseDefinitionNotFound(IContext context, params string[] data)
        {
            return ResponseMessage(DefinitionNotFound(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseDeleteConflicts(IContext context, params string[] data)
        {
            return ResponseMessage(DeleteConflicts(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseDeleted(IContext context, params string[] data)
        {
            return ResponseMessage(Deleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseDeletedImage(IContext context, params string[] data)
        {
            return ResponseMessage(DeletedImage(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseDuplicated(IContext context, params string[] data)
        {
            return ResponseMessage(Duplicated(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseExpired(IContext context, params string[] data)
        {
            return ResponseMessage(Expired(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseExternalMailAddress(IContext context, params string[] data)
        {
            return ResponseMessage(ExternalMailAddress(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseFailedReadFile(IContext context, params string[] data)
        {
            return ResponseMessage(FailedReadFile(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseFileDeleteCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(FileDeleteCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseFileDragDrop(IContext context, params string[] data)
        {
            return ResponseMessage(FileDragDrop(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseFileNotFound(IContext context, params string[] data)
        {
            return ResponseMessage(FileNotFound(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseFileUpdateCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(FileUpdateCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseHasBeenDeleted(IContext context, params string[] data)
        {
            return ResponseMessage(HasBeenDeleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseHasBeenMoved(IContext context, params string[] data)
        {
            return ResponseMessage(HasBeenMoved(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseHasNotPermission(IContext context, params string[] data)
        {
            return ResponseMessage(HasNotPermission(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseHistoryDeleted(IContext context, params string[] data)
        {
            return ResponseMessage(HistoryDeleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseImported(IContext context, params string[] data)
        {
            return ResponseMessage(Imported(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseImportMax(IContext context, params string[] data)
        {
            return ResponseMessage(ImportMax(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseInCompression(IContext context, params string[] data)
        {
            return ResponseMessage(InCompression(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseInCopying(IContext context, params string[] data)
        {
            return ResponseMessage(InCopying(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseIncorrectCurrentPassword(IContext context, params string[] data)
        {
            return ResponseMessage(IncorrectCurrentPassword(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseIncorrectFileFormat(IContext context, params string[] data)
        {
            return ResponseMessage(IncorrectFileFormat(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseIncorrectSiteDeleting(IContext context, params string[] data)
        {
            return ResponseMessage(IncorrectSiteDeleting(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseInputMailAddress(IContext context, params string[] data)
        {
            return ResponseMessage(InputMailAddress(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseInternalServerError(IContext context, params string[] data)
        {
            return ResponseMessage(InternalServerError(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseInvalidCsvData(IContext context, params string[] data)
        {
            return ResponseMessage(InvalidCsvData(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseInvalidFormula(IContext context, params string[] data)
        {
            return ResponseMessage(InvalidFormula(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseInvalidIpAddress(IContext context, params string[] data)
        {
            return ResponseMessage(InvalidIpAddress(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseInvalidRequest(IContext context, params string[] data)
        {
            return ResponseMessage(InvalidRequest(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseItemsLimit(IContext context, params string[] data)
        {
            return ResponseMessage(ItemsLimit(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseLinkCreated(IContext context, params string[] data)
        {
            return ResponseMessage(LinkCreated(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseLoginIdAlreadyUse(IContext context, params string[] data)
        {
            return ResponseMessage(LoginIdAlreadyUse(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseLoginIn(IContext context, params string[] data)
        {
            return ResponseMessage(LoginIn(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseMailAddressHasNotSet(IContext context, params string[] data)
        {
            return ResponseMessage(MailAddressHasNotSet(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseMailTransmissionCompletion(IContext context, params string[] data)
        {
            return ResponseMessage(MailTransmissionCompletion(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseMoved(IContext context, params string[] data)
        {
            return ResponseMessage(Moved(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseNoLinks(IContext context, params string[] data)
        {
            return ResponseMessage(NoLinks(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseNotFound(IContext context, params string[] data)
        {
            return ResponseMessage(NotFound(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseNotRequiredColumn(IContext context, params string[] data)
        {
            return ResponseMessage(NotRequiredColumn(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseOverLimitQuantity(IContext context, params string[] data)
        {
            return ResponseMessage(OverLimitQuantity(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseOverLimitSize(IContext context, params string[] data)
        {
            return ResponseMessage(OverLimitSize(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseOverTenantStorageSize(IContext context, params string[] data)
        {
            return ResponseMessage(OverTenantStorageSize(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseOverTotalLimitSize(IContext context, params string[] data)
        {
            return ResponseMessage(OverTotalLimitSize(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseParameterSyntaxError(IContext context, params string[] data)
        {
            return ResponseMessage(ParameterSyntaxError(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponsePasswordNotChanged(IContext context, params string[] data)
        {
            return ResponseMessage(PasswordNotChanged(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponsePasswordPolicyViolation(IContext context, params string[] data)
        {
            return ResponseMessage(PasswordPolicyViolation(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponsePasswordResetCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(PasswordResetCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponsePermissionNotSelfChange(IContext context, params string[] data)
        {
            return ResponseMessage(PermissionNotSelfChange(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponsePhysicalDeleted(IContext context, params string[] data)
        {
            return ResponseMessage(PhysicalDeleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseReadOnlyBecausePreviousVer(IContext context, params string[] data)
        {
            return ResponseMessage(ReadOnlyBecausePreviousVer(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseRebuildingCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(RebuildingCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseRequireMailAddresses(IContext context, params string[] data)
        {
            return ResponseMessage(RequireMailAddresses(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseRequireTo(IContext context, params string[] data)
        {
            return ResponseMessage(RequireTo(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseRestoredFromHistory(IContext context, params string[] data)
        {
            return ResponseMessage(RestoredFromHistory(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseRestricted(IContext context, params string[] data)
        {
            return ResponseMessage(Restricted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseSelectFile(IContext context, params string[] data)
        {
            return ResponseMessage(SelectFile(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseSelectOne(IContext context, params string[] data)
        {
            return ResponseMessage(SelectOne(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseSelectTargets(IContext context, params string[] data)
        {
            return ResponseMessage(SelectTargets(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseSentAcceptanceMail (IContext context, params string[] data)
        {
            return ResponseMessage(SentAcceptanceMail (
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseSeparated(IContext context, params string[] data)
        {
            return ResponseMessage(Separated(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseSitesCreated(IContext context, params string[] data)
        {
            return ResponseMessage(SitesCreated(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseSitesLimit(IContext context, params string[] data)
        {
            return ResponseMessage(SitesLimit(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseSynchronizationCompleted(IContext context, params string[] data)
        {
            return ResponseMessage(SynchronizationCompleted(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseTooManyCases(IContext context, params string[] data)
        {
            return ResponseMessage(TooManyCases(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseTooManyColumnCases(IContext context, params string[] data)
        {
            return ResponseMessage(TooManyColumnCases(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseTooManyRowCases(IContext context, params string[] data)
        {
            return ResponseMessage(TooManyRowCases(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseUnauthorized(IContext context, params string[] data)
        {
            return ResponseMessage(Unauthorized(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseUpdateConflicts(IContext context, params string[] data)
        {
            return ResponseMessage(UpdateConflicts(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseUpdated(IContext context, params string[] data)
        {
            return ResponseMessage(Updated(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseUserDisabled(IContext context, params string[] data)
        {
            return ResponseMessage(UserDisabled(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseUserLockout(IContext context, params string[] data)
        {
            return ResponseMessage(UserLockout(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseUsersLimit(IContext context, params string[] data)
        {
            return ResponseMessage(UsersLimit(
                context: context,
                data: data));
        }

        public static ResponseCollection ResponseUserSwitched(IContext context, params string[] data)
        {
            return ResponseMessage(UserSwitched(
                context: context,
                data: data));
        }
    }
}
