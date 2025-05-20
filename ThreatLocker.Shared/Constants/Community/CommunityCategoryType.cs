using System.Linq;

namespace ThreatLocker.Shared.Constants.Community
{
    public class CommunityCategoryType
    {
        public static readonly CommunityCategoryType None = new CommunityCategoryType(0, "None");
        public static readonly CommunityCategoryType Featured = new CommunityCategoryType(1, "Featured");
        public static readonly CommunityCategoryType MostPopular = new CommunityCategoryType(2, "Most Popular");
        public static readonly CommunityCategoryType HighestRated = new CommunityCategoryType(3, "Highest Rated");
        public static readonly CommunityCategoryType MostRecent = new CommunityCategoryType(4, "Most Recent");
        public static readonly CommunityCategoryType MySubscriptions = new CommunityCategoryType(5, "My Subscriptions");
        public static readonly CommunityCategoryType MyItems = new CommunityCategoryType(6, "My Items");

        public CommunityCategoryType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CommunityCategoryType[] All =
        {
            None,
            Featured,
            MostPopular,
            HighestRated,
            MostRecent,
            MySubscriptions,
            MyItems
        };

        public static CommunityCategoryType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CommunityCategoryType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
