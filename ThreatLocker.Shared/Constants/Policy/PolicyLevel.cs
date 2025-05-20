using System.Linq;

namespace ThreatLocker.Shared.Constants.Policy
{
    public class PolicyLevel
    {
        public static readonly PolicyLevel None = new PolicyLevel(0, "None");
        public static readonly PolicyLevel Computer = new PolicyLevel(1, "Computer");
        public static readonly PolicyLevel Group = new PolicyLevel(2, "Group");
        public static readonly PolicyLevel Organization = new PolicyLevel(3, "Organization");
        public static readonly PolicyLevel Global = new PolicyLevel(4, "Global");

        public PolicyLevel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PolicyLevel[] All =
        {
            Computer,
            Group,
            Organization,
            Global
        };

        // Optional Find method.
        public static PolicyLevel Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PolicyLevel FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
