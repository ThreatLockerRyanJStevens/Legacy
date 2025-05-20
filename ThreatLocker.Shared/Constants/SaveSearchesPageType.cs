using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class SaveSearchesPageType
    {
        public static readonly SaveSearchesPageType UnifiedAudit = new SaveSearchesPageType(1, "Unified Audit");
        public static readonly SaveSearchesPageType Applications = new SaveSearchesPageType(2, "Applications");
        public static readonly SaveSearchesPageType ApplicationFiles = new SaveSearchesPageType(3, "Application Files");
        public static readonly SaveSearchesPageType AppLogger = new SaveSearchesPageType(4, "App Logger");
        public static readonly SaveSearchesPageType ApprovalRequests = new SaveSearchesPageType(5, "Approval Requests");
        public static readonly SaveSearchesPageType CommunityThreatOps = new SaveSearchesPageType(6, "Community ThreatOps");
        public static readonly SaveSearchesPageType CommunityUsers = new SaveSearchesPageType(7, "Community User");
        public static readonly SaveSearchesPageType ComputerCheckings = new SaveSearchesPageType(8, "Computer Checkings");
        public static readonly SaveSearchesPageType Computers = new SaveSearchesPageType(9, "Computers");
        public static readonly SaveSearchesPageType ComputerGroups = new SaveSearchesPageType(10, "Computer Groups");


        public SaveSearchesPageType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly SaveSearchesPageType[] All =
        {
            UnifiedAudit,
            Applications,
            ApplicationFiles,
            AppLogger,
            ApprovalRequests,
            CommunityThreatOps,
            CommunityUsers,
            ComputerCheckings,
            Computers,
            ComputerGroups
        };

        public static SaveSearchesPageType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static SaveSearchesPageType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
