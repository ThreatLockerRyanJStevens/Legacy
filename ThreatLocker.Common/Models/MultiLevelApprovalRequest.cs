using System;

namespace ThreatLockerCommon.Models
{
    public class MultiLevelApprovalRequest
    {
        public Guid MultiLevelApprovalRequestId { get; set; }
        public Guid ApprovalRequestId { get; set; }

        public string ApprovedBy { get; set; }
        public int ApprovedByTierLevel { get; set; }
        public Guid? TempPolicyId { get; set; }
        public Guid? PolicyId { get; set; }
        public Guid? TempApplicationId { get; set; }
        public Guid? ApplicationId { get; set; }
        public int ApprovalNumber { get; set; }
        public int StatusId { get; set; }
        public string CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
