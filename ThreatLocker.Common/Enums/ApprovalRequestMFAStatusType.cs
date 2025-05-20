using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum ApprovalRequestMFAStatusType
    {
        [Description("Pending")]
        Pending = 0,

        [Description("Authenticated")]
        Successful = 1,

        [Description("Unable to Authenticate")]
        Failed = 2,

        [Description("Timed Out")]
        TimedOut = 3
    }
}
