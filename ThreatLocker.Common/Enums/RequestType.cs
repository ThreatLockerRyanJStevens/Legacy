using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum RequestType
    {
        [Description("All Requests")]
        All = 0,

        [Description("Application Requests")]
        Application = 1,

        [Description("Elevation Requests")]
        Elevation = 2,

        [Description("Storage Requests")]
        Storage = 3,
    }
}
