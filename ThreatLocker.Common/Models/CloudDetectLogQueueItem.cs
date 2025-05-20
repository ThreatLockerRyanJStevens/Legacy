using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    // {CP} {DV-9978} Used by CloudDetectPolicyMatchProcessing and Office365LogShipper
    public class CloudDetectLogQueueItem
    {
        public long CloudDetectLogQueueId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid IntegrationId { get; set; }
        public int CloudDetectTypeId { get; set; }
        public string ObjectId { get; set; }
        public string ObjectName { get; set; }
        public int ObjectTypeId { get; set; }
        public string ObjectOrganizationId { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public string LogEntryJson { get; set; }
        public DateTime? LogEntryDate { get; set; }
        public JToken LogEntry { get; set; }
    }
}
