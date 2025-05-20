using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class MaintenanceMode
    {
        public Guid MaintenanceId { get; set; }
        public string TypeDisplayName { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<string> Users { get; set; }
        public Guid ComputerId { get; set; }
        public string Application { get; set; }
        public bool PermitEnd { get; set; }
        public int AppliesToType { get; set; }
        public int MaintenanceTypeId { get; set; }
        public string AddedBy { get; set; }
        public DateTime ComputerInstallDate { get; set; }
    }

    public class MaintenanceModeDto
    {
        public Guid MaintenanceId { get; set; }
        public string Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string> Users { get; set; }
        public string Application { get; set; }
        public bool PermitEnd { get; set; }
    }

    public class TriggeredMaintenanceModeDto : MaintenanceModeDto
    {
        public string TriggeredHash { get; set; }
        public DateTime? MaxTriggeredStartDate { get; set; }
        public int TriggeredDuration { get; set; } = 1;
    }

    public class ConditionalMaintenanceModeDto : MaintenanceModeDto
    {
        /// <summary>
        /// Represents the maximum allowable time to 
        /// execute to install an application.
        /// </summary>
        public List<KeyValuePair<MaintenanceModeConditionType, string>> Conditions { get; set; } = new List<KeyValuePair<MaintenanceModeConditionType, string>>();
    }

    public enum MaintenanceModeConditionType
    {
        Path = 1,
        Process = 2
    }
}