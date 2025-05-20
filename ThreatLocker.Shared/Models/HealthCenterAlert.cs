using System;

namespace ThreatLocker.Shared.Models
{
    public class HealthCenterAlert
    {
        public Guid HealthCenterAlertId { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime DateTime { get; set; }

        public string Severity { get; set; }

        public string Summary { get; set; }

        public string Detail { get; set; }

        public bool? IsResolved { get; set; }

        public string ResolvedBy { get; set; }

        public DateTime? ResolvedDate { get; set; }

        public Guid? ThreatOpsPolicyId { get; set; }

        public Guid? ComputerId { get; set; }

        public string? HostName { get; set; }
        
        public int? ThreatLevel { get; set; }
    }   
}
