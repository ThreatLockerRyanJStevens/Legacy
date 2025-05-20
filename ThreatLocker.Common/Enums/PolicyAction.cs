using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum PolicyAction
    {
        [Description("Permit")]
        Permit = 1,

        [Description("Deny")]
        Deny = 2,

        [Description("Request")]
        Request = 3,

        [Description("Install Mode")]
        InstallMode = 4,

        [Description("Missing Core Files")]
        MissingCoreFiles = 5,

        [Description("RingFenced")]
        RingFenced = 6
    }
}
