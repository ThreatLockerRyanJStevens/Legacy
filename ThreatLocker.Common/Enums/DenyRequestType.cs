using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum DenyRequestType
    {
        [Description("Standard application")]
        Application = 0,

        [Description("Ringfenced application")]
        RingfencedApplication = 1,

        [Description("Normal storage")]
        Storage = 2,

        [Description("Ringfenced storage")]
        RingfencedStorage = 3
    }
}
