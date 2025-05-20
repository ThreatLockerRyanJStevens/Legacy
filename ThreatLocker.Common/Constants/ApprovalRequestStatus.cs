using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class ApprovalRequestStatus
    {
        public static readonly ApprovalRequestStatus Pending = new ApprovalRequestStatus(1, "Pending");
        public static readonly ApprovalRequestStatus Approved = new ApprovalRequestStatus(4, "Approved");
        public static readonly ApprovalRequestStatus Ignored = new ApprovalRequestStatus(10, "Ignored");
        public static readonly ApprovalRequestStatus Denied = new ApprovalRequestStatus(11, "Denied");
        public static readonly ApprovalRequestStatus AddedToApplication = new ApprovalRequestStatus(12, "Added to Application");
        public static readonly ApprovalRequestStatus EscalatedToMSP = new ApprovalRequestStatus(13, "Escalated to MSP");
        public static readonly ApprovalRequestStatus PendingEscalation = new ApprovalRequestStatus(14, "Pending Escalation");
        public static readonly ApprovalRequestStatus ApprovedEscalation = new ApprovalRequestStatus(15, "Approved Escalation");
        public static readonly ApprovalRequestStatus SelfApproved = new ApprovalRequestStatus(16, "Self Approved");

        public ApprovalRequestStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
        public static readonly ApprovalRequestStatus[] All =
        {
            Pending,
            Ignored,
            Approved,
            Denied,
            AddedToApplication,
            EscalatedToMSP,
            PendingEscalation,
            ApprovedEscalation,
            SelfApproved
        };

        public static readonly ApprovalRequestStatus[] AllFilter =
        {
            Pending,
            Ignored,
            Approved,
            Denied,
            AddedToApplication,
            EscalatedToMSP
        };

        //Optional Find method
        public static ApprovalRequestStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static ApprovalRequestStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
