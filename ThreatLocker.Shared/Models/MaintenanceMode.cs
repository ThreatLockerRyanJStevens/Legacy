using System;

namespace ThreatLocker.Shared.Models
{
    public class MaintenanceMode
    {
        public int MaintenanceTypeId { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public string Users { get; set; }

        public Guid ComputerId { get; set; }

        public string Application { get; set; }

        public string ApplicationName { get; set; }

        public bool PermitEnd { get; set; }

        public DateTime CreatedOn { get; set; }

        public int AppliesToType { get; set; }

        public string AddedBy { get; set; }

        public Guid MaintenanceModeId { get; set; }
        public string TriggeredHash { get; set; }

        /// <summary>
        /// Represents the maximum allowable time to 
        /// execute to install an application.
        /// </summary>
        public DateTime? MaxTriggeredStartDate { get; set; }
    }
}
