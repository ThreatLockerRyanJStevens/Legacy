using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum ServiceAction
    {
        [Description("Restart")]
        Restart = 1,

        [Description("Reset Apps DB")]
        ResetAppsDB = 2,

        [Description("Reset Ringfenced Paths")]
        ResetRingfencedPaths = 3,

        [Description("Reset Azure AD DB")]
        ResetAzureADDatabase = 4,

        [Description("Isolate Computer")]
        IsolateComputer = 5,

        [Description("Unisolate Computer")]
        UnisolateComputer = 6,

        [Description("Lockout Computer")]
        LockoutComputer = 7,

        [Description("Unlock Computer")]
        UnlockComputer = 8,

        [Description("Screen Lock Computer")]
        ScreenLockComputer = 9,

        [Description("Check for Updates")]
        CheckForUpdates = 10,

        [Description("Resolved HealthCenter Alert")]
        ResolvedHealthCenterAlert = 11,

        [Description("Rebuild Core Database")]
        RebuildCoreDatabase = 12,

        [Description("Rebuild Tags")]
        RebuildTags = 13,

        [Description("Upload Memory Dump")]
        UploadMemoryDump = 14,

        [Description("Upload Log Files")]
        UploadLogFiles = 15,

        [Description("Upload Agent File")]
        UploadAgentFile = 16,

        [Description("Resolve Detect Actions")]
        ResolveDetectActions = 17,

        [Description("Rebuild Detect Database")]
        RebuildDetectDatabase = 18,

        [Description("Remediation Service State")]
        RemediationServiceState = 19,

        [Description("Delete File")]
        DeleteFile = 20,

        [Description("Perform Full Checkin")]
        PerformFullCheckin = 21,

        [Description("Remove Local Admin")]
        RemoveLocalAdmin = 22
    }

    public enum ServiceActionStatus
    {
        [Description("Pending")]
        Pending = 0,

        [Description("Sent")]
        Sent = 1,

        [Description("ServiceReceived")]
        ServiceReceived = 2
    }
}
