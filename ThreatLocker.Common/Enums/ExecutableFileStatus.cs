using System.Collections.Generic;

namespace ThreatLockerCommon.Enums
{
    public static class ExecutableFileStatus
    {
        public enum ExecutableFileStatusEnum
        {
            Pending = 0,
            Success = 1,
            Failure = 2
        }

        public static List<ExecutableFileStatusEnum> UploadAcceptedItems
        { 
            get 
            { 
                return new List<ExecutableFileStatusEnum> { ExecutableFileStatusEnum.Success, ExecutableFileStatusEnum.Failure };
            } 
        }
    }

}
