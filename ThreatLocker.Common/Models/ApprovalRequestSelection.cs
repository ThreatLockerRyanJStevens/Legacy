using System;

namespace ThreatLockerCommon.Models
{
    public class ApprovalRequestSelection
    {
        public Guid ApprovalRequestId { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime DateTime { get; set; }
        public string ApplicationOption { get; set; }
        public string ApplicationSelectedApplication { get; set; }
        public string ApplicationNewApplicationName { get; set; }
        public string RuleOption { get; set; }
        public string RuleManualOptions { get; set; }
        public string RuleManualHash { get; set; }
        public string RuleManualCert { get; set; }
        public string RuleManualPath { get; set; }
        public string RuleManualProcess { get; set; }
        public string RuleManualCreatedby { get; set; }
        public string ActionOption { get; set; }
        public string ActionRingFencingOption { get; set; }
        public string ActionRingFencingBlockApplications { get; set; }
        public string PolicyExpirationOption { get; set; }
        public string ElevationExpirationOption { get; set; }
        public string PolicyOption { get; set; }
        public string PolicySelectedComputerGroup { get; set; }
        public string NotesTicket { get; set; }
        public string NotesRequestor { get; set; }
        public string NotesComments { get; set; }
        public string TechnicianApprovalTechNotes { get; set; }
    }
}
