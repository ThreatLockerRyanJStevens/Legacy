using System;

namespace ThreatLockerCommon.Models
{
    public class TLBaseAction
    {
        // Shared Properties.
        public string Username { get; set; } //EventData[] "SubjectUserName" ** could host name
        public DateTime DateTime { get; set; } //System.TimeCreated.SystemTime (local time)
        public string ActionType { get; set; } // = "osEventLog"; // log, eventViewer, eventLog, osLog, osEventLog
        public int ActionId { get; set; }


        // Properties needed for UA rows.
        public long Id { get; set; }
        public string Hostname { get; set; }
        public string FullPath { get; set; }
        public string PolicyName { get; set; }
        public bool IsMonitorMode { get; set; }
        public string Action { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid ComputerId { get; set; }
        public Guid PolicyId { get; set; }
    }

    //public class UATable
    //{
    //    public long ActionLogId { get; set; }
    //    public DateTime DateTime { get; set; }
    //    public string Hostname { get; set; }
    //    public string Username { get; set; }
    //    public string FullPath { get; set; }
    //    public string PolicyName { get; set; }
    //    public string ActionType { get; set; }
    //    public int ActionId { get; set; }
    //    public bool IsMonitorMode { get; set; }
    //    public string Action { get; set; }
    //    public Guid OrganizationId { get; set; }
    //}
}
