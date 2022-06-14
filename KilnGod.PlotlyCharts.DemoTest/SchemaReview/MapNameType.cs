using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.SchemaReview
{
    public struct MapNameType
    {
        public string Name { get; set; }

        public string PropertyName { get; set; }

        public string OriginalName { get; set; }
        public string ClassTypeName { get; set; }
        public string JsonType { get; set; }

        public string FileName { get; set; }

        public string SchemaSection { get; set; }
        public bool HasChildren { get; set; }
        public bool IsEnumeration { get; set; }

        public SchemaItem item { get; set; }

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
