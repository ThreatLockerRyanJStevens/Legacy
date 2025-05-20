using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class FirewallPolicy
    {
        public Guid FirewallPolicyId { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TicketInfo { get; set; }
        public string Requestor { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }
        public int PolicyActionId { get; set; }
        public int MonitorOnlyMode { get; set; }
        public bool IsEnabled { get; set; }
        public Guid ComputerGroupId { get; set; }
        public DateTime DateTime { get; set; }
        public string PolicyActionIcon { get; set; }
        public string IsEnabledChecked { get; set; }
    }

    [Serializable]
    public class FirewallPolicyPort
    {
        public long FirewallPolicyPortId { get; set; }
        public Guid FirewallPolicyId { get; set; }
        public string Port { get; set; }
        public DateTime DateTime { get; set; }
        public string Username { get; set; }
        public int Status { get; set; }
    }

    [Serializable]
    public class FirewallPolicyTag
    {
        public long FirewallPolicyTagId { get; set; }
        public Guid FirewallPolicyId { get; set; }
        public Guid TagId { get; set; }
        public DateTime DateTime { get; set; }
        public string Username { get; set; }
        public int Status { get; set; }
    }
}
