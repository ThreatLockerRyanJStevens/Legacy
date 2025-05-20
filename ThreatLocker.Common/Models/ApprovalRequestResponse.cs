using System;

namespace ThreatLockerCommon.Models
{
    public class ApprovalRequestResponse
    {
        public Guid ApprovalRequestId { get; set; }
        public bool IsBuiltIn { get; set; }
    }
}
