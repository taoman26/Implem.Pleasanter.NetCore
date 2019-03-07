using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using System;
namespace Implem.Pleasanter.Libraries.Extensions
{
    public static class ToControlExtensions
    {
        public static string ToControl(
            this bool self, IContext context, SiteSettings ss, Column column)
        {
            return self.ToString();
        }

        public static string ToControl(
            this DateTime self, IContext context, SiteSettings ss, Column column)
        {
            return column.DisplayControl(
                context: context,
                value: self.ToLocal(context: context));
        }

        public static string ToControl(
            this string self, IContext context, SiteSettings ss, Column column)
        {
            return self;
        }

        public static string ToControl(
            this int self, IContext context, SiteSettings ss, Column column)
        {
            return self.ToString(column.StringFormat);
        }

        public static string ToControl(
            this long self, IContext context, SiteSettings ss, Column column)
        {
            return self.ToString(column.StringFormat);
        }

        public static string ToControl(
            this decimal self, IContext context, SiteSettings ss, Column column)
        {
            return column.ControlType == "Spinner"
                ? column.Display(
                    context: context,
                    value: self,
                    format: false)
                : column.Display(
                    context: context,
                    ss: ss,
                    value: self,
                    format: column.Format == "C");
        }
    }
}