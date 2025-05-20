using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class DenyRequest
    {
        public Guid DenyRequestId { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime DateTime { get; set; }

        public DateTime DateScheduled { get; set; }

        public int Status = 1;

        public Guid? ApplicationId { get; set; }

        public string Username { get; set; }
    }

    public class DenyRequestItem
    {
        public Guid DenyRequestItemId { get; set; }
        public Guid DenyRequestId { get; set; }
        public string ApplicationName { get; set; }
        public string Hash { get; set; }
        public string FullPath { get; set; }
        public string ProcessPath { get; set; }
        public string Cert { get; set; }
        public string Hostname { get; set; }
        public string CreatedByProcess { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime DateTime { get; set; }
        public int Status { get; set; }
    }
}
