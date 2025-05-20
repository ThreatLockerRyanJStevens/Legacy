using System;

namespace ThreatLockerCommon.DTOs
{
    public class ApprovalRequestMfaDto
    {
        public string ChallengeSha256 { get; set; }
        public string Pin { get; set; }
    }
}
