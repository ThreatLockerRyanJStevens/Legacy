using System;
using static ThreatLockerCommon.Enums.ExecutableFileStatus;

namespace ThreatLockerCommon.Models
{
    public class UploadRequest
    {
        public Guid UploadRequestId { get; set; }
        public ExecutableFileStatusEnum Status { get; set; }
        public string SHA256 { get; set; }
        public string ErrorMessage { get; set; }
    }
}
