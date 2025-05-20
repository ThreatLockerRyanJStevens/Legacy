using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class SharePointOperationType
    {
        public static readonly SharePointOperationType FileAccessed = new SharePointOperationType("FileAccessed", ActionType.Read.Value);
        public static readonly SharePointOperationType FileCheckOutDiscarded = new SharePointOperationType("FileCheckOutDiscarded", ActionType.Read.Value);
        public static readonly SharePointOperationType FileCheckedIn = new SharePointOperationType("FileCheckedIn", ActionType.Write.Value);
        public static readonly SharePointOperationType FileCheckedOut = new SharePointOperationType("FileCheckedOut", ActionType.Write.Value);
        public static readonly SharePointOperationType FileCopied = new SharePointOperationType("FileCopied", ActionType.Write.Value);
        public static readonly SharePointOperationType FileDeleted = new SharePointOperationType("FileDeleted", ActionType.Delete.Value);
        public static readonly SharePointOperationType FileDeletedFirstStageRecycleBin = new SharePointOperationType("FileDeletedFirstStageRecycleBin", ActionType.Delete.Value);
        public static readonly SharePointOperationType FileDeletedSecondStageRecycleBin = new SharePointOperationType("FileDeletedSecondStageRecycleBin", ActionType.Delete.Value);
        public static readonly SharePointOperationType FileDownloaded = new SharePointOperationType("FileDownloaded", ActionType.Write.Value);
        public static readonly SharePointOperationType FileFetched = new SharePointOperationType("FileFetched", ActionType.Read.Value);
        public static readonly SharePointOperationType FileModified = new SharePointOperationType("FileModified", ActionType.Write.Value);
        public static readonly SharePointOperationType FileMoved = new SharePointOperationType("FileMoved", ActionType.Move.Value);
        public static readonly SharePointOperationType FilePreviewed = new SharePointOperationType("FilePreviewed", ActionType.Read.Value);
        public static readonly SharePointOperationType FileRecycled = new SharePointOperationType("FileRecycled", ActionType.Delete.Value);
        public static readonly SharePointOperationType FileRenamed = new SharePointOperationType("FileRenamed", ActionType.Write.Value);
        public static readonly SharePointOperationType FileRestored = new SharePointOperationType("FileRestored", ActionType.Write.Value);
        public static readonly SharePointOperationType FileSyncDownloadedFull = new SharePointOperationType("FileSyncDownloadedFull", ActionType.Write.Value);
        public static readonly SharePointOperationType FileSyncDownloadedPartial = new SharePointOperationType("FileSyncDownloadedPartial", ActionType.Write.Value);
        public static readonly SharePointOperationType FileSyncUploadedFull = new SharePointOperationType("FileSyncUploadedFull", ActionType.Write.Value);
        public static readonly SharePointOperationType FileSyncUploadedPartial = new SharePointOperationType("FileSyncUploadedPartial", ActionType.Write.Value);
        public static readonly SharePointOperationType FileUploaded = new SharePointOperationType("FileUploaded", ActionType.Write.Value);
        public static readonly SharePointOperationType FileViewed = new SharePointOperationType("FileViewed", ActionType.Read.Value);

        public static readonly SharePointOperationType FolderCopied = new SharePointOperationType("FolderCopied", ActionType.Write.Value);
        public static readonly SharePointOperationType FolderCreated = new SharePointOperationType("FolderCreated", ActionType.Write.Value);
        public static readonly SharePointOperationType FolderDeleted = new SharePointOperationType("FolderDeleted", ActionType.Delete.Value);
        public static readonly SharePointOperationType FolderDeletedFirstStageRecycleBin = new SharePointOperationType("FolderDeletedFirstStageRecycleBin", ActionType.Delete.Value);
        public static readonly SharePointOperationType FolderDeletedSecondStageRecycleBin = new SharePointOperationType("FolderDeletedSecondStageRecycleBin", ActionType.Delete.Value);
        public static readonly SharePointOperationType FolderModified = new SharePointOperationType("FolderModified", ActionType.Write.Value);
        public static readonly SharePointOperationType FolderMoved = new SharePointOperationType("FolderMoved", ActionType.Move.Value);
        public static readonly SharePointOperationType FolderRecycled = new SharePointOperationType("FolderRecycled", ActionType.Delete.Value);
        public static readonly SharePointOperationType FolderRenamed = new SharePointOperationType("FolderRenamed", ActionType.Write.Value);
        public static readonly SharePointOperationType FolderRestored = new SharePointOperationType("FolderRestored", ActionType.Write.Value);

        public SharePointOperationType(string value, string actionTypeValue)
        {
            Value = value;
            ActionTypeValue = actionTypeValue;
        }

        public string Value { get; set; }
        public string ActionTypeValue { get; set; }

        public static readonly SharePointOperationType[] All =
        {
            FileAccessed,
            FileCheckOutDiscarded,
            FileCheckedIn,
            FileCheckedOut,
            FileCopied,
            FileDeleted,
            FileDeletedFirstStageRecycleBin,
            FileDeletedSecondStageRecycleBin,
            FileDownloaded,
            FileFetched,
            FileModified,
            FileMoved,
            FilePreviewed,
            FileRecycled,
            FileRenamed,
            FileRestored,
            FileSyncDownloadedFull,
            FileSyncDownloadedPartial,
            FileSyncUploadedFull,
            FileSyncUploadedPartial,
            FileUploaded,
            FileViewed,
            FolderCopied,
            FolderCreated,
            FolderDeleted,
            FolderDeletedFirstStageRecycleBin,
            FolderDeletedSecondStageRecycleBin,
            FolderModified,
            FolderMoved,
            FolderRecycled,
            FolderRenamed,
            FolderRestored,
        };

        public static SharePointOperationType Find(string value)
        {
            return All.FirstOrDefault(x => x.Value.Equals(value, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}