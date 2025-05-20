using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class NetworkAccessPolicyAppliesToType
    {
        public static readonly NetworkAccessPolicyAppliesToType None = new NetworkAccessPolicyAppliesToType(0, "None");
        public static readonly NetworkAccessPolicyAppliesToType Organization = new NetworkAccessPolicyAppliesToType(1, "Entire Organization");
        public static readonly NetworkAccessPolicyAppliesToType ComputerGroup = new NetworkAccessPolicyAppliesToType(2, "Computer Group");
        public static readonly NetworkAccessPolicyAppliesToType Computers = new NetworkAccessPolicyAppliesToType(3, "Computers");

        public NetworkAccessPolicyAppliesToType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly NetworkAccessPolicyAppliesToType[] All =
        {
            None,
            Organization,
            ComputerGroup,
            Computers,
        };

        public static readonly int[] SearchByParameters =
        {
            Organization.Id,
            Computers.Id,
            ComputerGroup.Id
        };

        // Optional Find method.
        public static NetworkAccessPolicyAppliesToType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
