namespace ThreatLockerCommon.Constants
{
    public class NetworkAccessPolicyStatus
    {
        public static readonly NetworkAccessPolicyStatus Active = new NetworkAccessPolicyStatus(1, "Active");
        public static readonly NetworkAccessPolicyStatus Deleted = new NetworkAccessPolicyStatus(2, "Deleted");
        public static readonly NetworkAccessPolicyStatus Disabled = new NetworkAccessPolicyStatus(3, "Disabled");

        public NetworkAccessPolicyStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
