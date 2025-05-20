using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class PermitApplication
    {
        public Guid OrganizationId { get; set; }
        public Guid LoggedInOrganizationId { get; set; }
        public Guid ComputerGroupId { get; set; }
        public Guid ComputerId { get; set; }
        public int OSType { get; set; } = 1;
        public string APIUrl { get; set; }
        public string Username { get; set; }
        public string AddedFrom { get; set; }
        public string TechNotes { get; set; }
        public bool ApprovalPermission { get; set; }
        public bool TempAppCreated { get; set; }
        public int UserApprovalTierLevel { get; set; }
        public PermitFileDetails FileDetails { get; set; } = new PermitFileDetails();
        public PermitMatchingApplications MatchingApplications { get; set; } = new PermitMatchingApplications();
        public PermitRules Rules { get; set; } = new PermitRules();
        public PermitActions Actions { get; set; } = new PermitActions();
        public int PolicyExpiration { get; set; }
        public PermitElevation Elevation { get; set; } = new PermitElevation();
        public PermitPolicy Policy { get; set; } = new PermitPolicy();
        public PermitAdminNotes AdminNotes { get; set; } = new PermitAdminNotes();
        public MultiLevelApprovalRequest MultiLevel { get; set; } = new MultiLevelApprovalRequest();
        public ApprovalSetting ApprovalSetting { get; set; } = new ApprovalSetting();
        public ApprovalRequest ApprovalRequest { get; set; } = new ApprovalRequest();
    }

    public class PermitFileDetails
    {
        public string FullPath { get; set; }
        public string Hash { get; set; }
        public List<Cert> Certificates { get; set; } = new List<Cert>();
        public string ProcessName { get; set; }
        public string Hostname { get; set; }
        public string Date { get; set; }
        public string Username { get; set; }
        public string Policy { get; set; }
        public string ApplicationName { get; set; }
        public string RequestorReason { get; set; }
        public string OriginalReason { get; set; }
    }

    public class PermitMatchingApplications
    {
        public bool ToMatching { get; set; }
        public Guid MatchingAppId { get; set; }
        public string MatchingAppName { get; set; }
        public bool ToExisting { get; set; }
        public Guid ExistingAppId { get; set; }
        public string ExistingAppName { get; set; }
        public bool ToNew { get; set; }
        public string NewAppName { get; set; }
    }

    public class PermitRules
    {
        public int RuleId { get; set; }
        public bool ChooseManualOptions { get; set; }
        public ManualOptions ManualOptions { get; set; } = new ManualOptions();
    }

    public class ManualOptions
    {
        public bool IsHash { get; set; }
        public string Hash { get; set; }
        public bool IsCertificate { get; set; }
        public string Certificate { get; set; }
        public bool IsPath { get; set; }
        public string Path { get; set; }
        public bool IsProcess { get; set; }
        public string Process { get; set; }
        public bool IsCreatedBy { get; set; }
        public string CreatedBy { get; set; }
        public string OriginalCreatedBy { get; set; }
    }

    public class PermitActions
    {
        public int ActionId { get; set; }
        public bool Ringfence { get; set; }
        public bool RestrictNetwork { get; set; }
        public bool BlockRegistryWrites { get; set; }
        public bool BlockProtectedFiles { get; set; }
        public bool BlockHighRiskApps { get; set; }
        public HighRiskApps HighRiskApps { get; set; } = new HighRiskApps();
    }

    public class HighRiskApps
    {
        public bool PowerShell { get; set; }
        public bool CommandPrompt { get; set; }
        public bool RunDLL { get; set; }
        public bool RegSRV { get; set; }
        public bool WscriptCscript { get; set; }
    }

    public class PermitElevation
    {
        public int ElevationStatus { get; set; }
        public int ElevationExpiration { get; set; }
        public bool MoreElevation { get; set; }
    }

    public class PermitPolicy
    {
        public bool ToEntireOrganization { get; set; }
        public Guid OrganizationId { get; set; }
        public bool ToComputerGroup { get; set; }
        public Guid ComputerGroupId { get; set; }
        public bool ToComputer { get; set; }
        public Guid ComputerId { get; set; }
    }

    public class PermitAdminNotes
    {
        public string Ticket { get; set; }
        public string RequestorEmail { get; set; }
        public string Comments { get; set; }
    }
}
