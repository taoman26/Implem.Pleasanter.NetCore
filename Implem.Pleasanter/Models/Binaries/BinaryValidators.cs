using Implem.DefinitionAccessor;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.General;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Security;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using System.Linq;
namespace Implem.Pleasanter.Models
{
    public static class BinaryValidators
    {
        public static Error.Types OnGetting(IContext context, SiteSettings ss)
        {
            if (!context.HasPermission(ss: ss))
            {
                return Error.Types.HasNotPermission;
            }
            return Error.Types.None;
        }

        public static Error.Types OnUpdating(IContext context, SiteSettings ss)
        {
            if (!context.CanManageSite(ss: ss))
            {
                return Error.Types.HasNotPermission;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static Error.Types OnUploadingSiteImage(
            IContext context, SiteSettings ss, byte[] bin)
        {
            if (!context.CanManageSite(ss: ss))
            {
                return Error.Types.HasNotPermission;
            }
            if (bin == null)
            {
                return Error.Types.SelectFile;
            }
            try
            {
                System.Drawing.Image.FromStream(new System.IO.MemoryStream(bin));
            }
            catch (System.Exception)
            {
                return Error.Types.IncorrectFileFormat;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static Error.Types OnUploadingTenantImage(
            IContext context, SiteSettings ss, byte[] bin)
        {
            if (!Permissions.CanManageTenant(context)
                && context.UserSettings?.EnableManageTenant != true)
            {
                return Error.Types.HasNotPermission;
            }
            if (bin == null)
            {
                return Error.Types.SelectFile;
            }
            try
            {
                System.Drawing.Image.FromStream(new System.IO.MemoryStream(bin));
            }
            catch (System.Exception)
            {
                return Error.Types.IncorrectFileFormat;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static Error.Types OnDeletingSiteImage(IContext context, SiteSettings ss)
        {
            if (!context.CanManageSite(ss: ss))
            {
                return Error.Types.HasNotPermission;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static Error.Types OnDeletingTenantImage(IContext context, SiteSettings ss)
        {
            if (!Permissions.CanManageTenant(context)
                && context.UserSettings?.EnableManageTenant != true)
            {
                return Error.Types.HasNotPermission;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static Error.Types OnUploadingImage(IContext context)
        {
            if (!context.ContractSettings.Attachments())
            {
                return Error.Types.BadRequest;
            }
            var newTotalFileSize = context.PostedFiles.Sum(x => x.Size);
            if (OverTenantStorageSize(
                BinaryUtilities.UsedTenantStorageSize(context: context),
                newTotalFileSize,
                context.ContractSettings.StorageSize))
            {
                return Error.Types.OverTenantStorageSize;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static Error.Types OnDeletingImage(
            IContext context, SiteSettings ss, BinaryModel binaryModel)
        {
            if (!context.CanUpdate(ss: ss))
            {
                return Error.Types.HasNotPermission;
            }
            if (binaryModel.AccessStatus != Databases.AccessStatuses.Selected)
            {
                return Error.Types.NotFound;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static Error.Types OnUploading(
            IContext context,
            Column column,
            Libraries.DataTypes.Attachments attachments)
        {
            if (!context.ContractSettings.Attachments())
            {
                return Error.Types.BadRequest;
            }
            if (OverLimitQuantity(
                attachments?.Count().ToDecimal() ?? 0,
                context.PostedFiles?.Count().ToDecimal() ?? 0,
                column.LimitQuantity))
            {
                return Error.Types.OverLimitQuantity;
            }
            if (OverLimitSize(context, column.LimitSize))
            {
                return Error.Types.OverLimitSize;
            }
            var newTotalFileSize = context.PostedFiles.Sum(x => x.Size.ToDecimal());
            if (OverTotalLimitSize(
                attachments?.Select(x => x.Size.ToDecimal()).Sum() ?? 0,
                newTotalFileSize,
                column.TotalLimitSize))
            {
                return Error.Types.OverTotalLimitSize;
            }
            if (OverTenantStorageSize(
                BinaryUtilities.UsedTenantStorageSize(context: context),
                newTotalFileSize,
                context.ContractSettings.StorageSize))
            {
                return Error.Types.OverTenantStorageSize;
            }
            return Error.Types.None;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static bool OverLimitQuantity(
            decimal fileCount, decimal newFileCount, decimal? limit)
        {
            if ((fileCount + newFileCount) > limit) return true;
            return false;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static bool OverLimitSize(IContext context, decimal? limit)
        {
            foreach (var item in context.PostedFiles)
            {
                if (item.Size > limit * 1024 * 1024) return true;
            }
            return false;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static bool OverTotalLimitSize(
            decimal totalFileSize, decimal newTotalFileSize, decimal? limit)
        {
            if ((totalFileSize + newTotalFileSize) > limit * 1024 * 1024) return true;
            return false;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static bool OverTenantStorageSize(
            decimal totalFileSize, decimal newTotalFileSize, decimal? limit)
        {
            if (limit != null &&
                (totalFileSize + newTotalFileSize) > limit * 1024 * 1024 * 1024) return true;
            return false;
        }
    }
}
