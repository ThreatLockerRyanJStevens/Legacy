using System.Linq;

namespace ThreatLocker.Shared.Constants.AgentAction
{
    public class AgentActionType
    {
        public static readonly AgentActionType Restart = new AgentActionType(1, "Restart");
        public static readonly AgentActionType ResetAppsDB = new AgentActionType(2, "Reset Apps DB");
        public static readonly AgentActionType ResetRingfencedPaths = new AgentActionType(3, "Reset Ringfenced Paths");
        public static readonly AgentActionType ResetAzureADDatabase = new AgentActionType(4, "Reset Azure AD DB");
        public static readonly AgentActionType IsolateComputer = new AgentActionType(5, "Isolate Computer");
        public static readonly AgentActionType UnisolateComputer = new AgentActionType(6, "Unisolate Computer");
        public static readonly AgentActionType LockoutComputer = new AgentActionType(7, "Lockout Computer");
        public static readonly AgentActionType UnlockComputer = new AgentActionType(8, "Unlock Computer");
        public static readonly AgentActionType ScreenLockComputer = new AgentActionType(9, "Screen Lock Computer");
        public static readonly AgentActionType CheckForUpdates = new AgentActionType(10, "Check for Updates");
        public static readonly AgentActionType ResolvedHealthCenterAlert = new AgentActionType(11, "Resolved Health Center Alert");
        //DV-6656 - Item 12 - Error on redownload core - it was missing constant definitions
        public static readonly AgentActionType RebuildCoreDatabase = new AgentActionType(12, "Rebuild Core Database");
        public static readonly AgentActionType RebuildTags = new AgentActionType(13, "Rebuild Tags");
        public static readonly AgentActionType UploadMemoryDump = new AgentActionType(14, "Upload Memory Dump");
        public static readonly AgentActionType UploadLogFiles = new AgentActionType(15, "Upload Log Files");
        public static readonly AgentActionType UploadAgentFile = new AgentActionType(16, "Upload Agent File");
        public static readonly AgentActionType ResolveOpsActions = new AgentActionType(17, "Resolve ThreatLocker Detect Actions");
        public static readonly AgentActionType RebuildOpsDatabase = new AgentActionType(18, "Rebuild ThreatLocker Detect Database");
        public static readonly AgentActionType RemediationServiceState = new AgentActionType(19, "Remediation Service State");
        public static readonly AgentActionType DeleteFile = new AgentActionType(20, "Delete File");
        public static readonly AgentActionType PerformFullCheckin = new AgentActionType(21, "Perform Full Checkin");
        public static readonly AgentActionType RemoveLocalAdmin = new AgentActionType(22, "Remove Local Admin");
        public static readonly AgentActionType ClearLocalIPCache = new AgentActionType(23, "Clear the Local IP cache on the client machine that is used by NC Objects");
        public static readonly AgentActionType UploadExecutableFile = new AgentActionType(25, "Upload Executable File");

        public AgentActionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly AgentActionType[] All =
        {
            Restart,
            ResetAppsDB,
            ResetRingfencedPaths,
            ResetAzureADDatabase,
            IsolateComputer,
            UnisolateComputer,
            LockoutComputer,
            UnlockComputer,
            ScreenLockComputer,
            CheckForUpdates,
            ResolvedHealthCenterAlert,
            RebuildCoreDatabase,
            RebuildTags,
            UploadMemoryDump,
            UploadLogFiles,
            UploadAgentFile,
            ResolveOpsActions,
            RemediationServiceState,
            DeleteFile,
            RemoveLocalAdmin,
            ClearLocalIPCache,
            UploadExecutableFile
        };

        public static AgentActionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static AgentActionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        public static int GetInverseTypeId(int id)
        {
            int agetnActionStatus = 0;

            if (id == IsolateComputer.Id)
            {
                agetnActionStatus = UnisolateComputer.Id;
            }
            else if (id == UnisolateComputer.Id)
            {
                agetnActionStatus = IsolateComputer.Id;
            }
            else if (id == LockoutComputer.Id)
            {
                agetnActionStatus = UnlockComputer.Id;
            }
            else if (id == UnlockComputer.Id)
            {
                agetnActionStatus = LockoutComputer.Id;
            }

            return agetnActionStatus;
        }
    }
}
