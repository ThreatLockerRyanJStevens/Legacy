using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class OrganizationProductType
    {
        public static readonly OrganizationProductType ApplicationAudit = new OrganizationProductType(1, "appaudit", "AA", "Application Audit");
        public static readonly OrganizationProductType ApplicationControl = new OrganizationProductType(2, "appcontrol", "AC", "Application Control");
        public static readonly OrganizationProductType StorageAudit = new OrganizationProductType(3, "storageaudit", "SA", "Storage Audit");
        public static readonly OrganizationProductType StorageControl = new OrganizationProductType(4, "storagecontrol", "SC", "Storage Control");
        public static readonly OrganizationProductType Elevation = new OrganizationProductType(5, "elevation", "EV", "Elevation");
        public static readonly OrganizationProductType CyberHeroManagement = new OrganizationProductType(6, "cyberhero", "CHM", "Cyber Hero Approvals");
        public static readonly OrganizationProductType NetworkAccessControl = new OrganizationProductType(7, "networkaccesscontrol", "NAC", "Network Access Control");
        public static readonly OrganizationProductType DefaultDeny = new OrganizationProductType(8, "defaultdeny", "DD", "Default Deny");
        public static readonly OrganizationProductType Ringfencing = new OrganizationProductType(9, "ringfencing", "RF", "Ringfencing");
        public static readonly OrganizationProductType Platform = new OrganizationProductType(10, "platform", "PF", "Platform");
        public static readonly OrganizationProductType ComanagedDirectSupport = new OrganizationProductType(11, "comanageddirectsupport", "CDS", "Co-Managed Direct Support");
        public static readonly OrganizationProductType ThirdWall = new OrganizationProductType(12, "thirdwall", "TW", "ThirdWall (Legacy)");
        public static readonly OrganizationProductType ThreatLockerOps = new OrganizationProductType(14, "threatops", "TLO", "ThreatLocker Detect");
        public static readonly OrganizationProductType ConfigurationManagement = new OrganizationProductType(15, "configmgmt", "CFM", "Manager");
        public static readonly OrganizationProductType FreeNAC = new OrganizationProductType(16, "freenac", "FN", "System");
        public static readonly OrganizationProductType ThreatLockerProtect = new OrganizationProductType(17, "tlprotect", "TLP", "ThreatLocker Protect");
        public static readonly OrganizationProductType CyberHeroDetectionResponse = new OrganizationProductType(18, "cyberherodetectionandresponse", "CHDR", "Cyber Hero MDR");
        public static readonly OrganizationProductType MiscCharges = new OrganizationProductType(19, "misccharges", "MC", "Misc. Charges");
        public static readonly OrganizationProductType ThreatLockerUnified = new OrganizationProductType(20, "tlunified", "TLU", "ThreatLocker Unified");
        public static readonly OrganizationProductType ThreatLockerChoice = new OrganizationProductType(21, "tlchoice", "TLC", "ThreatLocker Choice");

        public OrganizationProductType(int id, string name, string code, string description, bool isActive = true)
        {
            Id = id;
            Name = name;
            Code = code;
            Description = description;
            IsActive = isActive;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public static readonly OrganizationProductType[] All =
        {
            ThreatLockerUnified,
            ThreatLockerProtect,
            ThreatLockerChoice,
            Platform,
            DefaultDeny,
            Ringfencing,
            StorageControl,
            Elevation,
            NetworkAccessControl,
            CyberHeroManagement,
            ComanagedDirectSupport,
            ThirdWall,
            ThreatLockerOps,
            ConfigurationManagement,
            CyberHeroDetectionResponse,
            MiscCharges,
            FreeNAC
        };

        public static readonly OrganizationProductType[] AllForAutomation =
        {
            ApplicationAudit,
            ApplicationControl,
            StorageAudit,
            Platform,
            DefaultDeny,
            Ringfencing,
            Elevation,
            StorageControl,
            NetworkAccessControl,
            CyberHeroManagement,
            ComanagedDirectSupport,
            ThirdWall,
            ThreatLockerOps,
            ConfigurationManagement,
            CyberHeroDetectionResponse,
            MiscCharges,
            ThreatLockerProtect,
            ThreatLockerUnified,
            ThreatLockerChoice,
        };

        public static readonly OrganizationProductType[] Ignore =
        {
            ThreatLockerProtect,
            Platform,
            ThirdWall,
            MiscCharges
        };

        public static readonly OrganizationProductType[] IgnorePrice =
        {
            ThreatLockerProtect,
            ConfigurationManagement,
            MiscCharges
        };

        public static readonly OrganizationProductType[] DefaultLicenses =
        {
            ThreatLockerProtect,
            Platform,
            DefaultDeny,
            Ringfencing,
            Elevation,
            StorageControl,
            NetworkAccessControl,
            ConfigurationManagement
        };

        // Obsolete; this data is dynamic via SQL table dbo.Product
        public static readonly OrganizationProductType[] ThreatLockerProtectBundle =
        {
            Platform,
            DefaultDeny,
            Ringfencing,
            NetworkAccessControl,
            ConfigurationManagement
        };

        public static readonly string[] BundleNames =
        {
            ThreatLockerProtect.Name,
            ThreatLockerUnified.Name,
            ThreatLockerChoice.Name,
        };

        public static readonly string[] BundleDescriptions =
        {
            ThreatLockerProtect.Description,
            ThreatLockerUnified.Description,
            ThreatLockerChoice.Description,
        };

        //Optional Find method
        public static OrganizationProductType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static OrganizationProductType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        //Optional Find method
        public static OrganizationProductType FindByCode(string code)
        {
            return All.FirstOrDefault(x => x.Code == code);
        }
    }
}
