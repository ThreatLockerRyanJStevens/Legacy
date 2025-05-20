using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class SearchOperatorType
    {
        public static readonly SearchOperatorType None = new SearchOperatorType(0, "", false, "");
        public static readonly SearchOperatorType Equal = new SearchOperatorType(1, "Equals", true, " = ");
        public static readonly SearchOperatorType NotEqual = new SearchOperatorType(2, "Not Equals", false, " <> ");
        public static readonly SearchOperatorType StartsWith = new SearchOperatorType(3, "Starts With", true, " LIKE ");
        public static readonly SearchOperatorType EndsWith = new SearchOperatorType(4, "Ends With", true, " LIKE ");
        public static readonly SearchOperatorType Contains = new SearchOperatorType(5, "Contains", true, " LIKE ");
        public static readonly SearchOperatorType NotContains = new SearchOperatorType(6, "Not Contains", false, " NOT LIKE ");
        public static readonly SearchOperatorType In = new SearchOperatorType(7, "In", true);
        public static readonly SearchOperatorType GreaterThan = new SearchOperatorType(8, "Greater Than", false, " >= ");
        public static readonly SearchOperatorType LessThan = new SearchOperatorType(9, "Less Than", false, " <= ");
        public static readonly SearchOperatorType NotIn = new SearchOperatorType(10, "Not In", false);

        public SearchOperatorType(int id, string name, bool positive = false, string? compair = null)
        {
            Id = id;
            Name = name;

            if (compair != null)
                Operator = compair;

            Positive = positive;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Operator { get; set; }
        public bool Positive { get; set; }

        public static readonly SearchOperatorType[] DirectCompare =
        {
            Equal,
            NotEqual,
            GreaterThan,
            LessThan,
            Contains,
            NotContains,
            StartsWith,
            EndsWith
        };

        public static readonly SearchOperatorType[] All =
        {
            None,
            Equal,
            NotEqual,
            StartsWith,
            EndsWith,
            Contains,
            NotContains,
            In,
            GreaterThan,
            LessThan,
            NotIn
        };

        public static SearchOperatorType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static SearchOperatorType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
