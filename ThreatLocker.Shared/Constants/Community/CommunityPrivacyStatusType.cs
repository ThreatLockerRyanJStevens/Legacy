using System.Linq;

namespace ThreatLocker.Shared.Constants.Community
{
    public class CommunityPrivacyStatusType
    {
        public static readonly CommunityPrivacyStatusType Private = new CommunityPrivacyStatusType(1, "Private");
        public static readonly CommunityPrivacyStatusType SubscriptionOnly = new CommunityPrivacyStatusType(2, "Subscription Only");
        public static readonly CommunityPrivacyStatusType Public = new CommunityPrivacyStatusType(3, "Public");

        public CommunityPrivacyStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CommunityPrivacyStatusType[] All =
        {
            Private,
            SubscriptionOnly,
            Public
        };

        public static CommunityPrivacyStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CommunityPrivacyStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
