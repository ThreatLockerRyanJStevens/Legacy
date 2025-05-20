using System;

namespace ThreatLockerCommon.Models
{
    public class MaintenanceModeBulk
    {
        public Guid[] ComputerIds { get; set; }
        public int MaintenanceModeType { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public MaintenanceMode BulkMode { get; set; }
    }
}
