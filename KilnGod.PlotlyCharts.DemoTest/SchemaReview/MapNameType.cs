using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.SchemaReview
{
    public class MapNameType
    {
        public string Name { get; set; } = string.Empty;

        public string PropertyName { get; set; } = string.Empty;

        public string LocationName { get; set; } = string.Empty;
        public string OriginalName { get; set; } = string.Empty;
        public string ClassTypeName { get; set; } = string.Empty;
        public string JsonType { get; set; } = string.Empty;

        public string FileName { get; set; } = string.Empty;

        public string SchemaSection { get; set; } = string.Empty;
        public bool HasChildren { get; set; } = false;
        public bool IsEnumeration { get; set; } = false;

#nullable disable
        public SchemaItem item { get; set; }
#nullable enable

        public static int ChildCount(MapNameType map)
        {
            int result = 0;

            if (map.item != null && map.item.Children != null)
            {
                result = map.item.Children.Count;
            }

            return result;
        }
    }
}
