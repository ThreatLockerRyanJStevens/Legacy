using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class ApprovalSetting
    {
        public Guid ApprovalSettingId { get; set; }
        public Guid OrganizationId { get; set; }
        public int TierLevel { get; set; }
        public bool SecondApprovalUserRequired { get; set; }
        public int SecondApprovalMinimumLevel { get; set; }
        public bool TopLevelRequired { get; set; }
        public bool SelfApprove { get; set; }
        public bool CreateTemporaryPolicy { get; set; }
        public int MaximumExpiryTime { get; set; }
        public int MaximumPermitLevel { get; set; }
        public bool AlertOnSubmit { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
