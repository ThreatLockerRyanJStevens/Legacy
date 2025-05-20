using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class BulkPermit
    {
        public BulkPermit()
        {
            DenyItems = new List<DenyItem>();
        }

        public string ProcessPath { get; set; }

        public string ApplicationName { get; set; }

        public List<DenyItem> DenyItems { get; set; }
    }

    [Serializable]
    public class DenyItem
    {
        public string ProcessPath { get; set; }
        public string Hash { get; set; }
        public string Cert { get; set; }
        public string FullPath { get; set; }
        public string CertSubject { get; set; } = string.Empty;
        public string ApplicationName { get; set; }
        public long ActionLogId { get; set; }
        public string CreatedByProcess { get; set; }
        public string Hostname { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid? ApplicationId { get; set; }
        public Guid? PolicyId { get; set; }
        public int BlockedProcessCount { get; set; }
        public int ComputersCount { get; set; }
        public int OrganizationCount { get; set; }
        public string ActionType { get; set; }
        public int ActionId { get; set; }
        public string PolicyName { get; set; }
        public string DisplayName { get; set; }
        public string DenyApplicationName { get; set; }
        public string Username { get; set; }
        public string Sha256Hash { get; set; }
        public Guid? ComputerId { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class DenyCenterFileHistoryRequest
    {
        public string OrganizationId { get; set; }
        public string ComputerId { get; set; }
        public string Hostname { get; set; }
        public string FullPath { get; set; }
    }

    public class DenySearchCriteria
    {
        public DateTime StartDate = DateTime.Today;
        public DateTime EndDate = DateTime.Today.AddDays(1);
        public string Policy = string.Empty;
        public string Path = string.Empty;
        public string Process = string.Empty;
        public string Hostname = string.Empty;
        public string Username = string.Empty;
        public string Cert = string.Empty;
        public string Action = "application";
        public bool IncludeChild = false;
        public bool Simulation = false;
        public long ActionLogId = 0;
    }
}
