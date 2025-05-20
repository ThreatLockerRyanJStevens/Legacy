using System;

namespace ThreatLocker.Shared.Models
{
    public class TaskFile
    {
        public Guid TaskFileId { get; set; }
        public DateTime DateTime { get; set; }
        public Guid TaskId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int FileSize { get; set; }
        public string Sha256 { get; set; }
    }
}
