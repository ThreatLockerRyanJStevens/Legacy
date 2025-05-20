using System;

namespace ThreatLockerCommon.Models
{
    public class AddToApplicationQueue
    {
        public int AddToApplicationQueueId { get; set; }
        public long ActionLogId { get; set; }
        public string RequestedBy { get; set; }
        public Guid TargetApplicationId { get; set; }
        public DateTime DateAdded { get; set; }
        public int SourceTable { get; set; }
        public int OSType { get; set; }
    }
}
