using Implem.Libraries.Utilities;
using Implem.ParameterAccessor.Parts;
using Implem.Pleasanter.Libraries.Requests;
using System.Collections.Generic;
using System.Linq;
namespace Implem.Pleasanter.Libraries.Responses
{
    public static class Displays
    {
        public static Dictionary<string, string> DisplayHash = GetDisplayHash();

        private static Dictionary<string, string> GetDisplayHash()
        {
            var data = new Dictionary<string, string>();
            DisplayAccessor.Displays.DisplayHash.ForEach(display =>
                display.Value.Languages.ForEach(element =>
                    data.Add(
                        display.Key + (!element.Language.IsNullOrEmpty()
                            ? "_" + element.Language
                            : string.Empty),
                        element.Body)));
            return data;
        }

        public static string Get(IContext context, string id, params string[] data)
        {
            var screen = id;
            var kay = id + "_" + context.Language;
            if (DisplayHash.ContainsKey(kay))
            {
                screen = DisplayHash[kay];
            }
            else if (DisplayHash.ContainsKey(id))
            {
                screen = DisplayHash[id];
            }
            return data?.Any() == true
                ? screen.Params(data)
                : screen;
        }

        public static string Display(this PasswordPolicy policy, IContext context)
        {
            return policy.Languages.FirstOrDefault(o => o.Language == context.Language)?.Body
                ?? policy.Languages.FirstOrDefault(o => o.Language.IsNullOrEmpty())?.Body
                ?? policy.Languages.FirstOrDefault()?.Body;
        }

        public static string Add(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Add",
                data: data);
        }

