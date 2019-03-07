using Implem.Libraries.Utilities;
using Implem.Pleasanter.Interfaces;
using Implem.Pleasanter.Libraries.Extensions;
using Implem.Pleasanter.Libraries.Html;
using Implem.Pleasanter.Libraries.HtmlParts;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using System;
namespace Implem.Pleasanter.Libraries.DataTypes
{
    [Serializable]
    public class SiteTitle : IConvertable
    {
        public long SiteId;

        public SiteTitle(long siteId)
        {
            SiteId = siteId;
        }

        public string Title(IContext context)
        {
            return SiteInfo.TenantCaches
                .Get(context.TenantId)?
                .SiteMenu
                .Get(SiteId)?
                .Title ?? string.Empty;
        }

        public string ToControl(IContext context, SiteSettings ss, Column column)
        {
            return Title(context: context);
        }

        public string ToResponse(IContext context, SiteSettings ss, Column column)
        {
            return Title(context: context);
        }

        public virtual HtmlBuilder Td(HtmlBuilder hb, IContext context, Column column)
        {
            return hb.Td(action: () => hb
                .P(action: () => hb
                    .Text(Title(context: context))));
        }

        public virtual string GridText(IContext context, Column column)
        {
            return Title(context: context);
        }

        public virtual string ToExport(
            IContext context, Column column, ExportColumn exportColumn = null)
        {
            return Title(context: context);
        }

        public bool InitialValue(IContext context)
        {
            return SiteId == 0;
        }
    }
}
