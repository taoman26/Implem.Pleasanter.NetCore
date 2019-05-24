﻿using Implem.Libraries.Utilities;
using Implem.Pleasanter.Interfaces;
using Implem.Pleasanter.Libraries.Html;
using Implem.Pleasanter.Libraries.HtmlParts;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using System;
namespace Implem.Pleasanter.Libraries.Extensions
{
    public static class TdExtensions
    {
        public static HtmlBuilder Td(
            this HtmlBuilder hb, Context context, Column column, IConvertable value)
        {
            return column != null && value != null
                ? value.Td(hb: hb, context: context, column: column)
                : hb.Td(action: () => hb
                    .Text(string.Empty));
        }

        public static HtmlBuilder Td(
            this HtmlBuilder hb, Context context, Column column, TimeZoneInfo value)
        {
            return hb.Td(action: () => hb
                .Text(text: value?.StandardName ?? string.Empty));
        }

        public static HtmlBuilder Td(
            this HtmlBuilder hb, Context context, Column column, string value)
        {
            return column.HasChoices()
                ? hb.Td(action: () =>
                {
                    var choice = column.Choice(
                        value,
                        nullCase: value.IsNullOrEmpty()
                            ? null
                            : "? " + value);
                    hb.P(
                        attributes: new HtmlAttributes()
                            .Class(choice.CssClass)
                            .Style(choice.Style),
                        action: () => hb
                            .Text(choice.TextMini));
                })
                : column.ControlType == "MarkDown"
                    ? hb.Td(action: () => hb
                        .Div(css: "grid-title-body", action: () => hb
                            .P(css: "body markup", action: () => hb
                                .Text(text: value))))
                    : hb.Td(action: () => hb
                        .Text(text: value));
        }

        public static HtmlBuilder Td(
            this HtmlBuilder hb, Context context, Column column, int value)
        {
            return hb.Td(action: () => hb
                .Text(text: value.ToString(column.StringFormat) + column.Unit));
        }

        public static HtmlBuilder Td(
            this HtmlBuilder hb, Context context, Column column, long value)
        {
            return hb.Td(action: () => hb
                .Text(text: value.ToString(column.StringFormat) + column.Unit));
        }

        public static HtmlBuilder Td(
            this HtmlBuilder hb, Context context, Column column, decimal value)
        {
            return hb.Td(action: () => hb
                .Text(text: column.Display(
                    context: context,
                    value: value,
                    unit: true)));
        }

        public static HtmlBuilder Td(
            this HtmlBuilder hb, Context context, Column column, DateTime value)
        {
            return hb.Td(action: () => hb
                .Text(text: column.DisplayGrid(
                    context: context,
                    value: value.ToLocal(context: context))));
        }

        public static HtmlBuilder Td(
            this HtmlBuilder hb, Context context, Column column, bool value)
        {
            return column.HasChoices()
                ? value
                    ? hb.Td(action: () => hb
                        .Text(text: column.ChoicesText.SplitReturn()._1st()))
                    : hb.Td(action: () => hb
                        .Text(text: column.ChoicesText.SplitReturn()._2nd()))
                : hb.Td(action: () => hb
                    .Span(css: "ui-icon ui-icon-circle-check", _using: value));
        }

        public static HtmlBuilder Td(
            this HtmlBuilder hb, Context context, Column column, Enum value)
        {
            return hb.Td(action: () => hb
                .Text(text: value.ToString()));
        }
    }
}