        public static string AddPermission(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AddPermission",
                data: data);
        }

        public static string Address(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Address",
                data: data);
        }

        public static string AddressBook(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AddressBook",
                data: data);
        }

        public static string Admin(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Admin",
                data: data);
        }

        public static string AdvancedSetting(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AdvancedSetting",
                data: data);
        }

        public static string AfterCondition(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AfterCondition",
                data: data);
        }

        public static string AggregationDetails(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AggregationDetails",
                data: data);
        }

        public static string Aggregations(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Aggregations",
                data: data);
        }

        public static string AggregationSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AggregationSettings",
                data: data);
        }

        public static string AggregationTarget(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AggregationTarget",
                data: data);
        }

        public static string AggregationType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AggregationType",
                data: data);
        }

        public static string AggregationView(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AggregationView",
                data: data);
        }

        public static string All(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "All",
                data: data);
        }

        public static string AllowEditingComments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AllowEditingComments",
                data: data);
        }

        public static string AllowedUsers(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AllowedUsers",
                data: data);
        }

        public static string AllowImage(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AllowImage",
                data: data);
        }

        public static string AlreadyAdded(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AlreadyAdded",
                data: data);
        }

        public static string AlreadyLinked(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "AlreadyLinked",
                data: data);
        }

        public static string And(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "And",
                data: data);
        }

        public static string ApiKey(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ApiKey",
                data: data);
        }

        public static string ApiKeyCreated(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ApiKeyCreated",
                data: data);
        }

        public static string ApiKeyDeleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ApiKeyDeleted",
                data: data);
        }

        public static string ApiSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ApiSettings",
                data: data);
        }

        public static string ApplicationError(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ApplicationError",
                data: data);
        }

        public static string Assembly(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Assembly",
                data: data);
        }

        public static string Attachments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Attachments",
                data: data);
        }

        public static string Authentication(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Authentication",
                data: data);
        }

        public static string Auto(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Auto",
                data: data);
        }

        public static string Average(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Average",
                data: data);
        }

        public static string BadFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BadFormat",
                data: data);
        }

        public static string BadMailAddress(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BadMailAddress",
                data: data);
        }

        public static string BadRequest(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BadRequest",
                data: data);
        }

        public static string Basic(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Basic",
                data: data);
        }

        public static string BeforeCondition(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BeforeCondition",
                data: data);
        }

        public static string Blog(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Blog",
                data: data);
        }

        public static string Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Body",
                data: data);
        }

        public static string BroadMatchOfTitle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BroadMatchOfTitle",
                data: data);
        }

        public static string BulkDelete(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BulkDelete",
                data: data);
        }

        public static string BulkDeleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BulkDeleted",
                data: data);
        }

        public static string BulkMove(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BulkMove",
                data: data);
        }

        public static string BulkMoved(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BulkMoved",
                data: data);
        }

        public static string BulkRestored(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BulkRestored",
                data: data);
        }

        public static string BurnDown(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BurnDown",
                data: data);
        }

        public static string BusinessImprovement(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "BusinessImprovement",
                data: data);
        }

        public static string Calendar(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Calendar",
                data: data);
        }

        public static string Camera(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Camera",
                data: data);
        }

        public static string Cancel(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Cancel",
                data: data);
        }

        public static string CanNotChangeInheritance(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CanNotChangeInheritance",
                data: data);
        }

        public static string CanNotConnectCamera(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CanNotConnectCamera",
                data: data);
        }

        public static string CanNotDisabled(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CanNotDisabled",
                data: data);
        }

        public static string CanNotInherit(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CanNotInherit",
                data: data);
        }

        public static string CanNotLink(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CanNotLink",
                data: data);
        }

        public static string CanNotPerformed(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CanNotPerformed",
                data: data);
        }

        public static string CanNotUpdate(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CanNotUpdate",
                data: data);
        }

        public static string CantSetAtTopOfSite(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CantSetAtTopOfSite",
                data: data);
        }

        public static string Change(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Change",
                data: data);
        }

        public static string ChangeHistoryList(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ChangeHistoryList",
                data: data);
        }

        public static string ChangePassword(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ChangePassword",
                data: data);
        }

        public static string ChangingPasswordComplete(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ChangingPasswordComplete",
                data: data);
        }

        public static string CharacterCode(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CharacterCode",
                data: data);
        }

        public static string ChatWork(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ChatWork",
                data: data);
        }

        public static string Check(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Check",
                data: data);
        }

        public static string CheckAll(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CheckAll",
                data: data);
        }

        public static string Class(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Class",
                data: data);
        }

        public static string Classification(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Classification",
                data: data);
        }

        public static string CodeDefinerBackupCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CodeDefinerBackupCompleted",
                data: data);
        }

        public static string CodeDefinerCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CodeDefinerCompleted",
                data: data);
        }

        public static string CodeDefinerCssCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CodeDefinerCssCompleted",
                data: data);
        }

        public static string CodeDefinerDefCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CodeDefinerDefCompleted",
                data: data);
        }

        public static string CodeDefinerInsertTestDataCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CodeDefinerInsertTestDataCompleted",
                data: data);
        }

        public static string CodeDefinerMvcCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CodeDefinerMvcCompleted",
                data: data);
        }

        public static string CodeDefinerRdsCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CodeDefinerRdsCompleted",
                data: data);
        }

        public static string Column(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Column",
                data: data);
        }

        public static string ColumnAccessControl(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ColumnAccessControl",
                data: data);
        }

        public static string ColumnList(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ColumnList",
                data: data);
        }

        public static string CommentDeleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CommentDeleted",
                data: data);
        }

        public static string Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Comments",
                data: data);
        }

        public static string CommentUpdated(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CommentUpdated",
                data: data);
        }

        public static string Condition(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Condition",
                data: data);
        }

        public static string ConfirmCreateLink(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmCreateLink",
                data: data);
        }

        public static string ConfirmDelete(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmDelete",
                data: data);
        }

        public static string ConfirmDeleteSite(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmDeleteSite",
                data: data);
        }

        public static string ConfirmPhysicalDelete(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmPhysicalDelete",
                data: data);
        }

        public static string ConfirmRebuildSearchIndex(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmRebuildSearchIndex",
                data: data);
        }

        public static string ConfirmReload(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmReload",
                data: data);
        }

        public static string ConfirmReset(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmReset",
                data: data);
        }

        public static string ConfirmRestore(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmRestore",
                data: data);
        }

        public static string ConfirmSendMail(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmSendMail",
                data: data);
        }

        public static string ConfirmSeparate(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmSeparate",
                data: data);
        }

        public static string ConfirmSwitchUser(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmSwitchUser",
                data: data);
        }

        public static string ConfirmSynchronize(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ConfirmSynchronize",
                data: data);
        }

        public static string Contact(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Contact",
                data: data);
        }

        public static string ControlType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ControlType",
                data: data);
        }

        public static string Copied(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Copied",
                data: data);
        }

        public static string Copy(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Copy",
                data: data);
        }

        public static string CopyByDefault(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CopyByDefault",
                data: data);
        }

        public static string CopySettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CopySettings",
                data: data);
        }

        public static string CopyWithComments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CopyWithComments",
                data: data);
        }

        public static string CorporatePlanning(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CorporatePlanning",
                data: data);
        }

        public static string Count(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Count",
                data: data);
        }

        public static string Create(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Create",
                data: data);
        }

        public static string CreateColumnAccessControl(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CreateColumnAccessControl",
                data: data);
        }

        public static string Created(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Created",
                data: data);
        }

        public static string CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CreatedTime",
                data: data);
        }

        public static string Crosstab(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Crosstab",
                data: data);
        }

        public static string Csv(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Csv",
                data: data);
        }

        public static string CsvFile(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CsvFile",
                data: data);
        }

        public static string Currency(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Currency",
                data: data);
        }

        public static string CurrentMembers(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CurrentMembers",
                data: data);
        }

        public static string CurrentPassword(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CurrentPassword",
                data: data);
        }

        public static string CurrentSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CurrentSettings",
                data: data);
        }

        public static string Custom(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Custom",
                data: data);
        }

        public static string CustomDesign(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "CustomDesign",
                data: data);
        }

        public static string Customer(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Customer",
                data: data);
        }

        public static string Daily(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Daily",
                data: data);
        }

        public static string DatabaseSize(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DatabaseSize",
                data: data);
        }

        public static string DataStorageDestination(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DataStorageDestination",
                data: data);
        }

        public static string DataView(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DataView",
                data: data);
        }

        public static string Date(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Date",
                data: data);
        }

        public static string Day(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Day",
                data: data);
        }

        public static string DayAgo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DayAgo",
                data: data);
        }

        public static string DayOfWeek(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DayOfWeek",
                data: data);
        }

        public static string DaysAgo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DaysAgo",
                data: data);
        }

        public static string DecimalPlaces(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DecimalPlaces",
                data: data);
        }

        public static string Default(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Default",
                data: data);
        }

        public static string DefaultAddressBook(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DefaultAddressBook",
                data: data);
        }

        public static string DefaultDestinations(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DefaultDestinations",
                data: data);
        }

        public static string DefaultInput(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DefaultInput",
                data: data);
        }

        public static string DefaultView(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DefaultView",
                data: data);
        }

        public static string DefinitionNotFound(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DefinitionNotFound",
                data: data);
        }

        public static string Delay(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Delay",
                data: data);
        }

        public static string Delete(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Delete",
                data: data);
        }

        public static string DeleteConflicts(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DeleteConflicts",
                data: data);
        }

        public static string Deleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Deleted",
                data: data);
        }

        public static string DeletedImage(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DeletedImage",
                data: data);
        }

        public static string DeletedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DeletedTime",
                data: data);
        }

        public static string DeleteFromTrashBox(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DeleteFromTrashBox",
                data: data);
        }

        public static string DeleteHistory(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DeleteHistory",
                data: data);
        }

        public static string DeletePermission(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DeletePermission",
                data: data);
        }

        public static string Deleter(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Deleter",
                data: data);
        }

        public static string DeleteSite(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DeleteSite",
                data: data);
        }

        public static string DemoMailBody(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DemoMailBody",
                data: data);
        }

        public static string DemoMailTitle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DemoMailTitle",
                data: data);
        }

        public static string DeptAdmin(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DeptAdmin",
                data: data);
        }

        public static string Description(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Description",
                data: data);
        }

        public static string Destination(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Destination",
                data: data);
        }

        public static string Difference(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Difference",
                data: data);
        }

        public static string DirectUrlCopied(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DirectUrlCopied",
                data: data);
        }

        public static string Disabled(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Disabled",
                data: data);
        }

        public static string SendCompletedInPast(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SendCompletedInPast",
                data: data);
        }

        public static string DisplayName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "DisplayName",
                data: data);
        }

        public static string Duplicated(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Duplicated",
                data: data);
        }

        public static string EarnedValue(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "EarnedValue",
                data: data);
        }

        public static string Edit(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Edit",
                data: data);
        }

        public static string EditInDialog(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "EditInDialog",
                data: data);
        }

        public static string Editor(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Editor",
                data: data);
        }

        public static string EditorFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "EditorFormat",
                data: data);
        }

        public static string EditorSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "EditorSettings",
                data: data);
        }

        public static string EditProfile(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "EditProfile",
                data: data);
        }

        public static string EditScript(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "EditScript",
                data: data);
        }

        public static string EditSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "EditSettings",
                data: data);
        }

        public static string EditStyle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "EditStyle",
                data: data);
        }

        public static string Education(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Education",
                data: data);
        }

        public static string Enabled(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Enabled",
                data: data);
        }

        public static string EndOfMonth(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "EndOfMonth",
                data: data);
        }

        public static string EnterTitle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "EnterTitle",
                data: data);
        }

        public static string Error(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Error",
                data: data);
        }

        public static string Excel(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Excel",
                data: data);
        }

        public static string Expired(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Expired",
                data: data);
        }

        public static string Export(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Export",
                data: data);
        }

        public static string ExportColumns(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportColumns",
                data: data);
        }

        public static string ExportFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportFormat",
                data: data);
        }

        public static string Expression(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Expression",
                data: data);
        }

        public static string ExternalMailAddress(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExternalMailAddress",
                data: data);
        }

        public static string FailedReadFile(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "FailedReadFile",
                data: data);
        }

        public static string File(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "File",
                data: data);
        }

        public static string FileDeleteCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "FileDeleteCompleted",
                data: data);
        }

        public static string FileDragDrop(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "FileDragDrop",
                data: data);
        }

        public static string FileNotFound(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "FileNotFound",
                data: data);
        }

        public static string FileUpdateCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "FileUpdateCompleted",
                data: data);
        }

        public static string Filters(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Filters",
                data: data);
        }

        public static string FilterSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "FilterSettings",
                data: data);
        }

        public static string FirstDay(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "FirstDay",
                data: data);
        }

        public static string Folder(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Folder",
                data: data);
        }

        public static string Format(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Format",
                data: data);
        }

        public static string Formulas(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Formulas",
                data: data);
        }

        public static string Friday(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Friday",
                data: data);
        }

        public static string From(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "From",
                data: data);
        }

        public static string FullText(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "FullText",
                data: data);
        }

        public static string Fy(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Fy",
                data: data);
        }

        public static string Gantt(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Gantt",
                data: data);
        }

        public static string General(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "General",
                data: data);
        }

        public static string GeneralUser(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GeneralUser",
                data: data);
        }

        public static string GoBack(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GoBack",
                data: data);
        }

        public static string Grid(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Grid",
                data: data);
        }

        public static string GridFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GridFormat",
                data: data);
        }

        public static string GridScript(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GridScript",
                data: data);
        }

        public static string GridStyle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GridStyle",
                data: data);
        }

        public static string GroupAdmin(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupAdmin",
                data: data);
        }

        public static string GroupBy(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupBy",
                data: data);
        }

        public static string GroupByX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupByX",
                data: data);
        }

        public static string GroupByY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupByY",
                data: data);
        }

        public static string Half1(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Half1",
                data: data);
        }

        public static string Half2(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Half2",
                data: data);
        }

        public static string HasBeenDeleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "HasBeenDeleted",
                data: data);
        }

        public static string HasBeenMoved(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "HasBeenMoved",
                data: data);
        }

        public static string HasNotPermission(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "HasNotPermission",
                data: data);
        }

        public static string Hidden(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Hidden",
                data: data);
        }

        public static string Hide(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Hide",
                data: data);
        }

        public static string HideList(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "HideList",
                data: data);
        }

        public static string Histories(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Histories",
                data: data);
        }

        public static string HistoryDeleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "HistoryDeleted",
                data: data);
        }

        public static string HourAgo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "HourAgo",
                data: data);
        }

        public static string HoursAgo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "HoursAgo",
                data: data);
        }

        public static string HumanResourcesAndGeneralAffairs(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "HumanResourcesAndGeneralAffairs",
                data: data);
        }

        public static string Hyphen(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Hyphen",
                data: data);
        }

        public static string Icon(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Icon",
                data: data);
        }

        public static string Id(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Id",
                data: data);
        }

        public static string ImageAndText(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ImageAndText",
                data: data);
        }

        public static string ImageLib(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ImageLib",
                data: data);
        }

        public static string ImageOnly(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ImageOnly",
                data: data);
        }

        public static string Import(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Import",
                data: data);
        }

        public static string Imported(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Imported",
                data: data);
        }

        public static string ImportMax(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ImportMax",
                data: data);
        }

        public static string Incomplete(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Incomplete",
                data: data);
        }

        public static string InCompression(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "InCompression",
                data: data);
        }

        public static string InCopying(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "InCopying",
                data: data);
        }

        public static string IncorrectCurrentPassword(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "IncorrectCurrentPassword",
                data: data);
        }

        public static string IncorrectFileFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "IncorrectFileFormat",
                data: data);
        }

        public static string IncorrectSiteDeleting(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "IncorrectSiteDeleting",
                data: data);
        }

        public static string Index(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Index",
                data: data);
        }

        public static string InformationSystem(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "InformationSystem",
                data: data);
        }

        public static string InheritPermission(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "InheritPermission",
                data: data);
        }

        public static string InputMailAddress(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "InputMailAddress",
                data: data);
        }

        public static string InternalServerError(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "InternalServerError",
                data: data);
        }

        public static string InvalidCsvData(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "InvalidCsvData",
                data: data);
        }

        public static string InvalidFormula(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "InvalidFormula",
                data: data);
        }

        public static string InvalidIpAddress(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "InvalidIpAddress",
                data: data);
        }

        public static string InvalidRequest(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "InvalidRequest",
                data: data);
        }

        public static string ItemsLimit(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ItemsLimit",
                data: data);
        }

        public static string Kamban(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Kamban",
                data: data);
        }

        public static string Latest(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Latest",
                data: data);
        }

        public static string Leader(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Leader",
                data: data);
        }

        public static string LegalAffairs(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LegalAffairs",
                data: data);
        }

        public static string LessThan(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LessThan",
                data: data);
        }

        public static string LimitAfterDay(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterDay",
                data: data);
        }

        public static string LimitAfterDays(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterDays",
                data: data);
        }

        public static string LimitAfterHour(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterHour",
                data: data);
        }

        public static string LimitAfterHours(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterHours",
                data: data);
        }

        public static string LimitAfterMinute(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterMinute",
                data: data);
        }

        public static string LimitAfterMinutes(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterMinutes",
                data: data);
        }

        public static string LimitAfterMonth(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterMonth",
                data: data);
        }

        public static string LimitAfterMonths(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterMonths",
                data: data);
        }

        public static string LimitAfterSecond(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterSecond",
                data: data);
        }

        public static string LimitAfterSeconds(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterSeconds",
                data: data);
        }

        public static string LimitAfterYear(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterYear",
                data: data);
        }

        public static string LimitAfterYears(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitAfterYears",
                data: data);
        }

        public static string LimitBeforeDay(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeDay",
                data: data);
        }

        public static string LimitBeforeDays(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeDays",
                data: data);
        }

        public static string LimitBeforeHour(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeHour",
                data: data);
        }

        public static string LimitBeforeHours(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeHours",
                data: data);
        }

        public static string LimitBeforeMinute(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeMinute",
                data: data);
        }

        public static string LimitBeforeMinutes(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeMinutes",
                data: data);
        }

        public static string LimitBeforeMonth(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeMonth",
                data: data);
        }

        public static string LimitBeforeMonths(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeMonths",
                data: data);
        }

        public static string LimitBeforeSecond(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeSecond",
                data: data);
        }

        public static string LimitBeforeSeconds(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeSeconds",
                data: data);
        }

        public static string LimitBeforeYear(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeYear",
                data: data);
        }

        public static string LimitBeforeYears(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitBeforeYears",
                data: data);
        }

        public static string LimitJust(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitJust",
                data: data);
        }

        public static string LimitQuantity(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitQuantity",
                data: data);
        }

        public static string LimitSize(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitSize",
                data: data);
        }

        public static string LimitTotalSize(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LimitTotalSize",
                data: data);
        }

        public static string Line(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Line",
                data: data);
        }

        public static string LineGroup(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LineGroup",
                data: data);
        }

        public static string LinkColumn(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LinkColumn",
                data: data);
        }

        public static string LinkCreated(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LinkCreated",
                data: data);
        }

        public static string LinkCreations(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LinkCreations",
                data: data);
        }

        public static string LinkDestinations(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LinkDestinations",
                data: data);
        }

        public static string Links(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links",
                data: data);
        }

        public static string LinkSources(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LinkSources",
                data: data);
        }

        public static string List(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "List",
                data: data);
        }

        public static string ListSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ListSettings",
                data: data);
        }

        public static string Login(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Login",
                data: data);
        }

        public static string LoginIdAlreadyUse(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginIdAlreadyUse",
                data: data);
        }

        public static string LoginIn(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginIn",
                data: data);
        }

        public static string Logistics(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Logistics",
                data: data);
        }

        public static string LogoImage(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LogoImage",
                data: data);
        }

        public static string Logout(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Logout",
                data: data);
        }

        public static string Mail(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Mail",
                data: data);
        }

        public static string MailAddress(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddress",
                data: data);
        }

        public static string MailAddressHasNotSet(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddressHasNotSet",
                data: data);
        }

        public static string MailTransmissionCompletion(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailTransmissionCompletion",
                data: data);
        }

        public static string Manage(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Manage",
                data: data);
        }

        public static string ManageFolder(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ManageFolder",
                data: data);
        }

        public static string ManagePermission(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ManagePermission",
                data: data);
        }

        public static string ManagePermissions(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ManagePermissions",
                data: data);
        }

        public static string Manager(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Manager",
                data: data);
        }

        public static string ManageSite(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ManageSite",
                data: data);
        }

        public static string ManageWiki(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ManageWiki",
                data: data);
        }

        public static string Manufacture(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Manufacture",
                data: data);
        }

        public static string MarkDown(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MarkDown",
                data: data);
        }

        public static string Marketing(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Marketing",
                data: data);
        }

        public static string MatchInFrontOfTitle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MatchInFrontOfTitle",
                data: data);
        }

        public static string Max(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Max",
                data: data);
        }

        public static string MaxColumns(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MaxColumns",
                data: data);
        }

        public static string Md(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Md",
                data: data);
        }

        public static string MdFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MdFormat",
                data: data);
        }

        public static string Members(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Members",
                data: data);
        }

        public static string Menu(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Menu",
                data: data);
        }

        public static string Min(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Min",
                data: data);
        }

        public static string MinuteAgo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MinuteAgo",
                data: data);
        }

        public static string MinutesAgo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MinutesAgo",
                data: data);
        }

        public static string Monday(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Monday",
                data: data);
        }

        public static string MonitorChangesColumns(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MonitorChangesColumns",
                data: data);
        }

        public static string Month(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Month",
                data: data);
        }

        public static string MonthAgo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MonthAgo",
                data: data);
        }

        public static string Monthly(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Monthly",
                data: data);
        }

        public static string MonthsAgo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MonthsAgo",
                data: data);
        }

        public static string Move(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Move",
                data: data);
        }

        public static string Moved(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Moved",
                data: data);
        }

        public static string MoveDown(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MoveDown",
                data: data);
        }

        public static string MoveSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MoveSettings",
                data: data);
        }

        public static string MoveUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MoveUp",
                data: data);
        }

        public static string Name(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Name",
                data: data);
        }

        public static string NearCompletionTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NearCompletionTime",
                data: data);
        }

        public static string NearCompletionTimeAfterDays(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NearCompletionTimeAfterDays",
                data: data);
        }

        public static string NearCompletionTimeBeforeDays(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NearCompletionTimeBeforeDays",
                data: data);
        }

        public static string New(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "New",
                data: data);
        }

        public static string Newer(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Newer",
                data: data);
        }

        public static string NewScript(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NewScript",
                data: data);
        }

        public static string NewStyle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NewStyle",
                data: data);
        }

        public static string Next(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Next",
                data: data);
        }

        public static string NoClassification(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NoClassification",
                data: data);
        }

        public static string NoData(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NoData",
                data: data);
        }

        public static string NoDuplication(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NoDuplication",
                data: data);
        }

        public static string NoLinks(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NoLinks",
                data: data);
        }

        public static string Normal(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Normal",
                data: data);
        }

        public static string NoTargetRecord(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NoTargetRecord",
                data: data);
        }

        public static string NotFound(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NotFound",
                data: data);
        }

        public static string Notifications(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Notifications",
                data: data);
        }

        public static string NotificationType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NotificationType",
                data: data);
        }

        public static string NotInheritPermission(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NotInheritPermission",
                data: data);
        }

        public static string NoTitle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NoTitle",
                data: data);
        }

        public static string NotOutput(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NotOutput",
                data: data);
        }

        public static string NotRequiredColumn(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NotRequiredColumn",
                data: data);
        }

        public static string NotSendIfNotApplicable(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NotSendIfNotApplicable",
                data: data);
        }

        public static string NotSet(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NotSet",
                data: data);
        }

        public static string NoWrap(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NoWrap",
                data: data);
        }

        public static string Num(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Num",
                data: data);
        }

        public static string NumberPerPage(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NumberPerPage",
                data: data);
        }

        public static string NumberWeekly(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NumberWeekly",
                data: data);
        }

        public static string NumericColumn(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "NumericColumn",
                data: data);
        }

        public static string Off(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Off",
                data: data);
        }

        public static string Older(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Older",
                data: data);
        }

        public static string On(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "On",
                data: data);
        }

        public static string OnAndOff(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OnAndOff",
                data: data);
        }

        public static string OnOnly(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OnOnly",
                data: data);
        }

        public static string Operations(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Operations",
                data: data);
        }

        public static string OptionList(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OptionList",
                data: data);
        }

        public static string Or(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Or",
                data: data);
        }

        public static string OrderAsc(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OrderAsc",
                data: data);
        }

        public static string OrderDesc(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OrderDesc",
                data: data);
        }

        public static string OrderRelease(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OrderRelease",
                data: data);
        }

        public static string OriginalMessage(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OriginalMessage",
                data: data);
        }

        public static string Others(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Others",
                data: data);
        }

        public static string OutgoingMail(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMail",
                data: data);
        }

        public static string OutOfCondition(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutOfCondition",
                data: data);
        }

        public static string Output(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Output",
                data: data);
        }

        public static string OutputDestination(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutputDestination",
                data: data);
        }

        public static string OutputHeader(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutputHeader",
                data: data);
        }

        public static string Over(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Over",
                data: data);
        }

        public static string Overdue(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Overdue",
                data: data);
        }

        public static string OverLimitQuantity(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OverLimitQuantity",
                data: data);
        }

        public static string OverLimitSize(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OverLimitSize",
                data: data);
        }

        public static string OverTenantStorageSize(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OverTenantStorageSize",
                data: data);
        }

        public static string OverTotalLimitSize(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OverTotalLimitSize",
                data: data);
        }

        public static string Own(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Own",
                data: data);
        }

        public static string ParameterSyntaxError(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ParameterSyntaxError",
                data: data);
        }

        public static string PartialMatch(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PartialMatch",
                data: data);
        }

        public static string Password(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Password",
                data: data);
        }

        public static string PasswordNotChanged(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PasswordNotChanged",
                data: data);
        }

        public static string PasswordPolicyViolation(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PasswordPolicyViolation",
                data: data);
        }

        public static string PasswordResetCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PasswordResetCompleted",
                data: data);
        }

        public static string Pattern(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Pattern",
                data: data);
        }

        public static string Period(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Period",
                data: data);
        }

        public static string PeriodType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PeriodType",
                data: data);
        }

        public static string PermissionDestination(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PermissionDestination",
                data: data);
        }

        public static string PermissionForCreating(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PermissionForCreating",
                data: data);
        }

        public static string PermissionNotSelfChange(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PermissionNotSelfChange",
                data: data);
        }

        public static string PermissionSetting(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PermissionSetting",
                data: data);
        }

        public static string PermissionSource(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PermissionSource",
                data: data);
        }

        public static string PhysicalDeleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PhysicalDeleted",
                data: data);
        }

        public static string Plan(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Plan",
                data: data);
        }

        public static string PlannedValue(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PlannedValue",
                data: data);
        }

        public static string Portal(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Portal",
                data: data);
        }

        public static string Prefix(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Prefix",
                data: data);
        }

        public static string Previous(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Previous",
                data: data);
        }

        public static string ProductList(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ProductList",
                data: data);
        }

        public static string ProductName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ProductName",
                data: data);
        }

        public static string Project(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Project",
                data: data);
        }

        public static string Publish(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Publish",
                data: data);
        }

        public static string PublishToAnonymousUsers(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PublishToAnonymousUsers",
                data: data);
        }

        public static string PublishWarning(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "PublishWarning",
                data: data);
        }

        public static string Purchase(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Purchase",
                data: data);
        }

        public static string Quantity(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Quantity",
                data: data);
        }

        public static string Quarter(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Quarter",
                data: data);
        }

        public static string Range(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Range",
                data: data);
        }

        public static string Read(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Read",
                data: data);
        }

        public static string ReadColumnAccessControl(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReadColumnAccessControl",
                data: data);
        }

        public static string ReadOnly(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReadOnly",
                data: data);
        }

        public static string ReadOnlyBecausePreviousVer(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReadOnlyBecausePreviousVer",
                data: data);
        }

        public static string ReadWrite(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReadWrite",
                data: data);
        }

        public static string RebuildingCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "RebuildingCompleted",
                data: data);
        }

        public static string RebuildSearchIndexes(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "RebuildSearchIndexes",
                data: data);
        }

        public static string RecordAccessControl(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "RecordAccessControl",
                data: data);
        }

        public static string ReCreate(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReCreate",
                data: data);
        }

        public static string Register(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Register",
                data: data);
        }

        public static string RelatingColumn(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "RelatingColumn",
                data: data);
        }

        public static string RelatingColumnSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "RelatingColumnSettings",
                data: data);
        }

        public static string Reload(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Reload",
                data: data);
        }

        public static string Reminders(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Reminders",
                data: data);
        }

        public static string Reply(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Reply",
                data: data);
        }

        public static string Required(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Required",
                data: data);
        }

        public static string RequiredPermission(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "RequiredPermission",
                data: data);
        }

        public static string RequireMailAddresses(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "RequireMailAddresses",
                data: data);
        }

        public static string RequireTo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "RequireTo",
                data: data);
        }

        public static string ResearchAndDevelopment(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ResearchAndDevelopment",
                data: data);
        }

        public static string Reset(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Reset",
                data: data);
        }

        public static string ResetOrder(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ResetOrder",
                data: data);
        }

        public static string ResetPassword(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ResetPassword",
                data: data);
        }

        public static string Restore(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Restore",
                data: data);
        }

        public static string RestoredFromHistory(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "RestoredFromHistory",
                data: data);
        }

        public static string Restricted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Restricted",
                data: data);
        }

        public static string Row(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Row",
                data: data);
        }

        public static string Sales(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sales",
                data: data);
        }

        public static string SamplesDisplayed(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SamplesDisplayed",
                data: data);
        }

        public static string Saturday(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Saturday",
                data: data);
        }

        public static string Save(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Save",
                data: data);
        }

        public static string Script(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Script",
                data: data);
        }

        public static string Scripts(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Scripts",
                data: data);
        }

        public static string Search(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Search",
                data: data);
        }

        public static string SearchSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchSettings",
                data: data);
        }

        public static string SearchTypes(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchTypes",
                data: data);
        }

        public static string SecondsAgo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SecondsAgo",
                data: data);
        }

        public static string Section(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Section",
                data: data);
        }

        public static string Select(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Select",
                data: data);
        }

        public static string SelectableMembers(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SelectableMembers",
                data: data);
        }

        public static string SelectFile(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SelectFile",
                data: data);
        }

        public static string SelectOne(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SelectOne",
                data: data);
        }

        public static string SelectTargets(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SelectTargets",
                data: data);
        }

        public static string SelectTemplate(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SelectTemplate",
                data: data);
        }

        public static string Send(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Send",
                data: data);
        }

        public static string SendMail(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SendMail",
                data: data);
        }

        public static string SentAcceptanceMail (
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SentAcceptanceMail ",
                data: data);
        }

        public static string SentMail(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SentMail",
                data: data);
        }

        public static string Separate(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Separate",
                data: data);
        }

        public static string Separated(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Separated",
                data: data);
        }

        public static string SeparateNumber(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SeparateNumber",
                data: data);
        }

        public static string SeparateSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SeparateSettings",
                data: data);
        }

        public static string Setting(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Setting",
                data: data);
        }

        public static string SetZeroWhenOutOfCondition(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SetZeroWhenOutOfCondition",
                data: data);
        }

        public static string ShortDisplayName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ShortDisplayName",
                data: data);
        }

        public static string ShowProgressRate(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ShowProgressRate",
                data: data);
        }

        public static string SiteAccessControl(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SiteAccessControl",
                data: data);
        }

        public static string SiteId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SiteId",
                data: data);
        }

        public static string SiteImageSettingsEditor(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SiteImageSettingsEditor",
                data: data);
        }

        public static string SiteIntegration(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SiteIntegration",
                data: data);
        }

        public static string SiteName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SiteName",
                data: data);
        }

        public static string SitesCreated(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SitesCreated",
                data: data);
        }

        public static string SiteSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SiteSettings",
                data: data);
        }

        public static string SitesLimit(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SitesLimit",
                data: data);
        }

        public static string SiteTitle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SiteTitle",
                data: data);
        }

        public static string SiteUser(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SiteUser",
                data: data);
        }

        public static string Slack(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Slack",
                data: data);
        }

        public static string SortBy(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SortBy",
                data: data);
        }

        public static string Sorters(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sorters",
                data: data);
        }

        public static string Special(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Special",
                data: data);
        }

        public static string Spinner(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Spinner",
                data: data);
        }

        public static string Standard(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Standard",
                data: data);
        }

        public static string StartDate(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "StartDate",
                data: data);
        }

        public static string StartDateTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "StartDateTime",
                data: data);
        }

        public static string Step(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Step",
                data: data);
        }

        public static string Store(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Store",
                data: data);
        }

        public static string Style(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Style",
                data: data);
        }

        public static string Styles(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Styles",
                data: data);
        }

        public static string Subject(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Subject",
                data: data);
        }

        public static string SuffixCopy(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SuffixCopy",
                data: data);
        }

        public static string Summaries(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Summaries",
                data: data);
        }

        public static string SummaryLinkColumn(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SummaryLinkColumn",
                data: data);
        }

        public static string SummarySourceColumn(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SummarySourceColumn",
                data: data);
        }

        public static string SummaryType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SummaryType",
                data: data);
        }

        public static string Sunday(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sunday",
                data: data);
        }

        public static string Support(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Support",
                data: data);
        }

        public static string SwitchRecordWithAjax(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SwitchRecordWithAjax",
                data: data);
        }

        public static string SwitchUser(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SwitchUser",
                data: data);
        }

        public static string SwitchUserInfo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SwitchUserInfo",
                data: data);
        }

        public static string SynchronizationCompleted(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SynchronizationCompleted",
                data: data);
        }

        public static string Synchronize(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Synchronize",
                data: data);
        }

        public static string Tables(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tables",
                data: data);
        }

        public static string ManageTable(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ManageTable",
                data: data);
        }

        public static string Target(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Target",
                data: data);
        }

        public static string Teams(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Teams",
                data: data);
        }

        public static string Template(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Template",
                data: data);
        }

        public static string TenantAdmin(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "TenantAdmin",
                data: data);
        }

        public static string TenantImageType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "TenantImageType",
                data: data);
        }

        public static string Test(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Test",
                data: data);
        }

        public static string ThisMonth(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ThisMonth",
                data: data);
        }

        public static string Thursday(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Thursday",
                data: data);
        }

        public static string TimeSeries(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "TimeSeries",
                data: data);
        }

        public static string Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Title",
                data: data);
        }

        public static string TitleSeparator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "TitleSeparator",
                data: data);
        }

        public static string To(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "To",
                data: data);
        }

        public static string Today(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Today",
                data: data);
        }

        public static string ToDisable(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ToDisable",
                data: data);
        }

        public static string ToEnable(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ToEnable",
                data: data);
        }

        public static string Token(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Token",
                data: data);
        }

        public static string TooManyCases(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "TooManyCases",
                data: data);
        }

        public static string TooManyColumnCases(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "TooManyColumnCases",
                data: data);
        }

        public static string TooManyRowCases(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "TooManyRowCases",
                data: data);
        }

        public static string Top(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Top",
                data: data);
        }

        public static string ToParent(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ToParent",
                data: data);
        }

        public static string ToShoot(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ToShoot",
                data: data);
        }

        public static string Total(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Total",
                data: data);
        }

        public static string TrashBox(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "TrashBox",
                data: data);
        }

        public static string Tuesday(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tuesday",
                data: data);
        }

        public static string Unauthorized(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Unauthorized",
                data: data);
        }

        public static string UncheckAll(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UncheckAll",
                data: data);
        }

        public static string Unit(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Unit",
                data: data);
        }

        public static string UpdatableImport(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UpdatableImport",
                data: data);
        }

        public static string Update(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Update",
                data: data);
        }

        public static string UpdateColumnAccessControl(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UpdateColumnAccessControl",
                data: data);
        }

        public static string UpdateConflicts(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UpdateConflicts",
                data: data);
        }

        public static string Updated(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Updated",
                data: data);
        }

        public static string UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UpdatedTime",
                data: data);
        }

        public static string Upload(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Upload",
                data: data);
        }

        public static string UsageGuide(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UsageGuide",
                data: data);
        }

        public static string UseCustomDesign(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UseCustomDesign",
                data: data);
        }

        public static string UseFy(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UseFy",
                data: data);
        }

        public static string UseHalf(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UseHalf",
                data: data);
        }

        public static string UseMonth(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UseMonth",
                data: data);
        }

        public static string UseQuarter(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UseQuarter",
                data: data);
        }

        public static string UserAdmin(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UserAdmin",
                data: data);
        }

        public static string UserDisabled(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UserDisabled",
                data: data);
        }

        public static string UserLockout(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UserLockout",
                data: data);
        }

        public static string UsersLimit(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UsersLimit",
                data: data);
        }

        public static string UserSwitched(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UserSwitched",
                data: data);
        }

        public static string UseSearch(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "UseSearch",
                data: data);
        }

        public static string ValidateDate(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ValidateDate",
                data: data);
        }

        public static string ValidateEmail(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ValidateEmail",
                data: data);
        }

        public static string ValidateEqualTo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ValidateEqualTo",
                data: data);
        }

        public static string ValidateMaxLength(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ValidateMaxLength",
                data: data);
        }

        public static string ValidateMaxNumber(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ValidateMaxNumber",
                data: data);
        }

        public static string ValidateMinNumber(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ValidateMinNumber",
                data: data);
        }

        public static string ValidateNumber(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ValidateNumber",
                data: data);
        }

        public static string ValidateRequired(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ValidateRequired",
                data: data);
        }

        public static string ValidationError(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ValidationError",
                data: data);
        }

        public static string Value(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Value",
                data: data);
        }

        public static string Version(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Version",
                data: data);
        }

        public static string VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "VerUp",
                data: data);
        }

        public static string View(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "View",
                data: data);
        }

        public static string ViewDemoEnvironment(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ViewDemoEnvironment",
                data: data);
        }

        public static string Wednesday(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wednesday",
                data: data);
        }

        public static string Week(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Week",
                data: data);
        }

        public static string Weekly(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Weekly",
                data: data);
        }

        public static string Wide(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wide",
                data: data);
        }

        public static string WorkValue(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "WorkValue",
                data: data);
        }

        public static string Year(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Year",
                data: data);
        }

        public static string Yearly(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Yearly",
                data: data);
        }

        public static string YearsAgo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "YearsAgo",
                data: data);
        }

        public static string Ym(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Ym",
                data: data);
        }

        public static string Ymd(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Ymd",
                data: data);
        }

        public static string Ymda(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Ymda",
                data: data);
        }

        public static string YmdaFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "YmdaFormat",
                data: data);
        }

        public static string Ymdahm(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Ymdahm",
                data: data);
        }

        public static string YmdahmFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "YmdahmFormat",
                data: data);
        }

        public static string Ymdahms(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Ymdahms",
                data: data);
        }

        public static string YmdahmsFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "YmdahmsFormat",
                data: data);
        }

        public static string YmdDatePickerFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "YmdDatePickerFormat",
                data: data);
        }

        public static string YmdFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "YmdFormat",
                data: data);
        }

        public static string Ymdhm(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Ymdhm",
                data: data);
        }

        public static string YmdhmDatePickerFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "YmdhmDatePickerFormat",
                data: data);
        }

        public static string YmdhmFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "YmdhmFormat",
                data: data);
        }

        public static string Ymdhms(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Ymdhms",
                data: data);
        }

        public static string YmdhmsFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "YmdhmsFormat",
                data: data);
        }

        public static string YmFormat(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "YmFormat",
                data: data);
        }

        public static string Tenants_TenantId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_TenantId",
                data: data);
        }

        public static string Tenants_TenantName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_TenantName",
                data: data);
        }

        public static string Tenants_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_Title",
                data: data);
        }

        public static string Tenants_Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_Body",
                data: data);
        }

        public static string Tenants_ContractSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_ContractSettings",
                data: data);
        }

        public static string Tenants_ContractDeadline(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_ContractDeadline",
                data: data);
        }

        public static string Tenants_LogoType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_LogoType",
                data: data);
        }

        public static string Tenants_HtmlTitleTop(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_HtmlTitleTop",
                data: data);
        }

        public static string Tenants_HtmlTitleSite(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_HtmlTitleSite",
                data: data);
        }

        public static string Tenants_HtmlTitleRecord(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_HtmlTitleRecord",
                data: data);
        }

        public static string Demos_DemoId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_DemoId",
                data: data);
        }

        public static string Demos_TenantId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_TenantId",
                data: data);
        }

        public static string Demos_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_Title",
                data: data);
        }

        public static string Demos_LoginId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_LoginId",
                data: data);
        }

        public static string Demos_Passphrase(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_Passphrase",
                data: data);
        }

        public static string Demos_MailAddress(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_MailAddress",
                data: data);
        }

        public static string Demos_Initialized(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_Initialized",
                data: data);
        }

        public static string Demos_TimeLag(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_TimeLag",
                data: data);
        }

        public static string Sessions_SessionGuid(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_SessionGuid",
                data: data);
        }

        public static string Sessions_Key(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_Key",
                data: data);
        }

        public static string Sessions_Page(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_Page",
                data: data);
        }

        public static string Sessions_Value(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_Value",
                data: data);
        }

        public static string Sessions_ReadOnce(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_ReadOnce",
                data: data);
        }

        public static string SysLogs_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_CreatedTime",
                data: data);
        }

        public static string SysLogs_SysLogId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_SysLogId",
                data: data);
        }

        public static string SysLogs_StartTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_StartTime",
                data: data);
        }

        public static string SysLogs_EndTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_EndTime",
                data: data);
        }

        public static string SysLogs_SysLogType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_SysLogType",
                data: data);
        }

        public static string SysLogs_OnAzure(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_OnAzure",
                data: data);
        }

        public static string SysLogs_MachineName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_MachineName",
                data: data);
        }

        public static string SysLogs_ServiceName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_ServiceName",
                data: data);
        }

        public static string SysLogs_TenantName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_TenantName",
                data: data);
        }

        public static string SysLogs_Application(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Application",
                data: data);
        }

        public static string SysLogs_Class(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Class",
                data: data);
        }

        public static string SysLogs_Method(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Method",
                data: data);
        }

        public static string SysLogs_RequestData(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_RequestData",
                data: data);
        }

        public static string SysLogs_HttpMethod(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_HttpMethod",
                data: data);
        }

        public static string SysLogs_RequestSize(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_RequestSize",
                data: data);
        }

        public static string SysLogs_ResponseSize(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_ResponseSize",
                data: data);
        }

        public static string SysLogs_Elapsed(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Elapsed",
                data: data);
        }

        public static string SysLogs_ApplicationAge(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_ApplicationAge",
                data: data);
        }

        public static string SysLogs_ApplicationRequestInterval(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_ApplicationRequestInterval",
                data: data);
        }

        public static string SysLogs_SessionAge(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_SessionAge",
                data: data);
        }

        public static string SysLogs_SessionRequestInterval(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_SessionRequestInterval",
                data: data);
        }

        public static string SysLogs_WorkingSet64(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_WorkingSet64",
                data: data);
        }

        public static string SysLogs_VirtualMemorySize64(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_VirtualMemorySize64",
                data: data);
        }

        public static string SysLogs_ProcessId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_ProcessId",
                data: data);
        }

        public static string SysLogs_ProcessName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_ProcessName",
                data: data);
        }

        public static string SysLogs_BasePriority(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_BasePriority",
                data: data);
        }

        public static string SysLogs_Url(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Url",
                data: data);
        }

        public static string SysLogs_UrlReferer(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_UrlReferer",
                data: data);
        }

        public static string SysLogs_UserHostName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_UserHostName",
                data: data);
        }

        public static string SysLogs_UserHostAddress(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_UserHostAddress",
                data: data);
        }

        public static string SysLogs_UserLanguage(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_UserLanguage",
                data: data);
        }

        public static string SysLogs_UserAgent(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_UserAgent",
                data: data);
        }

        public static string SysLogs_SessionGuid(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_SessionGuid",
                data: data);
        }

        public static string SysLogs_ErrMessage(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_ErrMessage",
                data: data);
        }

        public static string SysLogs_ErrStackTrace(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_ErrStackTrace",
                data: data);
        }

        public static string SysLogs_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Title",
                data: data);
        }

        public static string SysLogs_InDebug(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_InDebug",
                data: data);
        }

        public static string SysLogs_AssemblyVersion(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_AssemblyVersion",
                data: data);
        }

        public static string Statuses_TenantId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_TenantId",
                data: data);
        }

        public static string Statuses_StatusId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_StatusId",
                data: data);
        }

        public static string Statuses_Value(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_Value",
                data: data);
        }

        public static string ReminderSchedules_SiteId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_SiteId",
                data: data);
        }

        public static string ReminderSchedules_Id(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_Id",
                data: data);
        }

        public static string ReminderSchedules_ScheduledTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_ScheduledTime",
                data: data);
        }

        public static string Depts_TenantId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_TenantId",
                data: data);
        }

        public static string Depts_DeptId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_DeptId",
                data: data);
        }

        public static string Depts_DeptCode(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_DeptCode",
                data: data);
        }

        public static string Depts_Dept(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_Dept",
                data: data);
        }

        public static string Depts_DeptName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_DeptName",
                data: data);
        }

        public static string Depts_Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_Body",
                data: data);
        }

        public static string Depts_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_Title",
                data: data);
        }

        public static string Groups_TenantId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_TenantId",
                data: data);
        }

        public static string Groups_GroupId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_GroupId",
                data: data);
        }

        public static string Groups_GroupName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_GroupName",
                data: data);
        }

        public static string Groups_Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_Body",
                data: data);
        }

        public static string Groups_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_Title",
                data: data);
        }

        public static string GroupMembers_GroupId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_GroupId",
                data: data);
        }

        public static string GroupMembers_DeptId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_DeptId",
                data: data);
        }

        public static string GroupMembers_UserId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_UserId",
                data: data);
        }

        public static string GroupMembers_Admin(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_Admin",
                data: data);
        }

        public static string Users_TenantId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_TenantId",
                data: data);
        }

        public static string Users_UserId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_UserId",
                data: data);
        }

        public static string Users_LoginId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_LoginId",
                data: data);
        }

        public static string Users_GlobalId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_GlobalId",
                data: data);
        }

        public static string Users_Name(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Name",
                data: data);
        }

        public static string Users_UserCode(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_UserCode",
                data: data);
        }

        public static string Users_Password(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Password",
                data: data);
        }

        public static string Users_PasswordValidate(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_PasswordValidate",
                data: data);
        }

        public static string Users_PasswordDummy(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_PasswordDummy",
                data: data);
        }

        public static string Users_RememberMe(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_RememberMe",
                data: data);
        }

        public static string Users_LastName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_LastName",
                data: data);
        }

        public static string Users_FirstName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_FirstName",
                data: data);
        }

        public static string Users_Birthday(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Birthday",
                data: data);
        }

        public static string Users_Gender(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Gender",
                data: data);
        }

        public static string Users_Language(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Language",
                data: data);
        }

        public static string Users_TimeZone(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_TimeZone",
                data: data);
        }

        public static string Users_TimeZoneInfo(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_TimeZoneInfo",
                data: data);
        }

        public static string Users_DeptCode(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DeptCode",
                data: data);
        }

        public static string Users_DeptId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DeptId",
                data: data);
        }

        public static string Users_Dept(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Dept",
                data: data);
        }

        public static string Users_FirstAndLastNameOrder(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_FirstAndLastNameOrder",
                data: data);
        }

        public static string Users_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Title",
                data: data);
        }

        public static string Users_Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Body",
                data: data);
        }

        public static string Users_LastLoginTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_LastLoginTime",
                data: data);
        }

        public static string Users_PasswordExpirationTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_PasswordExpirationTime",
                data: data);
        }

        public static string Users_PasswordChangeTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_PasswordChangeTime",
                data: data);
        }

        public static string Users_NumberOfLogins(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumberOfLogins",
                data: data);
        }

        public static string Users_NumberOfDenial(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumberOfDenial",
                data: data);
        }

        public static string Users_TenantManager(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_TenantManager",
                data: data);
        }

        public static string Users_ServiceManager(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ServiceManager",
                data: data);
        }

        public static string Users_Disabled(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Disabled",
                data: data);
        }

        public static string Users_Lockout(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Lockout",
                data: data);
        }

        public static string Users_LockoutCounter(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_LockoutCounter",
                data: data);
        }

        public static string Users_Developer(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Developer",
                data: data);
        }

        public static string Users_UserSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_UserSettings",
                data: data);
        }

        public static string Users_ApiKey(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ApiKey",
                data: data);
        }

        public static string Users_OldPassword(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_OldPassword",
                data: data);
        }

        public static string Users_ChangedPassword(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ChangedPassword",
                data: data);
        }

        public static string Users_ChangedPasswordValidator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ChangedPasswordValidator",
                data: data);
        }

        public static string Users_AfterResetPassword(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_AfterResetPassword",
                data: data);
        }

        public static string Users_AfterResetPasswordValidator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_AfterResetPasswordValidator",
                data: data);
        }

        public static string Users_MailAddresses(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_MailAddresses",
                data: data);
        }

        public static string Users_DemoMailAddress(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DemoMailAddress",
                data: data);
        }

        public static string Users_SessionGuid(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_SessionGuid",
                data: data);
        }

        public static string Users_ClassA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassA",
                data: data);
        }

        public static string Users_ClassB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassB",
                data: data);
        }

        public static string Users_ClassC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassC",
                data: data);
        }

        public static string Users_ClassD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassD",
                data: data);
        }

        public static string Users_ClassE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassE",
                data: data);
        }

        public static string Users_ClassF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassF",
                data: data);
        }

        public static string Users_ClassG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassG",
                data: data);
        }

        public static string Users_ClassH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassH",
                data: data);
        }

        public static string Users_ClassI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassI",
                data: data);
        }

        public static string Users_ClassJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassJ",
                data: data);
        }

        public static string Users_ClassK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassK",
                data: data);
        }

        public static string Users_ClassL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassL",
                data: data);
        }

        public static string Users_ClassM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassM",
                data: data);
        }

        public static string Users_ClassN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassN",
                data: data);
        }

        public static string Users_ClassO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassO",
                data: data);
        }

        public static string Users_ClassP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassP",
                data: data);
        }

        public static string Users_ClassQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassQ",
                data: data);
        }

        public static string Users_ClassR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassR",
                data: data);
        }

        public static string Users_ClassS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassS",
                data: data);
        }

        public static string Users_ClassT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassT",
                data: data);
        }

        public static string Users_ClassU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassU",
                data: data);
        }

        public static string Users_ClassV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassV",
                data: data);
        }

        public static string Users_ClassW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassW",
                data: data);
        }

        public static string Users_ClassX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassX",
                data: data);
        }

        public static string Users_ClassY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassY",
                data: data);
        }

        public static string Users_ClassZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_ClassZ",
                data: data);
        }

        public static string Users_NumA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumA",
                data: data);
        }

        public static string Users_NumB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumB",
                data: data);
        }

        public static string Users_NumC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumC",
                data: data);
        }

        public static string Users_NumD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumD",
                data: data);
        }

        public static string Users_NumE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumE",
                data: data);
        }

        public static string Users_NumF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumF",
                data: data);
        }

        public static string Users_NumG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumG",
                data: data);
        }

        public static string Users_NumH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumH",
                data: data);
        }

        public static string Users_NumI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumI",
                data: data);
        }

        public static string Users_NumJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumJ",
                data: data);
        }

        public static string Users_NumK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumK",
                data: data);
        }

        public static string Users_NumL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumL",
                data: data);
        }

        public static string Users_NumM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumM",
                data: data);
        }

        public static string Users_NumN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumN",
                data: data);
        }

        public static string Users_NumO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumO",
                data: data);
        }

        public static string Users_NumP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumP",
                data: data);
        }

        public static string Users_NumQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumQ",
                data: data);
        }

        public static string Users_NumR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumR",
                data: data);
        }

        public static string Users_NumS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumS",
                data: data);
        }

        public static string Users_NumT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumT",
                data: data);
        }

        public static string Users_NumU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumU",
                data: data);
        }

        public static string Users_NumV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumV",
                data: data);
        }

        public static string Users_NumW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumW",
                data: data);
        }

        public static string Users_NumX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumX",
                data: data);
        }

        public static string Users_NumY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumY",
                data: data);
        }

        public static string Users_NumZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_NumZ",
                data: data);
        }

        public static string Users_DateA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateA",
                data: data);
        }

        public static string Users_DateB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateB",
                data: data);
        }

        public static string Users_DateC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateC",
                data: data);
        }

        public static string Users_DateD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateD",
                data: data);
        }

        public static string Users_DateE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateE",
                data: data);
        }

        public static string Users_DateF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateF",
                data: data);
        }

        public static string Users_DateG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateG",
                data: data);
        }

        public static string Users_DateH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateH",
                data: data);
        }

        public static string Users_DateI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateI",
                data: data);
        }

        public static string Users_DateJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateJ",
                data: data);
        }

        public static string Users_DateK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateK",
                data: data);
        }

        public static string Users_DateL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateL",
                data: data);
        }

        public static string Users_DateM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateM",
                data: data);
        }

        public static string Users_DateN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateN",
                data: data);
        }

        public static string Users_DateO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateO",
                data: data);
        }

        public static string Users_DateP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateP",
                data: data);
        }

        public static string Users_DateQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateQ",
                data: data);
        }

        public static string Users_DateR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateR",
                data: data);
        }

        public static string Users_DateS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateS",
                data: data);
        }

        public static string Users_DateT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateT",
                data: data);
        }

        public static string Users_DateU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateU",
                data: data);
        }

        public static string Users_DateV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateV",
                data: data);
        }

        public static string Users_DateW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateW",
                data: data);
        }

        public static string Users_DateX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateX",
                data: data);
        }

        public static string Users_DateY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateY",
                data: data);
        }

        public static string Users_DateZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DateZ",
                data: data);
        }

        public static string Users_DescriptionA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionA",
                data: data);
        }

        public static string Users_DescriptionB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionB",
                data: data);
        }

        public static string Users_DescriptionC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionC",
                data: data);
        }

        public static string Users_DescriptionD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionD",
                data: data);
        }

        public static string Users_DescriptionE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionE",
                data: data);
        }

        public static string Users_DescriptionF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionF",
                data: data);
        }

        public static string Users_DescriptionG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionG",
                data: data);
        }

        public static string Users_DescriptionH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionH",
                data: data);
        }

        public static string Users_DescriptionI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionI",
                data: data);
        }

        public static string Users_DescriptionJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionJ",
                data: data);
        }

        public static string Users_DescriptionK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionK",
                data: data);
        }

        public static string Users_DescriptionL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionL",
                data: data);
        }

        public static string Users_DescriptionM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionM",
                data: data);
        }

        public static string Users_DescriptionN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionN",
                data: data);
        }

        public static string Users_DescriptionO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionO",
                data: data);
        }

        public static string Users_DescriptionP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionP",
                data: data);
        }

        public static string Users_DescriptionQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionQ",
                data: data);
        }

        public static string Users_DescriptionR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionR",
                data: data);
        }

        public static string Users_DescriptionS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionS",
                data: data);
        }

        public static string Users_DescriptionT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionT",
                data: data);
        }

        public static string Users_DescriptionU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionU",
                data: data);
        }

        public static string Users_DescriptionV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionV",
                data: data);
        }

        public static string Users_DescriptionW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionW",
                data: data);
        }

        public static string Users_DescriptionX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionX",
                data: data);
        }

        public static string Users_DescriptionY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionY",
                data: data);
        }

        public static string Users_DescriptionZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_DescriptionZ",
                data: data);
        }

        public static string Users_CheckA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckA",
                data: data);
        }

        public static string Users_CheckB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckB",
                data: data);
        }

        public static string Users_CheckC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckC",
                data: data);
        }

        public static string Users_CheckD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckD",
                data: data);
        }

        public static string Users_CheckE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckE",
                data: data);
        }

        public static string Users_CheckF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckF",
                data: data);
        }

        public static string Users_CheckG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckG",
                data: data);
        }

        public static string Users_CheckH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckH",
                data: data);
        }

        public static string Users_CheckI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckI",
                data: data);
        }

        public static string Users_CheckJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckJ",
                data: data);
        }

        public static string Users_CheckK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckK",
                data: data);
        }

        public static string Users_CheckL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckL",
                data: data);
        }

        public static string Users_CheckM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckM",
                data: data);
        }

        public static string Users_CheckN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckN",
                data: data);
        }

        public static string Users_CheckO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckO",
                data: data);
        }

        public static string Users_CheckP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckP",
                data: data);
        }

        public static string Users_CheckQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckQ",
                data: data);
        }

        public static string Users_CheckR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckR",
                data: data);
        }

        public static string Users_CheckS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckS",
                data: data);
        }

        public static string Users_CheckT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckT",
                data: data);
        }

        public static string Users_CheckU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckU",
                data: data);
        }

        public static string Users_CheckV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckV",
                data: data);
        }

        public static string Users_CheckW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckW",
                data: data);
        }

        public static string Users_CheckX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckX",
                data: data);
        }

        public static string Users_CheckY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckY",
                data: data);
        }

        public static string Users_CheckZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CheckZ",
                data: data);
        }

        public static string Users_LdapSearchRoot(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_LdapSearchRoot",
                data: data);
        }

        public static string Users_SynchronizedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_SynchronizedTime",
                data: data);
        }

        public static string LoginKeys_LoginId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_LoginId",
                data: data);
        }

        public static string LoginKeys_Key(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_Key",
                data: data);
        }

        public static string LoginKeys_TenantNames(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_TenantNames",
                data: data);
        }

        public static string LoginKeys_TenantId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_TenantId",
                data: data);
        }

        public static string LoginKeys_UserId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_UserId",
                data: data);
        }

        public static string MailAddresses_OwnerId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_OwnerId",
                data: data);
        }

        public static string MailAddresses_OwnerType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_OwnerType",
                data: data);
        }

        public static string MailAddresses_MailAddressId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_MailAddressId",
                data: data);
        }

        public static string MailAddresses_MailAddress(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_MailAddress",
                data: data);
        }

        public static string MailAddresses_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_Title",
                data: data);
        }

        public static string Permissions_ReferenceId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_ReferenceId",
                data: data);
        }

        public static string Permissions_DeptId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_DeptId",
                data: data);
        }

        public static string Permissions_GroupId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_GroupId",
                data: data);
        }

        public static string Permissions_UserId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_UserId",
                data: data);
        }

        public static string Permissions_DeptName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_DeptName",
                data: data);
        }

        public static string Permissions_GroupName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_GroupName",
                data: data);
        }

        public static string Permissions_Name(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_Name",
                data: data);
        }

        public static string Permissions_PermissionType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_PermissionType",
                data: data);
        }

        public static string OutgoingMails_ReferenceType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_ReferenceType",
                data: data);
        }

        public static string OutgoingMails_ReferenceId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_ReferenceId",
                data: data);
        }

        public static string OutgoingMails_ReferenceVer(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_ReferenceVer",
                data: data);
        }

        public static string OutgoingMails_OutgoingMailId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_OutgoingMailId",
                data: data);
        }

        public static string OutgoingMails_Host(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Host",
                data: data);
        }

        public static string OutgoingMails_Port(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Port",
                data: data);
        }

        public static string OutgoingMails_From(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_From",
                data: data);
        }

        public static string OutgoingMails_To(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_To",
                data: data);
        }

        public static string OutgoingMails_Cc(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Cc",
                data: data);
        }

        public static string OutgoingMails_Bcc(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Bcc",
                data: data);
        }

        public static string OutgoingMails_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Title",
                data: data);
        }

        public static string OutgoingMails_Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Body",
                data: data);
        }

        public static string OutgoingMails_SentTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_SentTime",
                data: data);
        }

        public static string OutgoingMails_DestinationSearchRange(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_DestinationSearchRange",
                data: data);
        }

        public static string OutgoingMails_DestinationSearchText(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_DestinationSearchText",
                data: data);
        }

        public static string SearchIndexes_Word(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_Word",
                data: data);
        }

        public static string SearchIndexes_ReferenceId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_ReferenceId",
                data: data);
        }

        public static string SearchIndexes_Priority(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_Priority",
                data: data);
        }

        public static string SearchIndexes_ReferenceType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_ReferenceType",
                data: data);
        }

        public static string SearchIndexes_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_Title",
                data: data);
        }

        public static string SearchIndexes_Subset(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_Subset",
                data: data);
        }

        public static string SearchIndexes_InheritPermission(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_InheritPermission",
                data: data);
        }

        public static string Items_ReferenceId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_ReferenceId",
                data: data);
        }

        public static string Items_ReferenceType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_ReferenceType",
                data: data);
        }

        public static string Items_SiteId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_SiteId",
                data: data);
        }

        public static string Items_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_Title",
                data: data);
        }

        public static string Items_Site(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_Site",
                data: data);
        }

        public static string Items_FullText(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_FullText",
                data: data);
        }

        public static string Items_SearchIndexCreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_SearchIndexCreatedTime",
                data: data);
        }

        public static string Items_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_UpdatedTime",
                data: data);
        }

        public static string Sites_TenantId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_TenantId",
                data: data);
        }

        public static string Sites_SiteId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_SiteId",
                data: data);
        }

        public static string Sites_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_Title",
                data: data);
        }

        public static string Sites_ReferenceType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_ReferenceType",
                data: data);
        }

        public static string Sites_ParentId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_ParentId",
                data: data);
        }

        public static string Sites_InheritPermission(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_InheritPermission",
                data: data);
        }

        public static string Sites_SiteSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_SiteSettings",
                data: data);
        }

        public static string Sites_Publish(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_Publish",
                data: data);
        }

        public static string Sites_Ancestors(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_Ancestors",
                data: data);
        }

        public static string Sites_SiteMenu(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_SiteMenu",
                data: data);
        }

        public static string Sites_MonitorChangesColumns(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_MonitorChangesColumns",
                data: data);
        }

        public static string Sites_TitleColumns(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_TitleColumns",
                data: data);
        }

        public static string Sites_Export(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_Export",
                data: data);
        }

        public static string Orders_ReferenceId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_ReferenceId",
                data: data);
        }

        public static string Orders_ReferenceType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_ReferenceType",
                data: data);
        }

        public static string Orders_OwnerId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_OwnerId",
                data: data);
        }

        public static string Orders_Data(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_Data",
                data: data);
        }

        public static string ExportSettings_ReferenceType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_ReferenceType",
                data: data);
        }

        public static string ExportSettings_ReferenceId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_ReferenceId",
                data: data);
        }

        public static string ExportSettings_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_Title",
                data: data);
        }

        public static string ExportSettings_ExportSettingId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_ExportSettingId",
                data: data);
        }

        public static string ExportSettings_AddHeader(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_AddHeader",
                data: data);
        }

        public static string ExportSettings_ExportColumns(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_ExportColumns",
                data: data);
        }

        public static string Links_DestinationId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_DestinationId",
                data: data);
        }

        public static string Links_SourceId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_SourceId",
                data: data);
        }

        public static string Links_ReferenceType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_ReferenceType",
                data: data);
        }

        public static string Links_SiteId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_SiteId",
                data: data);
        }

        public static string Links_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_Title",
                data: data);
        }

        public static string Links_Subset(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_Subset",
                data: data);
        }

        public static string Links_SiteTitle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_SiteTitle",
                data: data);
        }

        public static string Binaries_BinaryId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_BinaryId",
                data: data);
        }

        public static string Binaries_TenantId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_TenantId",
                data: data);
        }

        public static string Binaries_ReferenceId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_ReferenceId",
                data: data);
        }

        public static string Binaries_Guid(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Guid",
                data: data);
        }

        public static string Binaries_BinaryType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_BinaryType",
                data: data);
        }

        public static string Binaries_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Title",
                data: data);
        }

        public static string Binaries_Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Body",
                data: data);
        }

        public static string Binaries_Bin(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Bin",
                data: data);
        }

        public static string Binaries_Thumbnail(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Thumbnail",
                data: data);
        }

        public static string Binaries_Icon(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Icon",
                data: data);
        }

        public static string Binaries_FileName(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_FileName",
                data: data);
        }

        public static string Binaries_Extension(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Extension",
                data: data);
        }

        public static string Binaries_Size(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Size",
                data: data);
        }

        public static string Binaries_ContentType(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_ContentType",
                data: data);
        }

        public static string Binaries_BinarySettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_BinarySettings",
                data: data);
        }

        public static string Issues_IssueId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_IssueId",
                data: data);
        }

        public static string Issues_StartTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_StartTime",
                data: data);
        }

        public static string Issues_CompletionTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CompletionTime",
                data: data);
        }

        public static string Issues_WorkValue(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_WorkValue",
                data: data);
        }

        public static string Issues_ProgressRate(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ProgressRate",
                data: data);
        }

        public static string Issues_RemainingWorkValue(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_RemainingWorkValue",
                data: data);
        }

        public static string Issues_Status(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_Status",
                data: data);
        }

        public static string Issues_Manager(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_Manager",
                data: data);
        }

        public static string Issues_Owner(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_Owner",
                data: data);
        }

        public static string Issues_ClassA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassA",
                data: data);
        }

        public static string Issues_ClassB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassB",
                data: data);
        }

        public static string Issues_ClassC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassC",
                data: data);
        }

        public static string Issues_ClassD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassD",
                data: data);
        }

        public static string Issues_ClassE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassE",
                data: data);
        }

        public static string Issues_ClassF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassF",
                data: data);
        }

        public static string Issues_ClassG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassG",
                data: data);
        }

        public static string Issues_ClassH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassH",
                data: data);
        }

        public static string Issues_ClassI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassI",
                data: data);
        }

        public static string Issues_ClassJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassJ",
                data: data);
        }

        public static string Issues_ClassK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassK",
                data: data);
        }

        public static string Issues_ClassL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassL",
                data: data);
        }

        public static string Issues_ClassM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassM",
                data: data);
        }

        public static string Issues_ClassN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassN",
                data: data);
        }

        public static string Issues_ClassO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassO",
                data: data);
        }

        public static string Issues_ClassP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassP",
                data: data);
        }

        public static string Issues_ClassQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassQ",
                data: data);
        }

        public static string Issues_ClassR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassR",
                data: data);
        }

        public static string Issues_ClassS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassS",
                data: data);
        }

        public static string Issues_ClassT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassT",
                data: data);
        }

        public static string Issues_ClassU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassU",
                data: data);
        }

        public static string Issues_ClassV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassV",
                data: data);
        }

        public static string Issues_ClassW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassW",
                data: data);
        }

        public static string Issues_ClassX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassX",
                data: data);
        }

        public static string Issues_ClassY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassY",
                data: data);
        }

        public static string Issues_ClassZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_ClassZ",
                data: data);
        }

        public static string Issues_NumA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumA",
                data: data);
        }

        public static string Issues_NumB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumB",
                data: data);
        }

        public static string Issues_NumC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumC",
                data: data);
        }

        public static string Issues_NumD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumD",
                data: data);
        }

        public static string Issues_NumE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumE",
                data: data);
        }

        public static string Issues_NumF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumF",
                data: data);
        }

        public static string Issues_NumG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumG",
                data: data);
        }

        public static string Issues_NumH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumH",
                data: data);
        }

        public static string Issues_NumI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumI",
                data: data);
        }

        public static string Issues_NumJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumJ",
                data: data);
        }

        public static string Issues_NumK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumK",
                data: data);
        }

        public static string Issues_NumL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumL",
                data: data);
        }

        public static string Issues_NumM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumM",
                data: data);
        }

        public static string Issues_NumN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumN",
                data: data);
        }

        public static string Issues_NumO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumO",
                data: data);
        }

        public static string Issues_NumP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumP",
                data: data);
        }

        public static string Issues_NumQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumQ",
                data: data);
        }

        public static string Issues_NumR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumR",
                data: data);
        }

        public static string Issues_NumS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumS",
                data: data);
        }

        public static string Issues_NumT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumT",
                data: data);
        }

        public static string Issues_NumU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumU",
                data: data);
        }

        public static string Issues_NumV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumV",
                data: data);
        }

        public static string Issues_NumW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumW",
                data: data);
        }

        public static string Issues_NumX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumX",
                data: data);
        }

        public static string Issues_NumY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumY",
                data: data);
        }

        public static string Issues_NumZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_NumZ",
                data: data);
        }

        public static string Issues_DateA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateA",
                data: data);
        }

        public static string Issues_DateB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateB",
                data: data);
        }

        public static string Issues_DateC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateC",
                data: data);
        }

        public static string Issues_DateD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateD",
                data: data);
        }

        public static string Issues_DateE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateE",
                data: data);
        }

        public static string Issues_DateF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateF",
                data: data);
        }

        public static string Issues_DateG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateG",
                data: data);
        }

        public static string Issues_DateH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateH",
                data: data);
        }

        public static string Issues_DateI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateI",
                data: data);
        }

        public static string Issues_DateJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateJ",
                data: data);
        }

        public static string Issues_DateK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateK",
                data: data);
        }

        public static string Issues_DateL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateL",
                data: data);
        }

        public static string Issues_DateM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateM",
                data: data);
        }

        public static string Issues_DateN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateN",
                data: data);
        }

        public static string Issues_DateO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateO",
                data: data);
        }

        public static string Issues_DateP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateP",
                data: data);
        }

        public static string Issues_DateQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateQ",
                data: data);
        }

        public static string Issues_DateR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateR",
                data: data);
        }

        public static string Issues_DateS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateS",
                data: data);
        }

        public static string Issues_DateT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateT",
                data: data);
        }

        public static string Issues_DateU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateU",
                data: data);
        }

        public static string Issues_DateV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateV",
                data: data);
        }

        public static string Issues_DateW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateW",
                data: data);
        }

        public static string Issues_DateX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateX",
                data: data);
        }

        public static string Issues_DateY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateY",
                data: data);
        }

        public static string Issues_DateZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DateZ",
                data: data);
        }

        public static string Issues_DescriptionA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionA",
                data: data);
        }

        public static string Issues_DescriptionB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionB",
                data: data);
        }

        public static string Issues_DescriptionC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionC",
                data: data);
        }

        public static string Issues_DescriptionD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionD",
                data: data);
        }

        public static string Issues_DescriptionE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionE",
                data: data);
        }

        public static string Issues_DescriptionF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionF",
                data: data);
        }

        public static string Issues_DescriptionG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionG",
                data: data);
        }

        public static string Issues_DescriptionH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionH",
                data: data);
        }

        public static string Issues_DescriptionI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionI",
                data: data);
        }

        public static string Issues_DescriptionJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionJ",
                data: data);
        }

        public static string Issues_DescriptionK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionK",
                data: data);
        }

        public static string Issues_DescriptionL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionL",
                data: data);
        }

        public static string Issues_DescriptionM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionM",
                data: data);
        }

        public static string Issues_DescriptionN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionN",
                data: data);
        }

        public static string Issues_DescriptionO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionO",
                data: data);
        }

        public static string Issues_DescriptionP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionP",
                data: data);
        }

        public static string Issues_DescriptionQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionQ",
                data: data);
        }

        public static string Issues_DescriptionR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionR",
                data: data);
        }

        public static string Issues_DescriptionS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionS",
                data: data);
        }

        public static string Issues_DescriptionT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionT",
                data: data);
        }

        public static string Issues_DescriptionU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionU",
                data: data);
        }

        public static string Issues_DescriptionV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionV",
                data: data);
        }

        public static string Issues_DescriptionW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionW",
                data: data);
        }

        public static string Issues_DescriptionX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionX",
                data: data);
        }

        public static string Issues_DescriptionY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionY",
                data: data);
        }

        public static string Issues_DescriptionZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_DescriptionZ",
                data: data);
        }

        public static string Issues_CheckA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckA",
                data: data);
        }

        public static string Issues_CheckB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckB",
                data: data);
        }

        public static string Issues_CheckC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckC",
                data: data);
        }

        public static string Issues_CheckD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckD",
                data: data);
        }

        public static string Issues_CheckE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckE",
                data: data);
        }

        public static string Issues_CheckF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckF",
                data: data);
        }

        public static string Issues_CheckG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckG",
                data: data);
        }

        public static string Issues_CheckH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckH",
                data: data);
        }

        public static string Issues_CheckI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckI",
                data: data);
        }

        public static string Issues_CheckJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckJ",
                data: data);
        }

        public static string Issues_CheckK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckK",
                data: data);
        }

        public static string Issues_CheckL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckL",
                data: data);
        }

        public static string Issues_CheckM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckM",
                data: data);
        }

        public static string Issues_CheckN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckN",
                data: data);
        }

        public static string Issues_CheckO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckO",
                data: data);
        }

        public static string Issues_CheckP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckP",
                data: data);
        }

        public static string Issues_CheckQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckQ",
                data: data);
        }

        public static string Issues_CheckR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckR",
                data: data);
        }

        public static string Issues_CheckS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckS",
                data: data);
        }

        public static string Issues_CheckT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckT",
                data: data);
        }

        public static string Issues_CheckU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckU",
                data: data);
        }

        public static string Issues_CheckV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckV",
                data: data);
        }

        public static string Issues_CheckW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckW",
                data: data);
        }

        public static string Issues_CheckX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckX",
                data: data);
        }

        public static string Issues_CheckY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckY",
                data: data);
        }

        public static string Issues_CheckZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CheckZ",
                data: data);
        }

        public static string Issues_AttachmentsA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsA",
                data: data);
        }

        public static string Issues_AttachmentsB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsB",
                data: data);
        }

        public static string Issues_AttachmentsC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsC",
                data: data);
        }

        public static string Issues_AttachmentsD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsD",
                data: data);
        }

        public static string Issues_AttachmentsE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsE",
                data: data);
        }

        public static string Issues_AttachmentsF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsF",
                data: data);
        }

        public static string Issues_AttachmentsG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsG",
                data: data);
        }

        public static string Issues_AttachmentsH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsH",
                data: data);
        }

        public static string Issues_AttachmentsI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsI",
                data: data);
        }

        public static string Issues_AttachmentsJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsJ",
                data: data);
        }

        public static string Issues_AttachmentsK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsK",
                data: data);
        }

        public static string Issues_AttachmentsL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsL",
                data: data);
        }

        public static string Issues_AttachmentsM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsM",
                data: data);
        }

        public static string Issues_AttachmentsN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsN",
                data: data);
        }

        public static string Issues_AttachmentsO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsO",
                data: data);
        }

        public static string Issues_AttachmentsP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsP",
                data: data);
        }

        public static string Issues_AttachmentsQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsQ",
                data: data);
        }

        public static string Issues_AttachmentsR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsR",
                data: data);
        }

        public static string Issues_AttachmentsS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsS",
                data: data);
        }

        public static string Issues_AttachmentsT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsT",
                data: data);
        }

        public static string Issues_AttachmentsU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsU",
                data: data);
        }

        public static string Issues_AttachmentsV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsV",
                data: data);
        }

        public static string Issues_AttachmentsW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsW",
                data: data);
        }

        public static string Issues_AttachmentsX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsX",
                data: data);
        }

        public static string Issues_AttachmentsY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsY",
                data: data);
        }

        public static string Issues_AttachmentsZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_AttachmentsZ",
                data: data);
        }

        public static string Issues_SiteTitle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_SiteTitle",
                data: data);
        }

        public static string Results_ResultId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ResultId",
                data: data);
        }

        public static string Results_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_Title",
                data: data);
        }

        public static string Results_Status(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_Status",
                data: data);
        }

        public static string Results_Manager(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_Manager",
                data: data);
        }

        public static string Results_Owner(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_Owner",
                data: data);
        }

        public static string Results_ClassA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassA",
                data: data);
        }

        public static string Results_ClassB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassB",
                data: data);
        }

        public static string Results_ClassC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassC",
                data: data);
        }

        public static string Results_ClassD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassD",
                data: data);
        }

        public static string Results_ClassE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassE",
                data: data);
        }

        public static string Results_ClassF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassF",
                data: data);
        }

        public static string Results_ClassG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassG",
                data: data);
        }

        public static string Results_ClassH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassH",
                data: data);
        }

        public static string Results_ClassI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassI",
                data: data);
        }

        public static string Results_ClassJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassJ",
                data: data);
        }

        public static string Results_ClassK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassK",
                data: data);
        }

        public static string Results_ClassL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassL",
                data: data);
        }

        public static string Results_ClassM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassM",
                data: data);
        }

        public static string Results_ClassN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassN",
                data: data);
        }

        public static string Results_ClassO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassO",
                data: data);
        }

        public static string Results_ClassP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassP",
                data: data);
        }

        public static string Results_ClassQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassQ",
                data: data);
        }

        public static string Results_ClassR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassR",
                data: data);
        }

        public static string Results_ClassS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassS",
                data: data);
        }

        public static string Results_ClassT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassT",
                data: data);
        }

        public static string Results_ClassU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassU",
                data: data);
        }

        public static string Results_ClassV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassV",
                data: data);
        }

        public static string Results_ClassW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassW",
                data: data);
        }

        public static string Results_ClassX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassX",
                data: data);
        }

        public static string Results_ClassY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassY",
                data: data);
        }

        public static string Results_ClassZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_ClassZ",
                data: data);
        }

        public static string Results_NumA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumA",
                data: data);
        }

        public static string Results_NumB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumB",
                data: data);
        }

        public static string Results_NumC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumC",
                data: data);
        }

        public static string Results_NumD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumD",
                data: data);
        }

        public static string Results_NumE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumE",
                data: data);
        }

        public static string Results_NumF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumF",
                data: data);
        }

        public static string Results_NumG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumG",
                data: data);
        }

        public static string Results_NumH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumH",
                data: data);
        }

        public static string Results_NumI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumI",
                data: data);
        }

        public static string Results_NumJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumJ",
                data: data);
        }

        public static string Results_NumK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumK",
                data: data);
        }

        public static string Results_NumL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumL",
                data: data);
        }

        public static string Results_NumM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumM",
                data: data);
        }

        public static string Results_NumN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumN",
                data: data);
        }

        public static string Results_NumO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumO",
                data: data);
        }

        public static string Results_NumP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumP",
                data: data);
        }

        public static string Results_NumQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumQ",
                data: data);
        }

        public static string Results_NumR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumR",
                data: data);
        }

        public static string Results_NumS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumS",
                data: data);
        }

        public static string Results_NumT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumT",
                data: data);
        }

        public static string Results_NumU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumU",
                data: data);
        }

        public static string Results_NumV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumV",
                data: data);
        }

        public static string Results_NumW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumW",
                data: data);
        }

        public static string Results_NumX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumX",
                data: data);
        }

        public static string Results_NumY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumY",
                data: data);
        }

        public static string Results_NumZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_NumZ",
                data: data);
        }

        public static string Results_DateA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateA",
                data: data);
        }

        public static string Results_DateB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateB",
                data: data);
        }

        public static string Results_DateC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateC",
                data: data);
        }

        public static string Results_DateD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateD",
                data: data);
        }

        public static string Results_DateE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateE",
                data: data);
        }

        public static string Results_DateF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateF",
                data: data);
        }

        public static string Results_DateG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateG",
                data: data);
        }

        public static string Results_DateH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateH",
                data: data);
        }

        public static string Results_DateI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateI",
                data: data);
        }

        public static string Results_DateJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateJ",
                data: data);
        }

        public static string Results_DateK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateK",
                data: data);
        }

        public static string Results_DateL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateL",
                data: data);
        }

        public static string Results_DateM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateM",
                data: data);
        }

        public static string Results_DateN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateN",
                data: data);
        }

        public static string Results_DateO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateO",
                data: data);
        }

        public static string Results_DateP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateP",
                data: data);
        }

        public static string Results_DateQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateQ",
                data: data);
        }

        public static string Results_DateR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateR",
                data: data);
        }

        public static string Results_DateS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateS",
                data: data);
        }

        public static string Results_DateT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateT",
                data: data);
        }

        public static string Results_DateU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateU",
                data: data);
        }

        public static string Results_DateV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateV",
                data: data);
        }

        public static string Results_DateW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateW",
                data: data);
        }

        public static string Results_DateX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateX",
                data: data);
        }

        public static string Results_DateY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateY",
                data: data);
        }

        public static string Results_DateZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DateZ",
                data: data);
        }

        public static string Results_DescriptionA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionA",
                data: data);
        }

        public static string Results_DescriptionB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionB",
                data: data);
        }

        public static string Results_DescriptionC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionC",
                data: data);
        }

        public static string Results_DescriptionD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionD",
                data: data);
        }

        public static string Results_DescriptionE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionE",
                data: data);
        }

        public static string Results_DescriptionF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionF",
                data: data);
        }

        public static string Results_DescriptionG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionG",
                data: data);
        }

        public static string Results_DescriptionH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionH",
                data: data);
        }

        public static string Results_DescriptionI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionI",
                data: data);
        }

        public static string Results_DescriptionJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionJ",
                data: data);
        }

        public static string Results_DescriptionK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionK",
                data: data);
        }

        public static string Results_DescriptionL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionL",
                data: data);
        }

        public static string Results_DescriptionM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionM",
                data: data);
        }

        public static string Results_DescriptionN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionN",
                data: data);
        }

        public static string Results_DescriptionO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionO",
                data: data);
        }

        public static string Results_DescriptionP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionP",
                data: data);
        }

        public static string Results_DescriptionQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionQ",
                data: data);
        }

        public static string Results_DescriptionR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionR",
                data: data);
        }

        public static string Results_DescriptionS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionS",
                data: data);
        }

        public static string Results_DescriptionT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionT",
                data: data);
        }

        public static string Results_DescriptionU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionU",
                data: data);
        }

        public static string Results_DescriptionV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionV",
                data: data);
        }

        public static string Results_DescriptionW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionW",
                data: data);
        }

        public static string Results_DescriptionX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionX",
                data: data);
        }

        public static string Results_DescriptionY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionY",
                data: data);
        }

        public static string Results_DescriptionZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_DescriptionZ",
                data: data);
        }

        public static string Results_CheckA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckA",
                data: data);
        }

        public static string Results_CheckB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckB",
                data: data);
        }

        public static string Results_CheckC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckC",
                data: data);
        }

        public static string Results_CheckD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckD",
                data: data);
        }

        public static string Results_CheckE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckE",
                data: data);
        }

        public static string Results_CheckF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckF",
                data: data);
        }

        public static string Results_CheckG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckG",
                data: data);
        }

        public static string Results_CheckH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckH",
                data: data);
        }

        public static string Results_CheckI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckI",
                data: data);
        }

        public static string Results_CheckJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckJ",
                data: data);
        }

        public static string Results_CheckK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckK",
                data: data);
        }

        public static string Results_CheckL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckL",
                data: data);
        }

        public static string Results_CheckM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckM",
                data: data);
        }

        public static string Results_CheckN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckN",
                data: data);
        }

        public static string Results_CheckO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckO",
                data: data);
        }

        public static string Results_CheckP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckP",
                data: data);
        }

        public static string Results_CheckQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckQ",
                data: data);
        }

        public static string Results_CheckR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckR",
                data: data);
        }

        public static string Results_CheckS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckS",
                data: data);
        }

        public static string Results_CheckT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckT",
                data: data);
        }

        public static string Results_CheckU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckU",
                data: data);
        }

        public static string Results_CheckV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckV",
                data: data);
        }

        public static string Results_CheckW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckW",
                data: data);
        }

        public static string Results_CheckX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckX",
                data: data);
        }

        public static string Results_CheckY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckY",
                data: data);
        }

        public static string Results_CheckZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CheckZ",
                data: data);
        }

        public static string Results_AttachmentsA(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsA",
                data: data);
        }

        public static string Results_AttachmentsB(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsB",
                data: data);
        }

        public static string Results_AttachmentsC(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsC",
                data: data);
        }

        public static string Results_AttachmentsD(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsD",
                data: data);
        }

        public static string Results_AttachmentsE(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsE",
                data: data);
        }

        public static string Results_AttachmentsF(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsF",
                data: data);
        }

        public static string Results_AttachmentsG(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsG",
                data: data);
        }

        public static string Results_AttachmentsH(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsH",
                data: data);
        }

        public static string Results_AttachmentsI(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsI",
                data: data);
        }

        public static string Results_AttachmentsJ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsJ",
                data: data);
        }

        public static string Results_AttachmentsK(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsK",
                data: data);
        }

        public static string Results_AttachmentsL(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsL",
                data: data);
        }

        public static string Results_AttachmentsM(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsM",
                data: data);
        }

        public static string Results_AttachmentsN(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsN",
                data: data);
        }

        public static string Results_AttachmentsO(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsO",
                data: data);
        }

        public static string Results_AttachmentsP(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsP",
                data: data);
        }

        public static string Results_AttachmentsQ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsQ",
                data: data);
        }

        public static string Results_AttachmentsR(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsR",
                data: data);
        }

        public static string Results_AttachmentsS(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsS",
                data: data);
        }

        public static string Results_AttachmentsT(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsT",
                data: data);
        }

        public static string Results_AttachmentsU(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsU",
                data: data);
        }

        public static string Results_AttachmentsV(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsV",
                data: data);
        }

        public static string Results_AttachmentsW(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsW",
                data: data);
        }

        public static string Results_AttachmentsX(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsX",
                data: data);
        }

        public static string Results_AttachmentsY(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsY",
                data: data);
        }

        public static string Results_AttachmentsZ(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_AttachmentsZ",
                data: data);
        }

        public static string Results_SiteTitle(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_SiteTitle",
                data: data);
        }

        public static string Wikis_WikiId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_WikiId",
                data: data);
        }

        public static string Tenants_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_Ver",
                data: data);
        }

        public static string Tenants_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_Comments",
                data: data);
        }

        public static string Tenants_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_Creator",
                data: data);
        }

        public static string Tenants_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_Updator",
                data: data);
        }

        public static string Tenants_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_CreatedTime",
                data: data);
        }

        public static string Tenants_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_UpdatedTime",
                data: data);
        }

        public static string Tenants_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_VerUp",
                data: data);
        }

        public static string Tenants_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants_Timestamp",
                data: data);
        }

        public static string Demos_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_Ver",
                data: data);
        }

        public static string Demos_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_Comments",
                data: data);
        }

        public static string Demos_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_Creator",
                data: data);
        }

        public static string Demos_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_Updator",
                data: data);
        }

        public static string Demos_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_CreatedTime",
                data: data);
        }

        public static string Demos_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_UpdatedTime",
                data: data);
        }

        public static string Demos_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_VerUp",
                data: data);
        }

        public static string Demos_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos_Timestamp",
                data: data);
        }

        public static string Sessions_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_Ver",
                data: data);
        }

        public static string Sessions_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_Comments",
                data: data);
        }

        public static string Sessions_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_Creator",
                data: data);
        }

        public static string Sessions_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_Updator",
                data: data);
        }

        public static string Sessions_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_CreatedTime",
                data: data);
        }

        public static string Sessions_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_UpdatedTime",
                data: data);
        }

        public static string Sessions_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_VerUp",
                data: data);
        }

        public static string Sessions_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions_Timestamp",
                data: data);
        }

        public static string SysLogs_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Ver",
                data: data);
        }

        public static string SysLogs_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Comments",
                data: data);
        }

        public static string SysLogs_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Creator",
                data: data);
        }

        public static string SysLogs_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Updator",
                data: data);
        }

        public static string SysLogs_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_UpdatedTime",
                data: data);
        }

        public static string SysLogs_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_VerUp",
                data: data);
        }

        public static string SysLogs_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs_Timestamp",
                data: data);
        }

        public static string Statuses_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_Ver",
                data: data);
        }

        public static string Statuses_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_Comments",
                data: data);
        }

        public static string Statuses_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_Creator",
                data: data);
        }

        public static string Statuses_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_Updator",
                data: data);
        }

        public static string Statuses_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_CreatedTime",
                data: data);
        }

        public static string Statuses_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_UpdatedTime",
                data: data);
        }

        public static string Statuses_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_VerUp",
                data: data);
        }

        public static string Statuses_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses_Timestamp",
                data: data);
        }

        public static string ReminderSchedules_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_Ver",
                data: data);
        }

        public static string ReminderSchedules_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_Comments",
                data: data);
        }

        public static string ReminderSchedules_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_Creator",
                data: data);
        }

        public static string ReminderSchedules_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_Updator",
                data: data);
        }

        public static string ReminderSchedules_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_CreatedTime",
                data: data);
        }

        public static string ReminderSchedules_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_UpdatedTime",
                data: data);
        }

        public static string ReminderSchedules_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_VerUp",
                data: data);
        }

        public static string ReminderSchedules_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules_Timestamp",
                data: data);
        }

        public static string Depts_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_Ver",
                data: data);
        }

        public static string Depts_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_Comments",
                data: data);
        }

        public static string Depts_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_Creator",
                data: data);
        }

        public static string Depts_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_Updator",
                data: data);
        }

        public static string Depts_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_CreatedTime",
                data: data);
        }

        public static string Depts_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_UpdatedTime",
                data: data);
        }

        public static string Depts_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_VerUp",
                data: data);
        }

        public static string Depts_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts_Timestamp",
                data: data);
        }

        public static string Groups_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_Ver",
                data: data);
        }

        public static string Groups_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_Comments",
                data: data);
        }

        public static string Groups_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_Creator",
                data: data);
        }

        public static string Groups_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_Updator",
                data: data);
        }

        public static string Groups_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_CreatedTime",
                data: data);
        }

        public static string Groups_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_UpdatedTime",
                data: data);
        }

        public static string Groups_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_VerUp",
                data: data);
        }

        public static string Groups_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups_Timestamp",
                data: data);
        }

        public static string GroupMembers_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_Ver",
                data: data);
        }

        public static string GroupMembers_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_Comments",
                data: data);
        }

        public static string GroupMembers_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_Creator",
                data: data);
        }

        public static string GroupMembers_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_Updator",
                data: data);
        }

        public static string GroupMembers_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_CreatedTime",
                data: data);
        }

        public static string GroupMembers_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_UpdatedTime",
                data: data);
        }

        public static string GroupMembers_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_VerUp",
                data: data);
        }

        public static string GroupMembers_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers_Timestamp",
                data: data);
        }

        public static string Users_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Ver",
                data: data);
        }

        public static string Users_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Comments",
                data: data);
        }

        public static string Users_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Creator",
                data: data);
        }

        public static string Users_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Updator",
                data: data);
        }

        public static string Users_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_CreatedTime",
                data: data);
        }

        public static string Users_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_UpdatedTime",
                data: data);
        }

        public static string Users_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_VerUp",
                data: data);
        }

        public static string Users_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users_Timestamp",
                data: data);
        }

        public static string LoginKeys_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_Ver",
                data: data);
        }

        public static string LoginKeys_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_Comments",
                data: data);
        }

        public static string LoginKeys_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_Creator",
                data: data);
        }

        public static string LoginKeys_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_Updator",
                data: data);
        }

        public static string LoginKeys_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_CreatedTime",
                data: data);
        }

        public static string LoginKeys_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_UpdatedTime",
                data: data);
        }

        public static string LoginKeys_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_VerUp",
                data: data);
        }

        public static string LoginKeys_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys_Timestamp",
                data: data);
        }

        public static string MailAddresses_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_Ver",
                data: data);
        }

        public static string MailAddresses_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_Comments",
                data: data);
        }

        public static string MailAddresses_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_Creator",
                data: data);
        }

        public static string MailAddresses_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_Updator",
                data: data);
        }

        public static string MailAddresses_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_CreatedTime",
                data: data);
        }

        public static string MailAddresses_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_UpdatedTime",
                data: data);
        }

        public static string MailAddresses_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_VerUp",
                data: data);
        }

        public static string MailAddresses_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses_Timestamp",
                data: data);
        }

        public static string Permissions_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_Ver",
                data: data);
        }

        public static string Permissions_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_Comments",
                data: data);
        }

        public static string Permissions_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_Creator",
                data: data);
        }

        public static string Permissions_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_Updator",
                data: data);
        }

        public static string Permissions_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_CreatedTime",
                data: data);
        }

        public static string Permissions_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_UpdatedTime",
                data: data);
        }

        public static string Permissions_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_VerUp",
                data: data);
        }

        public static string Permissions_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions_Timestamp",
                data: data);
        }

        public static string OutgoingMails_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Ver",
                data: data);
        }

        public static string OutgoingMails_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Comments",
                data: data);
        }

        public static string OutgoingMails_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Creator",
                data: data);
        }

        public static string OutgoingMails_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Updator",
                data: data);
        }

        public static string OutgoingMails_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_CreatedTime",
                data: data);
        }

        public static string OutgoingMails_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_UpdatedTime",
                data: data);
        }

        public static string OutgoingMails_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_VerUp",
                data: data);
        }

        public static string OutgoingMails_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails_Timestamp",
                data: data);
        }

        public static string SearchIndexes_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_Ver",
                data: data);
        }

        public static string SearchIndexes_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_Comments",
                data: data);
        }

        public static string SearchIndexes_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_Creator",
                data: data);
        }

        public static string SearchIndexes_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_Updator",
                data: data);
        }

        public static string SearchIndexes_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_CreatedTime",
                data: data);
        }

        public static string SearchIndexes_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_UpdatedTime",
                data: data);
        }

        public static string SearchIndexes_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_VerUp",
                data: data);
        }

        public static string SearchIndexes_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes_Timestamp",
                data: data);
        }

        public static string Items_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_Ver",
                data: data);
        }

        public static string Items_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_Comments",
                data: data);
        }

        public static string Items_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_Creator",
                data: data);
        }

        public static string Items_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_Updator",
                data: data);
        }

        public static string Items_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_CreatedTime",
                data: data);
        }

        public static string Items_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_VerUp",
                data: data);
        }

        public static string Items_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items_Timestamp",
                data: data);
        }

        public static string Sites_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_UpdatedTime",
                data: data);
        }

        public static string Sites_Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_Body",
                data: data);
        }

        public static string Sites_TitleBody(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_TitleBody",
                data: data);
        }

        public static string Sites_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_Ver",
                data: data);
        }

        public static string Sites_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_Comments",
                data: data);
        }

        public static string Sites_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_Creator",
                data: data);
        }

        public static string Sites_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_Updator",
                data: data);
        }

        public static string Sites_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_CreatedTime",
                data: data);
        }

        public static string Sites_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_VerUp",
                data: data);
        }

        public static string Sites_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites_Timestamp",
                data: data);
        }

        public static string Orders_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_Ver",
                data: data);
        }

        public static string Orders_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_Comments",
                data: data);
        }

        public static string Orders_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_Creator",
                data: data);
        }

        public static string Orders_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_Updator",
                data: data);
        }

        public static string Orders_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_CreatedTime",
                data: data);
        }

        public static string Orders_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_UpdatedTime",
                data: data);
        }

        public static string Orders_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_VerUp",
                data: data);
        }

        public static string Orders_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders_Timestamp",
                data: data);
        }

        public static string ExportSettings_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_Ver",
                data: data);
        }

        public static string ExportSettings_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_Comments",
                data: data);
        }

        public static string ExportSettings_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_Creator",
                data: data);
        }

        public static string ExportSettings_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_Updator",
                data: data);
        }

        public static string ExportSettings_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_CreatedTime",
                data: data);
        }

        public static string ExportSettings_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_UpdatedTime",
                data: data);
        }

        public static string ExportSettings_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_VerUp",
                data: data);
        }

        public static string ExportSettings_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings_Timestamp",
                data: data);
        }

        public static string Links_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_Ver",
                data: data);
        }

        public static string Links_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_Comments",
                data: data);
        }

        public static string Links_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_Creator",
                data: data);
        }

        public static string Links_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_Updator",
                data: data);
        }

        public static string Links_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_CreatedTime",
                data: data);
        }

        public static string Links_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_UpdatedTime",
                data: data);
        }

        public static string Links_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_VerUp",
                data: data);
        }

        public static string Links_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Links_Timestamp",
                data: data);
        }

        public static string Binaries_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Ver",
                data: data);
        }

        public static string Binaries_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Comments",
                data: data);
        }

        public static string Binaries_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Creator",
                data: data);
        }

        public static string Binaries_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Updator",
                data: data);
        }

        public static string Binaries_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_CreatedTime",
                data: data);
        }

        public static string Binaries_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_UpdatedTime",
                data: data);
        }

        public static string Binaries_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_VerUp",
                data: data);
        }

        public static string Binaries_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries_Timestamp",
                data: data);
        }

        public static string Issues_SiteId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_SiteId",
                data: data);
        }

        public static string Issues_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_UpdatedTime",
                data: data);
        }

        public static string Issues_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_Title",
                data: data);
        }

        public static string Issues_Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_Body",
                data: data);
        }

        public static string Issues_TitleBody(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_TitleBody",
                data: data);
        }

        public static string Issues_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_Ver",
                data: data);
        }

        public static string Issues_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_Comments",
                data: data);
        }

        public static string Issues_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_Creator",
                data: data);
        }

        public static string Issues_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_Updator",
                data: data);
        }

        public static string Issues_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_CreatedTime",
                data: data);
        }

        public static string Issues_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_VerUp",
                data: data);
        }

        public static string Issues_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues_Timestamp",
                data: data);
        }

        public static string Results_SiteId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_SiteId",
                data: data);
        }

        public static string Results_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_UpdatedTime",
                data: data);
        }

        public static string Results_Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_Body",
                data: data);
        }

        public static string Results_TitleBody(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_TitleBody",
                data: data);
        }

        public static string Results_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_Ver",
                data: data);
        }

        public static string Results_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_Comments",
                data: data);
        }

        public static string Results_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_Creator",
                data: data);
        }

        public static string Results_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_Updator",
                data: data);
        }

        public static string Results_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_CreatedTime",
                data: data);
        }

        public static string Results_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_VerUp",
                data: data);
        }

        public static string Results_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results_Timestamp",
                data: data);
        }

        public static string Wikis_SiteId(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_SiteId",
                data: data);
        }

        public static string Wikis_UpdatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_UpdatedTime",
                data: data);
        }

        public static string Wikis_Title(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_Title",
                data: data);
        }

        public static string Wikis_Body(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_Body",
                data: data);
        }

        public static string Wikis_TitleBody(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_TitleBody",
                data: data);
        }

        public static string Wikis_Ver(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_Ver",
                data: data);
        }

        public static string Wikis_Comments(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_Comments",
                data: data);
        }

        public static string Wikis_Creator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_Creator",
                data: data);
        }

        public static string Wikis_Updator(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_Updator",
                data: data);
        }

        public static string Wikis_CreatedTime(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_CreatedTime",
                data: data);
        }

        public static string Wikis_VerUp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_VerUp",
                data: data);
        }

        public static string Wikis_Timestamp(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis_Timestamp",
                data: data);
        }

        public static string Tenants(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Tenants",
                data: data);
        }

        public static string Demos(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Demos",
                data: data);
        }

        public static string Sessions(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sessions",
                data: data);
        }

        public static string SysLogs(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SysLogs",
                data: data);
        }

        public static string Statuses(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Statuses",
                data: data);
        }

        public static string ReminderSchedules(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ReminderSchedules",
                data: data);
        }

        public static string Depts(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Depts",
                data: data);
        }

        public static string Groups(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Groups",
                data: data);
        }

        public static string GroupMembers(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "GroupMembers",
                data: data);
        }

        public static string Users(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Users",
                data: data);
        }

        public static string LoginKeys(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "LoginKeys",
                data: data);
        }

        public static string MailAddresses(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "MailAddresses",
                data: data);
        }

        public static string Permissions(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Permissions",
                data: data);
        }

        public static string OutgoingMails(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "OutgoingMails",
                data: data);
        }

        public static string SearchIndexes(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "SearchIndexes",
                data: data);
        }

        public static string Items(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Items",
                data: data);
        }

        public static string Sites(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Sites",
                data: data);
        }

        public static string Orders(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Orders",
                data: data);
        }

        public static string ExportSettings(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "ExportSettings",
                data: data);
        }

        public static string Binaries(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Binaries",
                data: data);
        }

        public static string Issues(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Issues",
                data: data);
        }

        public static string Results(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Results",
                data: data);
        }

        public static string Wikis(
            IContext context,
            params string[] data)
        {
            return Get(
                context: context,
                id: "Wikis",
                data: data);
        }
    }
}
