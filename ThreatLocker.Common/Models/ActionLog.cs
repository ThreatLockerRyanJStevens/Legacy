using System;

namespace ThreatLockerCommon.Models
{
    public class ActionLog
    {
        public long ActionLogId { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime DateTime { get; set; }
        public string Username { get; set; }
        public int ActionId { get; set; }
        public string Hash { get; set; }
        public string FullPath { get; set; }
        public string PolicyName { get; set; }
        public string ProcessPath { get; set; }
        public string ApplicationName { get; set; }
        public string OrganizationName { get; set; }
        public string ActionType { get; set; }
        public string SerialNumber { get; set; }
        public string DeviceType { get; set; }
        public string Cert { get; set; }
        public string Hostname { get; set; }
        public int? ProcessId { get; set; }
        public long Size { get; set; }
        public Guid ComputerId { get; set; }
        public Guid PolicyId { get; set; }
        public Guid ApplicationId { get; set; }
        public int? Encryption { get; set; }
        public bool? IsMonitorMode { get; set; }
        public string Notes { get; set; }
        public string Sha256Hash { get; set; }
        public string CreatedByProcess { get; set; }
    }

    public class DenyActionLog : ActionLog
    {
        public string DenyApplicationName { get; set; }
    }
}