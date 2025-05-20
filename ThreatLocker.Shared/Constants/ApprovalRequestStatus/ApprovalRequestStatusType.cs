using System.Linq;

namespace ThreatLocker.Shared.Constants.ApprovalRequestStatus
{
    public class ApprovalRequestStatusType
    {
        public static readonly ApprovalRequestStatusType Pending = new(1, "Pending");
        public static readonly ApprovalRequestStatusType Approved = new(4, "Approved");
        public static readonly ApprovalRequestStatusType NotLearned = new(6, "Not Learned");
        public static readonly ApprovalRequestStatusType Ignored = new(10, "Ignored");
        public static readonly ApprovalRequestStatusType Denied = new(11, "Denied");
        public static readonly ApprovalRequestStatusType AddedToApplication = new(12, "Added to Application");
        public static readonly ApprovalRequestStatusType EscalatedToMSP = new(13, "Escalated to MSP");
        public static readonly ApprovalRequestStatusType PendingEscalation = new(14, "Pending Escalation");
        public static readonly ApprovalRequestStatusType ApprovedEscalation = new(15, "Approved Escalation");
        public static readonly ApprovalRequestStatusType SelfApproved = new(16, "Self-Approved");

        public ApprovalRequestStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ApprovalRequestStatusType[] All =
       {
            Pending,
            Approved,
            NotLearned,
            Ignored,
            Denied,
            AddedToApplication,
            EscalatedToMSP,
            PendingEscalation,
            ApprovedEscalation,
            SelfApproved
       };

        public static ApprovalRequestStatusType Find(int id, bool isMasterOrgUser)
        {
            var result = All.FirstOrDefault(x => x.Id == id);

            //If user is a non-master organization, show alternate naming of 'Escalated to MSP' status.
            if (result != null && result.Id == EscalatedToMSP.Id && !isMasterOrgUser) result.Name = "Escalated from the ThreatLocker Cyber Heroes";
            return result;
        }

        public static ApprovalRequestStatusType FindByName(string name, bool isMasterOrgUser)
        {
            var result = All.FirstOrDefault(x => x.Name == name);

            if (result != null && result.Id == EscalatedToMSP.Id && !isMasterOrgUser) result.Name = "Escalated from the ThreatLocker Cyber Heroes";
            return result;
        }
    }
}
