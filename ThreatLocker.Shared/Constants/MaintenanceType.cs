using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class MaintenanceType
    {
        public static readonly MaintenanceType ApplicationControlMonitorOnly = new MaintenanceType(1, "Application Control Monitor Only");
        public static readonly MaintenanceType ApplicationControlInstallationMode = new MaintenanceType(2, "Application Control Installation Mode");
        public static readonly MaintenanceType Learning = new MaintenanceType(3, "Application Control Learning Mode");
        public static readonly MaintenanceType Elevation = new MaintenanceType(4, "Elevation Mode");
        public static readonly MaintenanceType LearningHashOnly = new MaintenanceType(5, "Learning Mode (Hash Only)");
        public static readonly MaintenanceType TamperProtectionDisabled = new MaintenanceType(6, "TamperProtectionDisabled");
        public static readonly MaintenanceType Isolation = new MaintenanceType(14, "Isolation Mode");
        public static readonly MaintenanceType Lockdown = new MaintenanceType(15, "Lockdown Mode");
        public static readonly MaintenanceType DisableOpsAlerts = new MaintenanceType(16, "Disable ThreatLocker Detect");
        public static readonly MaintenanceType NetworkControlMonitorOnly = new MaintenanceType(17, "Network Control Monitor Only"); 
        public static readonly MaintenanceType StorageControlMonitorOnly = new MaintenanceType(18, "Storage Control Monitor Only");


        public MaintenanceType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly MaintenanceType[] All =
        {
            ApplicationControlMonitorOnly,
            ApplicationControlInstallationMode,
            Learning,
            Elevation,
            LearningHashOnly,
            TamperProtectionDisabled,
            Isolation,
            Lockdown,
            DisableOpsAlerts,
            NetworkControlMonitorOnly,
            StorageControlMonitorOnly
        };

        public static readonly int[] AllMaintenanceTypeIds =
        {
            ApplicationControlMonitorOnly.Id,
            ApplicationControlInstallationMode.Id,
            Learning.Id,
            Elevation.Id,
            LearningHashOnly.Id,
            TamperProtectionDisabled.Id,
            Isolation.Id,
            Lockdown.Id,
            DisableOpsAlerts.Id,
            NetworkControlMonitorOnly.Id,
            StorageControlMonitorOnly.Id
        };

        public static readonly int[] IsolationOrLockDown =
        {
            Isolation.Id,
            Lockdown.Id
        };

        //Optional Find method
        public static MaintenanceType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static MaintenanceType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
