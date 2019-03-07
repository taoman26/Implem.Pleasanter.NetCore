using Implem.Pleasanter.Libraries.Html;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Settings;
namespace Implem.Pleasanter.Interfaces
{
    public interface IConvertable
    {
        string ToControl(IContext context, SiteSettings ss, Column column);
        string ToResponse(IContext context, SiteSettings ss, Column column);
        HtmlBuilder Td(HtmlBuilder hb, IContext context, Column column);
        string ToExport(IContext context, Column column, ExportColumn exportColumn = null);
        bool InitialValue(IContext context);
    }
}