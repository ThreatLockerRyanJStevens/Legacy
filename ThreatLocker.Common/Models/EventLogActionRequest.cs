using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class ServiceEventLogActionRequest
    {
        public Guid ComputerId { get; set; }
        public Guid OrganizationId { get; set; }
        public string Hostname { get; set; }
        public string AuthKey { get; set; }
        public List<ServiceEventLogAction> Actions { get; set; }
    }

    public class ServiceEventLogAction
    {
        public string Computer { get; set; } //System.Computer , Hostname*
        public Guid ComputerId { get; set; }
        public string EventData { get; set; }
        public long EventId { get; set; } // System.EventId
        public string Hostname { get; set; }
        public string Keywords { get; set; } //EventRecord.KeywordsDisplayNames
        public string Level { get; set; }  //EventRecord.LevelDisplayName
        public string LogName { get; set; }// System.Channel
        public string Message { get; set; }// EventRecord.Message (FormatDescription)
        public string Opcode { get; set; } //EventRecord.OpCodeDisplayName **not in xml
        public Guid OrganizationId { get; set; }
        public string Provider { get; set; }// Provider.Name
        public string TaskCategory { get; set; } //EventRecord.TaskDisplayName **not in xml
        public DateTime TimeCreated { get; set; }
        public string Username { get; set; }
    }
}
