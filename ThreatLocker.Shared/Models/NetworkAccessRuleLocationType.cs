using System.Linq;

namespace ThreatLocker.Shared.Models
{
    public class NetworkAccessRuleLocationType
    {
        public static readonly NetworkAccessRuleLocationType IPv4 = new NetworkAccessRuleLocationType(1, "IPv4");
        public static readonly NetworkAccessRuleLocationType IPv6 = new NetworkAccessRuleLocationType(2, "IPv6");
        public static readonly NetworkAccessRuleLocationType Tag = new NetworkAccessRuleLocationType(3, "Tag");
        public static readonly NetworkAccessRuleLocationType Keyword = new NetworkAccessRuleLocationType(4, "Keyword");
        public static readonly NetworkAccessRuleLocationType Text = new NetworkAccessRuleLocationType(5, "Text");

        public NetworkAccessRuleLocationType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly NetworkAccessRuleLocationType[] All =
        {
            IPv4,
            IPv6,
            Keyword,
            Text,
            Tag
        };

        public static readonly NetworkAccessRuleLocationType[] SourceLocations =
        {
            IPv4,
            IPv6,
            Keyword,
            Tag
        };

        public static readonly NetworkAccessRuleLocationType[] DestinationLocations =
        {
            IPv4,
            IPv6,
            Text,
            Tag
        };

        public static readonly NetworkAccessRuleLocationType[] IPLocations =
        {
            IPv4,
            IPv6
        };

        //Optional Find method
        public static NetworkAccessRuleLocationType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static NetworkAccessRuleLocationType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
