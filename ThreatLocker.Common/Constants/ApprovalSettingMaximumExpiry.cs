using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class ApprovalSettingMaximumExpiry
    {
        public static readonly ApprovalSettingMaximumExpiry NotSet = new ApprovalSettingMaximumExpiry(0, "");
        public static readonly ApprovalSettingMaximumExpiry OneDay = new ApprovalSettingMaximumExpiry(1, "1 Day");
        public static readonly ApprovalSettingMaximumExpiry FiveDays = new ApprovalSettingMaximumExpiry(2, "5 Days");
        public static readonly ApprovalSettingMaximumExpiry OneWeek = new ApprovalSettingMaximumExpiry(3, "1 Week");
        public static readonly ApprovalSettingMaximumExpiry OneMonth = new ApprovalSettingMaximumExpiry(4, "1 Month");

        public ApprovalSettingMaximumExpiry(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ApprovalSettingMaximumExpiry[] All =
        {
            OneDay,
            FiveDays,
            OneWeek,
            OneMonth
        };

        private static readonly ApprovalSettingMaximumExpiry[] _all =
        {
            NotSet,
            OneDay,
            FiveDays,
            OneWeek,
            OneMonth
        };

        // Optional Find method.
        public static ApprovalSettingMaximumExpiry Find(int id)
        {
            return _all.FirstOrDefault(x => x.Id == id);
        }

        // Optional Find method.
        public static ApprovalSettingMaximumExpiry FindByName(string name)
        {
            return _all.FirstOrDefault(x => x.Name == name);
        }
    }
}
