using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ProductType
    {
        public static readonly ProductType AppAudit = new ProductType(1, "appaudit", "Application Audit");
        public static readonly ProductType AppControl = new ProductType(2, "appcontrol", "Application Control");
        public static readonly ProductType StorageAudit = new ProductType(3, "storageaudit", "Storage Audit");
        public static readonly ProductType StorageControl = new ProductType(4, "storagecontrol", "Storage Control");
        public static readonly ProductType Elevation = new ProductType(5, "elevation", "Elevation");
        public static readonly ProductType Cyberhero = new ProductType(6, "cyberhero", "Cyber Hero Approvals");
        public static readonly ProductType NetworkControl =  new ProductType(7, "networkaccesscontrol", "Network Access Control");
        public static readonly ProductType DefaultDeny =  new ProductType(8, "defaultdeny", "Default Deny");
        public static readonly ProductType Ringfencing  =  new ProductType(9, "ringfencing", "Ringfencing");
        public static readonly ProductType Platform =  new ProductType(10, "platform", "Platform");
        public static readonly ProductType CoManagedSupport =  new ProductType(11, "comanageddirectsupport", "Co-Managed Direct Support");
        public static readonly ProductType EventLogAudit =  new ProductType(12, "eventlogaudit", "Event Log Audit");
        public static readonly ProductType ThirdWall =  new ProductType(13, "thirdwall", "ThirdWall Legacy");
        public static readonly ProductType ThreatLockerOps =  new ProductType(14, "threatops", "ThreatLocker Detect");
        public static readonly ProductType ConfigurationManager  =  new ProductType(15, "configmgmt", "Manager");
        public static readonly ProductType FreeNAC =  new ProductType(16, "freenac");
        public static readonly ProductType ThreatLockerProtect =  new ProductType(17, "tlprotect", "ThreatLocker Protect");
        public static readonly ProductType CHMDetectionAndResponse =  new ProductType(18, "cyberherodetectionandresponse", "Cyber Hero MDR");
        public static readonly ProductType MiscCharges =  new ProductType(19, "misccharges", "Misc. Charges");
        public static readonly ProductType ThreatLockerUnified =  new ProductType(20, "tlunified", "ThreatLocker Unified");
        public static readonly ProductType WebControl = new ProductType(24, "webcontrol", "Web Control");
        public static readonly ProductType ThreatLockerPatchManagement =  new ProductType(23, "patchmanagement", "ThreatLocker Patch Management");

        public ProductType(int id, string name, string displayName)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
        }

        public ProductType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public static readonly ProductType[] All =
        {
            AppAudit,
            AppControl,
            CHMDetectionAndResponse,
            CoManagedSupport,
            ConfigurationManager,
            Cyberhero,
            DefaultDeny,
            Elevation,
            EventLogAudit,
            FreeNAC,
            MiscCharges,
            NetworkControl,
            Platform,
            Ringfencing,
            StorageAudit,
            StorageControl,
            ThirdWall,
            ThreatLockerOps,
            ThreatLockerProtect,
            ThreatLockerUnified,
            WebControl
        };

        public static readonly ProductType[] ThreatLockerProtectModules =
        {
            AppAudit,
            AppControl,
            ConfigurationManager,
            DefaultDeny,
            NetworkControl,
            Ringfencing
        };

        public static readonly ProductType[] ThreatLockerUnifiedModules =
        {
            AppAudit,
            AppControl,
            CHMDetectionAndResponse,
            ConfigurationManager,
            Cyberhero,
            DefaultDeny,
            Elevation,
            NetworkControl,
            Ringfencing,
            StorageAudit,
            StorageControl,
            ThreatLockerOps,
            ThreatLockerProtect
        };


        // Optional Find method.
        public static ProductType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ProductType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
