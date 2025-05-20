using System;

namespace ThreatLocker.Shared.Models
{
    public class FileDeletionHistory
    {
        public long FileDeletionHistoryId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid ComputerId { get; set; }
        public string FullPath { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestedBy { get; set; }
        public string ActionLogJson { get; set; }
    }
}
