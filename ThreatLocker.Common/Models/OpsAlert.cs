using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    // {CP} {DV-8711} Used by API and OpsPolicyMatchProcessing
    public class OpsAlert
    {
        public Guid OpsAlertId { get; set; } = Guid.NewGuid();
        public Guid OrganizationId { get; set; }
        public Guid ComputerId { get; set; }
        public Guid OpsPolicyId { get; set; }
        public DateTime OpsPolicyMatchDate { get; set; }
        public int OpsAlertSeverityId { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public int ThreatLevel { get; set; }
        public int ComputerThreatLevel { get; set; }
        public string Json { get; set; }
        public List<OpsPolicyAction> Actions { get; set; }
        public string OpsPolicyName { get; set; }
        public bool IsTLPolicy { get; set; }
        public int Occurrences { get; set; } = 1;
        public string Hostname { get; set; }
        public bool IsMonitored { get; set; }
        public int? StatusId { get; set; }
    }
}
