using System;

namespace ThreatLocker.Shared.Models
{
    public class UploadExecutableFilePayload
    {
        public Guid Id { get; set; }
        public string FilePath { get; set; }
    }
}
