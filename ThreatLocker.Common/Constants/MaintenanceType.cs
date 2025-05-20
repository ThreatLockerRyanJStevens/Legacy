using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class MaintenanceType
    {
        public static readonly MaintenanceType MonitorOnly = new MaintenanceType(1, "monitoronly");
        public static readonly MaintenanceType Installation = new MaintenanceType(2, "installation");
        public static readonly MaintenanceType Learning = new MaintenanceType(3, "learning");
        public static readonly MaintenanceType Elevation = new MaintenanceType(4, "elevation");
        public static readonly MaintenanceType LearningHashOnly = new MaintenanceType(5, "learninghashonly");
        public static readonly MaintenanceType TamperOff = new MaintenanceType(6, "tamperoff");
        public static readonly MaintenanceType Isolate = new MaintenanceType(14, "isolate");
        public static readonly MaintenanceType LockDown = new MaintenanceType(15, "lockdown");
        public static readonly MaintenanceType DisableOpsAlerts = new MaintenanceType(16, "disableopsalerts");
        public static readonly MaintenanceType NCMonitorOnly = new MaintenanceType(17, "ncmonitoronly");
        public static readonly MaintenanceType StorageMonitorOnly = new MaintenanceType(18, "storagemonitoronly");

        public MaintenanceType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public static implicit operator int(MaintenanceType type) => type.Id;

        public static readonly MaintenanceType[] All =
        {
            MonitorOnly,
            Installation,
            Learning,
            Elevation,
            LearningHashOnly,
            TamperOff,
            Isolate,
            LockDown,
            DisableOpsAlerts,
            NCMonitorOnly,
            StorageMonitorOnly
        };

        public static MaintenanceType FindByName(string name)
        {
            return All.First(x => x.Name == name);
        }

        public static MaintenanceType FindById(int id)
        {
            return All.First(x => x.Id == id);
        }
    }
}
