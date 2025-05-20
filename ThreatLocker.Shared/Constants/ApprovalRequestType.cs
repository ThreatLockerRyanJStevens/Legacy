using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ApprovalRequestType
    {
        public static readonly ApprovalRequestType Unknown = new ApprovalRequestType(0, "Unknown");
        public static readonly ApprovalRequestType Application = new ApprovalRequestType(1, "Application");
        public static readonly ApprovalRequestType Storage = new ApprovalRequestType(2, "Storage");

        public ApprovalRequestType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ApprovalRequestType[] All =
        {
            Unknown,
            Application,
            Storage
        };

        // Optional Find method.
        public static ApprovalRequestType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
