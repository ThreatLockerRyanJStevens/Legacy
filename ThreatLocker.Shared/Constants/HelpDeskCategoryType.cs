using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HelpDeskCategoryType
    {
        public static readonly HelpDeskCategoryType GeneralSupport = new HelpDeskCategoryType(1, "General Support");
        public static readonly HelpDeskCategoryType PotentialBug = new HelpDeskCategoryType(2, "Potential Bug");
        public static readonly HelpDeskCategoryType NewBuildinRequest = new HelpDeskCategoryType(3, "New Built in Request");
        public static readonly HelpDeskCategoryType NewFeatureRequest = new HelpDeskCategoryType(4, "New Feature Request");
        public static readonly HelpDeskCategoryType NewCustomReportRequest = new HelpDeskCategoryType(5, "New Custom Report Request");
        public static readonly HelpDeskCategoryType InternalIT = new HelpDeskCategoryType(6, "Internal IT");
        public static readonly HelpDeskCategoryType Infrastructure = new HelpDeskCategoryType(7, "Infrastructure");
        public static readonly HelpDeskCategoryType AppTeam = new HelpDeskCategoryType(9, "App Team");
        public static readonly HelpDeskCategoryType SIP = new HelpDeskCategoryType(10, "SIP Investigation (DO NOT USE)");
        public static readonly HelpDeskCategoryType QA = new HelpDeskCategoryType(11, "QA");
        public static readonly HelpDeskCategoryType BetaParticipation = new HelpDeskCategoryType(12, "Beta Participation");
        public static readonly HelpDeskCategoryType University = new HelpDeskCategoryType(13, "University");
        public static readonly HelpDeskCategoryType Marketing = new HelpDeskCategoryType(16, "Marketing");
        public static readonly HelpDeskCategoryType TLDetect = new HelpDeskCategoryType(17, "TLDetect");
        public static readonly HelpDeskCategoryType ConfigurationManager = new HelpDeskCategoryType(18, "Configuration Manager");
        public static readonly HelpDeskCategoryType Legal = new HelpDeskCategoryType(19, "Legal");
        public static readonly HelpDeskCategoryType BuiltinPending = new HelpDeskCategoryType(20, "Built-in Pending");
        public static readonly HelpDeskCategoryType HealthReportRequests = new HelpDeskCategoryType(21, "Health Report Requests");
        public static readonly HelpDeskCategoryType INFSystems = new HelpDeskCategoryType(22, "INF Systems");
        public static readonly HelpDeskCategoryType INFDBA = new HelpDeskCategoryType(23, "INF DBA (Do NOT USE)");
        public static readonly HelpDeskCategoryType VendorRequest = new HelpDeskCategoryType(24, "Vendor Request");
        public static readonly HelpDeskCategoryType Builds = new HelpDeskCategoryType(26, "Builds");
        public static readonly HelpDeskCategoryType ComplianceQuestionnaires = new HelpDeskCategoryType(27, "Compliance Questionnaires");
        public static readonly HelpDeskCategoryType ProductResearch = new HelpDeskCategoryType(28, "Product Research");
        public static readonly HelpDeskCategoryType Reports = new HelpDeskCategoryType(29, "Reports");
        public static readonly HelpDeskCategoryType FedRAMP = new HelpDeskCategoryType(30, "FedRAMP");
        public static readonly HelpDeskCategoryType MicrosoftTeams = new HelpDeskCategoryType(31, "Microsoft Teams");
        public static readonly HelpDeskCategoryType INTOffboarding = new HelpDeskCategoryType(32, "INT IT Offboarding");
        public static readonly HelpDeskCategoryType INTNewHires = new HelpDeskCategoryType(33, "INT IT New Hires");
        

        public HelpDeskCategoryType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

        public static readonly HelpDeskCategoryType[] All =
       {
            GeneralSupport,
            PotentialBug,
            NewBuildinRequest,
            NewFeatureRequest,
            NewCustomReportRequest
        };

        public static HelpDeskCategoryType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static HelpDeskCategoryType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
