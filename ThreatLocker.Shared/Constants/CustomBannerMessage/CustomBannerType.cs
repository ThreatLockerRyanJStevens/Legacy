using System.Linq;

namespace ThreatLocker.Shared.Constants.CustomBannerMessage
{
    public class CustomBannerType
    {
        public static readonly CustomBannerType Any = new CustomBannerType(0, "Any");
        public static readonly CustomBannerType DetectAlert = new CustomBannerType(1, "Detect Alert");
        public static readonly CustomBannerType ApprovalRequest = new CustomBannerType(2, "Approval Request");
        public static readonly CustomBannerType MaintenanceMode = new CustomBannerType(3, "Enable/Disable Maintenance Mode");

        public CustomBannerType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CustomBannerType[] All =
        {
            DetectAlert,
            ApprovalRequest,
            MaintenanceMode
        };

        public static CustomBannerType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CustomBannerType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
