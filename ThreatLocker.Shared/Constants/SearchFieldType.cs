using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class SearchFieldType
    {
        public static readonly SearchFieldType StringType = new SearchFieldType(1, "StringType","'");
        public static readonly SearchFieldType GuidType = new SearchFieldType(2, "GuidType", "'");
        public static readonly SearchFieldType NumericType = new SearchFieldType(3, "NumericType");
        public static readonly SearchFieldType LongType = new SearchFieldType(4, "LongType");
        public static readonly SearchFieldType BoolType = new SearchFieldType(5, "BoolType");
        public static readonly SearchFieldType DateType = new SearchFieldType(6, "DateType", "'");
        public static readonly SearchFieldType DateTypePeriod = new SearchFieldType(7, "DateTypePeriod", "'");

        public SearchFieldType(int id, string name, string quote = null)
        {
            Id = id;
            Name = name;
            Quote = (quote != null?quote:string.Empty);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Quote { get; set; }

        public static readonly SearchFieldType[] All =
        {
            StringType,
            GuidType,
            NumericType,
            LongType,
            BoolType,
            DateType,
            DateTypePeriod
        };

        public static readonly List<string> unicodeColumns = new List<string>() 
        {
            "ApplicationName",
            "Cert" 
        };

        public static SearchFieldType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static SearchFieldType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
