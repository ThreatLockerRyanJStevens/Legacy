using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class ApprovalRequest
    {
        public Guid ApprovalRequestId { get; set; }
        public DateTime DateTime { get; set; }
        public string Username { get; set; }
        public string Path { get; set; }
        public string Hash { get; set; }
        public string Signature { get; set; }
        public int StatusId { get; set; }
        public Guid ComputerId { get; set; }
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public Guid? ApplicationId { get; set; }
        public string Json { get; set; }
        public string ApprovedBy { get; set; }
        public string FileURL { get; set; }
        public string RequestorEmailAddress { get; set; }
        public string RequestorReason { get; set; }
        public string Notes { get; set; }
        public string Comments { get; set; }
        public string TicketId { get; set; }
        public string Requestor { get; set; }
        public DateTime? ActionDate { get; set; }
        public string TLInstructions { get; set; }
        public bool? SuggestCustomRule { get; set; }
        public string IgnoreReason { get; set; }
        public bool IsSelfApproval { get; set; }
    }
    public class ApprovalRequestJson
    {
        public string Sha256 { get; set; }
    }
}
