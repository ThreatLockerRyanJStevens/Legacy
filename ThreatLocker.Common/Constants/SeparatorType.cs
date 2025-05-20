using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class SeparatorType
    {
        public static readonly SeparatorType Hyphen = new SeparatorType(1, "-");
        public static readonly SeparatorType ParenthesesStart = new SeparatorType(2, "(");
        public static readonly SeparatorType ParenthesesEnd = new SeparatorType(3, ")");
        public static readonly SeparatorType Period = new SeparatorType(4, ".");
        public static readonly SeparatorType Colon = new SeparatorType(5, ":");

        public static readonly SeparatorType ButtonTag = new SeparatorType(6, "<button");
        public static readonly SeparatorType ALinkTag = new SeparatorType(7, "<a");
        public static readonly SeparatorType ALinkCloseTag = new SeparatorType(8, "</a");
        public static readonly SeparatorType OnClick = new SeparatorType(9, "onclick=\"");
        public static readonly SeparatorType GreatherThan = new SeparatorType(10, ">");
        public static readonly SeparatorType LessThan = new SeparatorType(11, "<");
        public static readonly SeparatorType QuotationMark = new SeparatorType(12, "\"");
        public static readonly SeparatorType Href = new SeparatorType(13, "href=\"");
        public static readonly SeparatorType Comma = new SeparatorType(14, ",");
        public static readonly SeparatorType SimpleQuotationMark = new SeparatorType(15, "'");

        public SeparatorType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public static readonly SeparatorType[] All =
        {
            Hyphen,
            ParenthesesStart,
            ParenthesesEnd,
            Period,
            Colon
        };

        public static SeparatorType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static SeparatorType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

    }
}
