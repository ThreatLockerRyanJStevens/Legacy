using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    // {CP} {DV-9978} Used by API and CloudDetectPolicyMatchProcessing
    public class CloudDetectAlert
    {
        public Guid CloudDetectAlertId { get; set; } = Guid.NewGuid();
        public Guid OrganizationId { get; set; }
        public string LogEntryJson { get; set; }
        public DateTime? LogEntryDate { get; set; }
        public string ObjectId { get; set; }
        public string ObjectName { get; set; }
        public int ObjectTypeId { get; set; }
        public string ObjectOrganizationId { get; set; }
        public Guid CloudDetectPolicyId { get; set; }
        public string CloudDetectPolicyName { get; set; }
        public DateTime CloudDetectPolicyMatchDate { get; set; }
        public int AlertSeverityId { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public int ThreatLevel { get; set; }
        public int ObjectThreatLevel { get; set; }
        public bool IsTLPolicy { get; set; }
        public bool IsMonitored { get; set; }
        public int Occurrences { get; set; } = 1;
        public List<CloudDetectAlertAction> Actions { get; set; } = new List<CloudDetectAlertAction>();
        public string ActionsJson { get; set; }
    }

    public class CloudDetectAlertAction
    {
        public int CloudDetectActionId { get; set; }
        public string ActionName { get; set; }
        public string ActionValue { get; set; }
        public string ActionValueLabel { get; set; }
    }

    public class CloudDetectAlertUpdate
    {
        public string ObjectId { get; set; }
        public Guid OrganizationId { get; set; }
        public int Status { get; set; }
        public string Notes { get; set; }
        public string ModifiedBy { get; set; }
    }
}
