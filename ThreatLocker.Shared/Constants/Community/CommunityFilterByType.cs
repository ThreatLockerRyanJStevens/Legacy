using System.Linq;

namespace ThreatLocker.Shared.Constants.Community
{
    public class CommunityFilterByType
    {
        public static readonly CommunityFilterByType All = new CommunityFilterByType("all", "All");
        public static readonly CommunityFilterByType ThreatLocker = new CommunityFilterByType("tlocker", "ThreatLocker");
        public static readonly CommunityFilterByType MySubscriptions = new CommunityFilterByType("mysubs", "My Subscriptions");
        public static readonly CommunityFilterByType MyItems = new CommunityFilterByType("myitems", "My Items");
        public static readonly CommunityFilterByType Other = new CommunityFilterByType("other", "Other");

        public static readonly string General = "General";
        public static readonly string Subscriptions = "Subscriptions";
        public static readonly string Organizations = "Organizations";

        public CommunityFilterByType(string value, string name)
        {
            Value = value;
            Name = name;
        }

        public string Value { get; set; }
        public string Name { get; set; }

        public static readonly CommunityFilterByType[] AllTypes =
        {
            All,
            ThreatLocker,
            MySubscriptions,
            MyItems,
            Other
        };

        public static CommunityFilterByType Find(string value)
        {
            return AllTypes.FirstOrDefault(x => x.Value == value);
        }

        public static CommunityFilterByType FindByName(string name)
        {
            return AllTypes.FirstOrDefault(x => x.Name == name);
        }
    }
}
