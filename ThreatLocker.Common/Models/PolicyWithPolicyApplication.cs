using System;

namespace ThreatLockerCommon.Models
{
    public class PolicyWithPolicyApplication
    {
        public PolicyWithPolicyApplication() { }

        public PolicyWithPolicyApplication(Policy policy) 
        {
            Policy = policy;
        }

        public PolicyWithPolicyApplication(Policy policy, Application application)
        {
            Policy = policy;
            Application = application;
        }

        public PolicyWithPolicyApplication(Policy policy, Application application, Guid approvalRequestId)
        {
            Policy = policy;
            Application = application;
            ApprovalRequestId = approvalRequestId;
        }

        public Policy Policy { get; set; }
        public Application Application { get; set; }
        public Guid ApprovalRequestId { get; set; }
    }

    public class MacPolicyWithPolicyApplication
    {
        public MacPolicyWithPolicyApplication(MacPolicyModel policy)
        {
            Policy = policy;
        }

        public MacPolicyWithPolicyApplication(MacPolicyModel policy, Application application)
        {
            Policy = policy;
            Application = application;
        }

        public MacPolicyWithPolicyApplication(MacPolicyModel policy, Application application, Guid approvalRequestId)
        {
            Policy = policy;
            Application = application;
            ApprovalRequestId = approvalRequestId;
        }

        public MacPolicyModel Policy { get; set; }
        public Application Application { get; set; }
        public Guid ApprovalRequestId { get; set; }
    }
}
