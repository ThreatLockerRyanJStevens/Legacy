using System.Linq;

namespace ThreatLocker.Shared.Constants.Community
{
    public class CommunityOrderByType
    {
        public static readonly CommunityOrderByType ItemName = new CommunityOrderByType("name", "Item Name");
        public static readonly CommunityOrderByType Rating = new CommunityOrderByType("rating", "Rating");
        public static readonly CommunityOrderByType Popularity = new CommunityOrderByType("popularity", "Popularity");

        public CommunityOrderByType(string value, string name)
        {
            Value = value;
            Name = name;
        }

        public string Value { get; set; }
        public string Name { get; set; }

        public static readonly CommunityOrderByType[] All =
        {
            ItemName,
            Rating,
            Popularity
        };

        public static CommunityOrderByType Find(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static CommunityOrderByType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
