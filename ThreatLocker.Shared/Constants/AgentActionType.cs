using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ThreatLocker.Shared.Constants
{
    public class AgentActionType
    {
        public static readonly AgentActionType Restart = new AgentActionType(1, "Restart Service");
        public static readonly AgentActionType RebuildAppsDatabase = new AgentActionType(2, "Rebuild Apps Database");
        public static readonly AgentActionType RebuildRingfencedPaths = new AgentActionType(3, "Rebuild RingfencedPaths Json file");
        public static readonly AgentActionType RebuildAzureADDatabase = new AgentActionType(4, "Rebuild AzureAD Database");
        public static readonly AgentActionType IsolateComputer = new AgentActionType(5, "Isolate Computer");
        public static readonly AgentActionType UnisolateComputer = new AgentActionType(6, "Unisolate Computer");
        public static readonly AgentActionType LockdownComputer = new AgentActionType(7, "Lockdown Computer");
        public static readonly AgentActionType UnlockComputer = new AgentActionType(8, "Unlock Computer");
        public static readonly AgentActionType ScreenLockComputer = new AgentActionType(9, "ScreenLock Computer");
        public static readonly AgentActionType CheckForUpdates = new AgentActionType(10, "Check For Updates");
        public static readonly AgentActionType ResolvedHealthCenterAlert = new AgentActionType(11, "Resolved HealthCenter Alert");
        public static readonly AgentActionType RebuildCoreDatabase = new AgentActionType(12, "Rebuild Core Database");
        public static readonly AgentActionType RebuildTags = new AgentActionType(13, "Rebuild Tags Json");
        public static readonly AgentActionType UploadMemoryDump = new AgentActionType(14, "Upload Memory Dump");
        public static readonly AgentActionType UploadLogFiles = new AgentActionType(15, "Upload Log Files");
        public static readonly AgentActionType UploadAgentFile = new AgentActionType(16, "Upload Agent File");
        public static readonly AgentActionType ResolveDetectActions = new AgentActionType(17, "Resolve Detect Actions");
        public static readonly AgentActionType RebuildDetectDatabase = new AgentActionType(18, "Rebuild Detect Database");
        public static readonly AgentActionType RemediationServiceState = new AgentActionType(19, "Start/Stop Remediation Service");
        public static readonly AgentActionType DeleteFile = new AgentActionType(20, "Delete File");
        public static readonly AgentActionType PerformFullCheckin = new AgentActionType(21, "Perform Full Check-in");
        public static readonly AgentActionType RemoveLocalAdmin = new AgentActionType(22, "Remove Local Windows Admin Account from Computer");
        public static readonly AgentActionType ClearLocalIPCache = new AgentActionType(23, "Clear the Local IP cache on the client machine that is used by NC Objects");
        public static readonly AgentActionType ComputerDeployPolicies = new AgentActionType(24, "Downloads Policies for a given computer");
        public static readonly AgentActionType UploadExecutableFile = new AgentActionType(25, "Upload Executable File");
        public static readonly AgentActionType ResetOpsExclusionDatabase = new AgentActionType(26, "Reset Ops Exclusion Database");
        public static readonly AgentActionType UninstallService = new AgentActionType(27, "Uninstall Service");
        public static readonly AgentActionType InstallDotNet8Runtime = new AgentActionType(28, "Install .Net 8 Runtime");
        public static readonly AgentActionType VacuumAppsDB = new AgentActionType(29, "Vacuum Apps Database");
        public static readonly AgentActionType AppVersionRepair = new AgentActionType(30, "Application Version Repair");
        public static readonly AgentActionType RebuildCertDatabase = new AgentActionType(31, "Rebuilds Cert Database");
        public static readonly AgentActionType ChallengeApprovalRequest = new AgentActionType(32, "Challenge Approval Request", "9.7.0", "4.1.0");
        public static readonly AgentActionType PatchDeprecatedApplication = new AgentActionType(36, "Patch Deprecated Application", "10.0");
        public static readonly AgentActionType DeployWebPolicies = new AgentActionType(37, "Deploy Web Policies", "10.0");

        public AgentActionType(int id, string name, string windowsAgentMinVersion = "0.0.0", string macAgentMinVersion = "0.0.0")
        {
            Id = id;
            Name = name;
            WindowsAgentMinVersion = windowsAgentMinVersion;
            MacAgentMinVersion = macAgentMinVersion;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string WindowsAgentMinVersion { get; set; }
        public string MacAgentMinVersion { get; set; }

        public static readonly AgentActionType[] All =
        {
            Restart,
            RebuildAppsDatabase,
            RebuildRingfencedPaths,
            RebuildAzureADDatabase,
            IsolateComputer,
            UnisolateComputer,
            LockdownComputer,
            UnlockComputer,
            ScreenLockComputer,
            CheckForUpdates,
            ResolvedHealthCenterAlert,
            RebuildCoreDatabase,
            RebuildTags,
            UploadMemoryDump,
            UploadLogFiles,
            UploadAgentFile,
            ResolveDetectActions,
            RebuildDetectDatabase,
            RemediationServiceState,
            DeleteFile,
            PerformFullCheckin,
            RemoveLocalAdmin,
            ClearLocalIPCache,
            ComputerDeployPolicies,
            UploadExecutableFile,
            UninstallService,
            InstallDotNet8Runtime,
            VacuumAppsDB,
            AppVersionRepair,
            RebuildCertDatabase,
            ChallengeApprovalRequest
        };

        public static AgentActionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static AgentActionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        public static Version AgentMinVersion(int agentActionTypeId, int osType)
        {
            AgentActionType agentActionType = AgentActionType.Find(agentActionTypeId);

            string agentMinVersionString = osType switch
            {
                int os when os == OSType.Windows.Id => agentActionType.WindowsAgentMinVersion,
                int os when os == OSType.Mac.Id => agentActionType.MacAgentMinVersion,
                _ => String.Empty,
            };

            Version.TryParse(agentMinVersionString, out Version agentMinVersion);
            agentMinVersion ??= new Version();

            return agentMinVersion;
        }
    }
}
