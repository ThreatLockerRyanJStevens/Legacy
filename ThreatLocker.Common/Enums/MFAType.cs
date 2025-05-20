using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum MFAType
    {
        [Description("None")]
        None = 0,

        [Description("SMS Code")]
        SMS = 1,

        [Description("DUO 2 Factor Authentication")]
        DUO = 2
    }
}
