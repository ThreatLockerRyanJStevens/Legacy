using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class MaintenanceModeType
    {
        public static readonly MaintenanceModeType ApplicationControlMonitorOnly = new MaintenanceModeType(1, "Application Control Monitor Only");

        public static readonly MaintenanceModeType ApplicationControlInstallationMode = new MaintenanceModeType(2, "Application Control Installation Mode");
        public static readonly MaintenanceModeType Installation = new MaintenanceModeType(2, "Installation");//It was created because of the legacy that contains in some parts this description

        public static readonly MaintenanceModeType ApplicationControlLearningMode = new MaintenanceModeType(3, "Application Control Learning Mode");
        public static readonly MaintenanceModeType ElevationMode = new MaintenanceModeType(4, "Elevation Mode");
        public static readonly MaintenanceModeType LearningModeHashOnly = new MaintenanceModeType(5, "Learning Mode Hash Only");
        public static readonly MaintenanceModeType TamperDisabled = new MaintenanceModeType(6, "TamperProtectionDisabled");

        //status that need to be used only inside action field
        public static readonly MaintenanceModeType ActionNeverEnd = new MaintenanceModeType(7, "Neverend");//special condition used only for action on maintenance date > current date + 1 year
        public static readonly MaintenanceModeType ActionSecure = new MaintenanceModeType(8, "Secure");//special condition used only for action case learning
        public static readonly MaintenanceModeType ActionLegacyLearning = new MaintenanceModeType(9, "Legacy Learning");//special condition used only for action case learning
        public static readonly MaintenanceModeType ActionUnsecured = new MaintenanceModeType(10, "Unsecured");//special condition used only for action case learning

        public static readonly MaintenanceModeType ReadyToSecure = new MaintenanceModeType(11, "ReadyToSecure");//special condition used only for action case learning
        public static readonly MaintenanceModeType NeedsReview = new MaintenanceModeType(12, "NeedsReview");//special condition used only for action case learning

        public static readonly MaintenanceModeType BaselineNotUploaded = new MaintenanceModeType(13, "BaselineNotUploaded");//special condition used to filter

        public static readonly MaintenanceModeType Isolation = new MaintenanceModeType(14, "Isolation Mode");
        public static readonly MaintenanceModeType Lockdown = new MaintenanceModeType(15, "Lockdown Mode");
        public static readonly MaintenanceModeType DisableOpsAlerts = new MaintenanceModeType(16, "Disable ThreatLocker Detect");

        public static readonly MaintenanceModeType NetworkControlMonitorOnly = new MaintenanceModeType(17, "Network Control Monitor Only");
        public static readonly MaintenanceModeType StorageControlMonitorOnly = new MaintenanceModeType(18, "Storage Control Monitor Only");
                
        public MaintenanceModeType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly MaintenanceModeType[] All =
        {
            ApplicationControlMonitorOnly,
            ApplicationControlInstallationMode,
            Installation,
            ElevationMode,
            ApplicationControlLearningMode,
            LearningModeHashOnly,
            TamperDisabled,
            ActionNeverEnd,
            ActionLegacyLearning,
            ActionUnsecured,
            ActionSecure,
            Isolation,
            Lockdown,
            DisableOpsAlerts,
            NetworkControlMonitorOnly,
            StorageControlMonitorOnly
        };

        public static readonly MaintenanceModeType[] GetAllowedToUpdate =
        {
           ActionSecure, 
           Installation,
           ApplicationControlInstallationMode,
           ApplicationControlLearningMode,
           ApplicationControlMonitorOnly,
           NetworkControlMonitorOnly,
           StorageControlMonitorOnly
        };

        public static readonly int[] GetForInstallUpdate =
        {
            ElevationMode.Id,
            TamperDisabled.Id,
            ApplicationControlInstallationMode.Id,
            Installation.Id
        };

        public static readonly int[] GetForLearningUpdate =
        {
            ApplicationControlLearningMode.Id,
            TamperDisabled.Id
        };

        public static readonly int[] GetForMonitorOnlyUpdate =
        {
            ApplicationControlMonitorOnly.Id,
            TamperDisabled.Id,
            NetworkControlMonitorOnly.Id,
            StorageControlMonitorOnly.Id
        };

        public static readonly int[] GetForUpdateSchedule =
        {
            ApplicationControlMonitorOnly.Id,
            ApplicationControlInstallationMode.Id,
            ApplicationControlLearningMode.Id,
            DisableOpsAlerts.Id,
            LearningModeHashOnly.Id
        };

        public static readonly int[] GetForMaintenanceModes =
        {
            ApplicationControlMonitorOnly.Id,
            Installation.Id,
            ElevationMode.Id,
            LearningModeHashOnly.Id,
            ApplicationControlLearningMode.Id,
            NetworkControlMonitorOnly.Id,
            StorageControlMonitorOnly.Id
        };

        public static readonly int[] GetForAlertUpdate =
        {
            Isolation.Id,
            Lockdown.Id
        };

        public static readonly int[] GetForDuplicateCheck =
        {
            NetworkControlMonitorOnly.Id,
            StorageControlMonitorOnly.Id, 
            TamperDisabled.Id,
            ElevationMode.Id,
            DisableOpsAlerts.Id
        };

        public static MaintenanceModeType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static MaintenanceModeType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
