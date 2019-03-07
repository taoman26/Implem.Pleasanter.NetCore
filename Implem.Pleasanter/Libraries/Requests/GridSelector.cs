using Implem.Libraries.Utilities;
using System.Collections.Generic;
using System.Linq;
namespace Implem.Pleasanter.Libraries.Requests
{
    public class GridSelector
    {
        public bool All;
        public List<long> Selected;

        public GridSelector(IContext context)
        {
            All = context.Forms.Bool("GridCheckAll");
            Selected = All
                ? Get(
                    context: context,
                    name: "GridUnCheckedItems")
                : Get(
                    context: context,
                    name: "GridCheckedItems");
        }

        private static List<long> Get(IContext context, string name)
        {
            return context.Forms.Data(name)
                .Split(',')
                .Select(o => o.ToLong())
                .Where(o => o != 0)
                .Distinct()
                .ToList();
        }
    }
}