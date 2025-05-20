using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class NetworkAccessPolicyStatusType
    {
        public static readonly NetworkAccessPolicyStatusType Active = new NetworkAccessPolicyStatusType(1, "Active");
        public static readonly NetworkAccessPolicyStatusType Deleted = new NetworkAccessPolicyStatusType(2, "Deleted");
        public static readonly NetworkAccessPolicyStatusType Disabled = new NetworkAccessPolicyStatusType(3, "Disabled");

        public NetworkAccessPolicyStatusType(byte id, string name)
        {
            Id = id;
            Name = name;
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public static readonly NetworkAccessPolicyStatusType[] All =
        {
            Active,
            Deleted,
            Disabled
        };

        //Optional Find method
        public static NetworkAccessPolicyStatusType Find(byte id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static NetworkAccessPolicyStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
