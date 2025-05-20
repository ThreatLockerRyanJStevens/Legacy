using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class NetworkPolicyRuleType
    {
        public static readonly NetworkPolicyRuleType Source = new NetworkPolicyRuleType(1, "Source");
        public static readonly NetworkPolicyRuleType Destination = new NetworkPolicyRuleType(2, "Destination");

        public NetworkPolicyRuleType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly NetworkPolicyRuleType[] All =
        {
            Source,
            Destination
        };

        // Optional Find method.
        public static NetworkPolicyRuleType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        // Optional Find method.
        public static NetworkPolicyRuleType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
