using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum Products
    {
        [Description("Unknown")]
        unknown = 0,

        [Description("Application Audit")]
        appaudit = 1,

        [Description("Application Control")]
        appcontrol = 2,

        [Description("Storage Audit")]
        storageaudit = 3,

        [Description("Storage Control")]
        storagecontrol = 4,

        [Description("Elevation")]
        elevation = 5,

        [Description("Cyber Hero Approvals")]
        cyberhero = 6
    }
}
