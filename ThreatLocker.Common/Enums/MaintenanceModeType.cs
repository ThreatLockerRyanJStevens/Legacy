using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum MaintenanceModeBulkType
    {
        LearningComputer = 1,
        LearningGroup = 2,
        LearningSystem = 3,
        MonitorOnly = 4,
    }

    public enum MaintenanceModeType
    {
        [Description("Monitor Only")]
        MonitorOnly = 1,

        [Description("Installation Mode")]
        Installation = 2,

        [Description("Learning Mode")]
        Learning = 3,

        [Description("Elevation Mode")]
        Elevation = 4,

        [Description("Learning Mode (Hash Only)")]
        LearningHashOnly = 5,

        [Description("Tamper Protection Disabled")]
        TamperOff = 6
    }
}
