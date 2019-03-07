using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using System;
namespace Implem.Pleasanter.Libraries.Extensions
{
    public static class ToNoticeExtensions
    {
        public static string ToNotice(
            this bool self,
            IContext context,
            bool saved,
            Column column,
            bool updated,
            bool update)
        {
            return self.ToString().ToNoticeLine(
                context: context,
                saved: saved.ToString(),
                column: column,
                updated: updated,
                update: update);
        }

        public static string ToNotice(
            this int self,
            IContext context,
            int saved,
            Column column,
            bool updated,
            bool update)
        {
            return self.ToString().ToNoticeLine(
                context: context,
                saved: saved.ToString(),
                column: column,
                updated: updated,
                update: update);
        }

        public static string ToNotice(
            this long self,
            IContext context,
            long saved,
            Column column,
            bool updated,
            bool update)
        {
            return self.ToString().ToNoticeLine(
                context: context,
                saved: saved.ToString(),
                column: column,
                updated: updated,
                update: update);
        }

        public static string ToNotice(
            this decimal self,
            IContext context,
            decimal saved,
            Column column,
            bool updated,
            bool update)
        {
            return column.Display(
                context: context,
                value: self,
                unit: true).ToNoticeLine(
                    context: context,
                    saved: column.Display(
                        context: context,
                        value: saved,
                        unit: true),
                    column: column,
                    updated: updated,
                    update: update);
        }

        public static string ToNotice(
            this DateTime self,
            IContext context,
            DateTime saved,
            Column column,
            bool updated,
            bool update)
        {
            return column.DisplayControl(
                context: context,
                value: self.ToLocal(context: context)).ToNoticeLine(
                    context: context,
                    saved: column.DisplayControl(
                        context: context,
                        value: saved.ToLocal(context: context)),
                    column: column,
                    updated: updated,
                    update: update);
        }

        public static string ToNotice(
            this string self,
            IContext context,
            string saved,
            Column column,
            bool updated,
            bool update)
        {
            return column.HasChoices()
                ? column.Choice(self).Text.ToNoticeLine(
                    context: context,
                    saved: column.Choice(saved).Text,
                    column: column,
                    updated: updated,
                    update: update)
                : self.ToNoticeLine(
                    context: context,
                    saved: saved,
                    column: column,
                    updated: updated,
                    update: update);
        }

        public static string ToNoticeLine(
            this string self,
            IContext context,
            string saved,
            Column column,
            bool updated,
            bool update,
            string suffix = null)
        {
            return update
                ? updated
                    ? saved != string.Empty
                        ? "{0}{3} : {2} => {1}\r\n".Params(column.LabelText, self, saved, suffix)
                        : "{0}{2} : {1}\r\n".Params(column.LabelText, self, suffix)
                    : string.Empty
                : "{0}{2}: {1}\r\n".Params(column.LabelText, self, suffix);
        }
    }
}