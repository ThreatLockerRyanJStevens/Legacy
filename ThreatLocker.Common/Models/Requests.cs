using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class ThreatLockerApprovalRequest
    {
        public string ApprovalRequestURL { get; set; }
        public string OrganizationDisplayName { get; set; }
        public string OrganizationIdentifier { get; set; }
        public string Hostname { get; set; }
        public DateTime DateTime { get; set; }
        public string Username { get; set; }
        public string Path { get; set; }
        public string Hash { get; set; }
        public List<ThreatLockerCert> Certificates { get; set; }
        public string RequestorEmailAddress { get; set; }
        public string RequestorReason { get; set; }
        public string SHA256 { get; set; }
        public string ActionType { get; set; }
    }
}
