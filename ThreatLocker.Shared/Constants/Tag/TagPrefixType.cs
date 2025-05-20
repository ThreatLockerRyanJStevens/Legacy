using System.Linq;

namespace ThreatLocker.Shared.Constants.Tag
{
    public class TagPrefixType
    {
        public static readonly TagPrefixType Text = new TagPrefixType(1, "Text");
        public static readonly TagPrefixType IPv4 = new TagPrefixType(2, "IPv4");
        public static readonly TagPrefixType IPv6 = new TagPrefixType(3, "IPv6");

        public TagPrefixType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TagPrefixType[] All =
        {
            Text,
            IPv4,
            IPv6
        };

        public static readonly string[] IPs =
        {
            IPv4.Name,
            IPv6.Name
        };

        public static TagPrefixType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TagPrefixType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name);
        }
    }
}
