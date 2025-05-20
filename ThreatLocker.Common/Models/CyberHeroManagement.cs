using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class CyberHeroManagement
    {
        public Guid CyberHeroManagementSettingId { get; set; }
        public DateTime DateTime { get; set; }
        public Guid OrganizationId { get; set; }
        public string Instructions { get; set; }
        public List<string> EscalationEmails { get; set; } = new List<string>();
        public bool UseParent { get; set; }
    }
    public class CyberHeroTicketCollection
    {
        public List<ApprovalRequestModel> ApprovalRequests { get; set; } = new List<ApprovalRequestModel>();
        public int VirtualItemCount { get; set; }
    }
}
