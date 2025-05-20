using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class ApprovalSettingMaximumPermitLevel
    {
        public static readonly ApprovalSettingMaximumPermitLevel NotSet = new ApprovalSettingMaximumPermitLevel(0, "");
        public static readonly ApprovalSettingMaximumPermitLevel SingleComputer = new ApprovalSettingMaximumPermitLevel(1, "Single Computer");
        public static readonly ApprovalSettingMaximumPermitLevel ComputerGroup = new ApprovalSettingMaximumPermitLevel(2, "Computer Group");
        public static readonly ApprovalSettingMaximumPermitLevel EntireOrganization = new ApprovalSettingMaximumPermitLevel(3, "Entire Organization");

        public ApprovalSettingMaximumPermitLevel(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ApprovalSettingMaximumPermitLevel[] All =
        {
            SingleComputer,
            ComputerGroup,
            EntireOrganization
        };

        private static readonly ApprovalSettingMaximumPermitLevel[] _all =
        {
            NotSet,
            SingleComputer,
            ComputerGroup,
            EntireOrganization
        };

        // Optional Find method.
        public static ApprovalSettingMaximumPermitLevel Find(int id)
        {
            return _all.FirstOrDefault(x => x.Id == id);
        }

        // Optional Find method.
        public static ApprovalSettingMaximumPermitLevel FindByName(string name)
        {
            return _all.FirstOrDefault(x => x.Name == name);
        }
    }
}
