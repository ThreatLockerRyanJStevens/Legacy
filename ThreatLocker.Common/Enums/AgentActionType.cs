using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
	public enum AgentActionType
	{
		[Description("Restart Service")]
		Restart = 1,

		[Description("Rebuild Apps Database")]
		RebuildAppsDatabase = 2,

		[Description("Rebuild RingfencedPaths Json file")]
		RebuildRingfencedPaths = 3,

		[Description("Rebuild AzureAD Database")]
		RebuildAzureADDatabase = 4,

		[Description("Isolate Computer")]
		IsolateComputer = 5,

		[Description("Unisolate Computer")]
		UnisolateComputer = 6,

		[Description("Lockdown Computer")]
		LockdownComputer = 7,

		[Description("Unlock Computer")]
		UnlockComputer = 8,

		[Description("ScreenLock Computer")]
		ScreenLockComputer = 9,

		[Description("Check For Updates")]
		CheckForUpdates = 10,

		[Description("Resolved HealthCenter Alert")]
		ResolvedHealthCenterAlert = 11,

		[Description("Rebuild Core Database")]
		RebuildCoreDatabase = 12,

		[Description("Rebuild Tags Json")]
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

		[Description("Start/Stop Remediation Service")]
		RemediationServiceState = 19,

		[Description("Delete File")]
		DeleteFile = 20,

		[Description("Perform Full Check-in")]
		PerformFullCheckin = 21,

		[Description("Remove Local Windows Admin Account from Computer")]
		RemoveLocalAdmin = 22,

		[Description("Clear the Local IP cache on the client machine that is used by NC Objects")]
		ClearLocalIPCache = 23,

		[Description("Downloads Policies for a given computer")]
		ComputerDeployPolicies = 24,

		[Description("Upload Executable File")]
		UploadExecutableFile = 25,

		[Description("Reset Ops Exclusion Database")]
		ResetOpsExclusionDatabase = 26,

		[Description("Uninstall Service")]
		Uninstall = 27,

		[Description("Install .Net 8 Runtime")]
		InstallDotNet8Runtime = 28,

		[Description("Vacuum Apps Database")]
		VacuumAppsDB = 29,

		[Description("Application Version Repair")]
		AppVersionRepair = 30,

		[Description("Rebuilds Cert Database")]
		RebuildCertDatabase = 31,

		[Description("Challenge Approval Request MFA")]
		ChallengeApprovalRequest = 32,

		[Description("Enable User Store in Tray")]
		EnableUserStore = 33,

		[Description("Disable User Store in Tray")]
		DisableUserStore = 34,

		[Description("Retrieve Agent Settings")]
		RetrieveAgentSettings = 35,

	}
}
