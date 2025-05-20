using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    // CP - 2024/1/17 - No longer in use
    public class CommunityThreatOpsPolicyCategoryType
    {
        public static readonly CommunityThreatOpsPolicyCategoryType Featured = new CommunityThreatOpsPolicyCategoryType(0, "FEATURED");
        public static readonly CommunityThreatOpsPolicyCategoryType MostPopular = new CommunityThreatOpsPolicyCategoryType(1, "MOST POPULAR");
        public static readonly CommunityThreatOpsPolicyCategoryType HighestRated = new CommunityThreatOpsPolicyCategoryType(2, "HIGHEST RATED");
        public static readonly CommunityThreatOpsPolicyCategoryType MostRecent = new CommunityThreatOpsPolicyCategoryType(3, "MOST RECENT");
        public static readonly CommunityThreatOpsPolicyCategoryType MyContributors = new CommunityThreatOpsPolicyCategoryType(4, "MY CONTRIBUTORS");
        public static readonly CommunityThreatOpsPolicyCategoryType MyPolicies = new CommunityThreatOpsPolicyCategoryType(5, "MY POLICIES");

        public CommunityThreatOpsPolicyCategoryType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CommunityThreatOpsPolicyCategoryType[] All =
       {
            Featured,
            MostPopular,
            HighestRated,
            MostRecent,
            MyContributors,
            MyPolicies
       };

        public static CommunityThreatOpsPolicyCategoryType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CommunityThreatOpsPolicyCategoryType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
