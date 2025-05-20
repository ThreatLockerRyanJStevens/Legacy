using ThreatLockerCommon.Models;

namespace ThreatLockerCommon.DTOs
{
    public class ApprovalRequestDto
    {
        public bool SendNotification { get; set; }
        public string RequestorReason { get; set; }
        public string RequestorEmailAddress { get; set; }
        public bool IsSelfApproval { get; set; }
        public ThreatLockerAction Action { get; set; }
    }
}
