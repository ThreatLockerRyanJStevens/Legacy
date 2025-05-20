using System.Linq;

namespace ThreatLocker.Shared.Constants.Community
{
    public class CommunityItemType
    {
        public static readonly CommunityItemType Any = new CommunityItemType(0, "Any");
        public static readonly CommunityItemType ApplicationPolicy = new CommunityItemType(1, "Application Policy");
        public static readonly CommunityItemType StoragePolicy = new CommunityItemType(2, "Storage Policy");
        public static readonly CommunityItemType NetworkPolicy = new CommunityItemType(3, "Network Policy");
        public static readonly CommunityItemType ConfigManagerPolicy = new CommunityItemType(4, "Configuration Manager Policy");
        public static readonly CommunityItemType ThreatLockerOpsPolicy = new CommunityItemType(5, "Endpoint Detect Policy");
        public static readonly CommunityItemType RemediationPolicy = new CommunityItemType(6, "Remediation Policy");
        public static readonly CommunityItemType CloudDetectPolicy = new CommunityItemType(7, "Cloud Detect Policy");

        public CommunityItemType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CommunityItemType[] All =
        {
            Any,
            ApplicationPolicy,
            StoragePolicy,
            NetworkPolicy,
            ConfigManagerPolicy,
            ThreatLockerOpsPolicy,
            RemediationPolicy,
            CloudDetectPolicy
        };

        public static CommunityItemType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CommunityItemType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
