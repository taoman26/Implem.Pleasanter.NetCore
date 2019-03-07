using Implem.Libraries.Utilities;
using Implem.Pleasanter.Interfaces;
using Implem.Pleasanter.Libraries.Extensions;
using Implem.Pleasanter.Libraries.Html;
using Implem.Pleasanter.Libraries.HtmlParts;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using System;
using System.Data;
namespace Implem.Pleasanter.Libraries.DataTypes
{
    public class Time : IConvertable
    {
        public DateTime Value = 0.ToDateTime();
        public DateTime DisplayValue = 0.ToDateTime();

        public Time()
        {
        }

        public Time(IContext context, DataRow dataRow, string name)
        {
            Value = dataRow.DateTime(name);
            DisplayValue = Value.ToLocal(context: context);
        }

        public Time(IContext context, DateTime value, bool byForm = false)
        {
            Value = value.InRange()
                ? byForm
                    ? value.ToUniversal(context: context)
                    : value
                : 0.ToDateTime();
            DisplayValue = value;
        }

        public virtual string ToControl(IContext context, SiteSettings ss, Column column)
        {
            return Value.InRange()
                ? column.DisplayControl(
                    context: context,
                    value: DisplayValue)
                : string.Empty;
        }

        public virtual string ToResponse(IContext context, SiteSettings ss, Column column)
        {
            return Value.InRange()
                ? column.DisplayControl(
                    context: context,
                    value: DisplayValue)
                : string.Empty;
        }

        public override string ToString()
        {
            return Value.InRange()
                ? Value.ToString()
                : string.Empty;
        }

        public bool DifferentDate(IContext context)
        {
            return DisplayValue.Date != DateTime.Now.ToLocal(context: context).Date;
        }

        public virtual HtmlBuilder Td(HtmlBuilder hb, IContext context, Column column)
        {
            return hb.Td(action: () => hb
                .P(css: "time", action: () => hb
                    .Text(column.DisplayGrid(
                        context: context,
                        value: DisplayValue))));
        }

        public virtual string GridText(IContext context, Column column)
        {
            return column.DisplayGrid(
                context: context,
                value: DisplayValue);
        }

        public string ToExport(IContext context, Column column, ExportColumn exportColumn = null)
        {
            return DisplayValue.Display(
                context: context,
                format: exportColumn?.Format
                    ?? column?.EditorFormat
                    ?? "Ymd");
        }

        public virtual string ToNotice(
            IContext context,
            DateTime saved,
            Column column,
            bool updated,
            bool update)
        {
            return column.DisplayControl(
                context: context,
                value: DisplayValue).ToNoticeLine(
                    context: context,
                    saved: column.DisplayControl(
                        context: context,
                        value: saved.ToLocal(context: context)),
                    column: column,
                    updated: updated,
                    update: update);
        }

        public bool InitialValue(IContext context)
        {
            return Value == 0.ToDateTime();
        }
    }
}