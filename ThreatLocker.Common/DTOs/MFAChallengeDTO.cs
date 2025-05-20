using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.DTOs
{
    public class MFAChallengeDTO
    {
        public long MFAChallengeId { get; set; }
        public Guid ApprovalRequestId { get; set; }
        public string ChallengeSha256 { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
