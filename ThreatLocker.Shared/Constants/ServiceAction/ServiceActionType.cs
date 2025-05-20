using System.Linq;

namespace ThreatLocker.Shared.Constants.ServiceAction
{
    public class ServiceActionType
    {
        public static readonly ServiceActionType Restart = new(1, "Restart");
        public static readonly ServiceActionType ResetAppsDB = new(2, "Reset Apps DB");
        public static readonly ServiceActionType ResetRingfencedPaths = new(3, "Reset Ringfenced Paths");
        public static readonly ServiceActionType ResetAzureADDatabase = new(4, "Reset Azure AD DB");
        public static readonly ServiceActionType IsolateComputer = new(5, "Isolate Computer");
        public static readonly ServiceActionType UnisolateComputer = new(6, "Unisolate Computer");
        public static readonly ServiceActionType LockoutComputer = new(7, "Lockout Computer");
        public static readonly ServiceActionType UnlockComputer = new(8, "Unlock Computer");
        public static readonly ServiceActionType ScreenLockComputer = new(9, "Screen Lock Computer");
        public static readonly ServiceActionType CheckForUpdates = new(10, "Check for Updates");
        public static readonly ServiceActionType ResolvedHealthCenterAlert = new(11, "Resolved Health Center Alert");
        //DV-6656 - Item 12 - Error on redownload core - it was missing constant definitions
        public static readonly ServiceActionType RebuildCoreDatabase = new(12, "Rebuild Core Database");
        public static readonly ServiceActionType RebuildTags = new(13, "Rebuild Tags");
        public static readonly ServiceActionType UploadMemoryDump = new(14, "Upload Memory Dump");
        public static readonly ServiceActionType UploadLogFiles = new(15, "Upload Log Files");
        public static readonly ServiceActionType UploadAgentFile = new(16, "Upload Agent File");
        public static readonly ServiceActionType ResolveOpsActions = new(17, "Resolve ThreatLocker Detect Actions");
        public static readonly ServiceActionType RebuildOpsDatabase = new(18, "Rebuild ThreatLocker Detect Database");
        public static readonly ServiceActionType RemediationServiceState = new(19, "Remediation Service State");
        public static readonly ServiceActionType DeleteFile = new(20, "Delete File");
        public static readonly ServiceActionType PerformFullCheckin = new(21, "Perform Full Checkin");
        public static readonly ServiceActionType RemoveLocalAdmin = new(22, "Remove Local Admin");

        public ServiceActionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ServiceActionType[] All =
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
        };

        public static ServiceActionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ServiceActionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        public static int GetInverseTypeId(int id)
        {
            int serviceActionStatus = 0;

            if (id == IsolateComputer.Id)
            {
                serviceActionStatus = UnisolateComputer.Id;
            }
            else if (id == UnisolateComputer.Id)
            {
                serviceActionStatus = IsolateComputer.Id;
            }
            else if (id == LockoutComputer.Id)
            {
                serviceActionStatus = UnlockComputer.Id;
            }
            else if (id == UnlockComputer.Id)
            {
                serviceActionStatus = LockoutComputer.Id;
            }

            return serviceActionStatus;
        }
    }
}
