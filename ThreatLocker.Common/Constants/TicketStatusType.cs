using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class TicketStatusType
    {
        public static readonly TicketStatusType Open = new TicketStatusType(1, "Open");
        public static readonly TicketStatusType InProgress = new TicketStatusType(2, "In progress");
        public static readonly TicketStatusType Resolved = new TicketStatusType(3, "Resolved");
        public static readonly TicketStatusType CustomerInputRequired = new TicketStatusType(4, "Customer Input Required");
        public static readonly TicketStatusType Scheduled = new TicketStatusType(5, "Scheduled");
        public static readonly TicketStatusType UpdatedByCustomer = new TicketStatusType(6, "Updated by Customer");
        public static readonly TicketStatusType ConfirmedResolvedByCustomer = new TicketStatusType(7, "Confirmed Resolved By Customer");
        public static readonly TicketStatusType NotResolved = new TicketStatusType(8, "Not Resolved");
        public static readonly TicketStatusType ResolvedWithoutEmail = new TicketStatusType(9, "Resolved Without Email");
        public static readonly TicketStatusType ClosedNoResponse = new TicketStatusType(10, "Closed No Response");
        public static readonly TicketStatusType Spam = new TicketStatusType(11, "Spam");
        public static readonly TicketStatusType EscalatedToDevelopment = new TicketStatusType(12, "Escalated to Development");
        public static readonly TicketStatusType IssueWithReplication = new TicketStatusType(13, "Issue with Replication");
        public static readonly TicketStatusType DeployedToBetaPortal = new TicketStatusType(14, "Deployed to Beta Portal");
        public static readonly TicketStatusType Duplicated = new TicketStatusType(15, "Duplicated");


        public TicketStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TicketStatusType[] All =
        {
            Open,
            InProgress,
            Resolved,
            CustomerInputRequired,
            Scheduled,
            UpdatedByCustomer,
            ConfirmedResolvedByCustomer,
            NotResolved,
            ResolvedWithoutEmail,
            ClosedNoResponse,
            Spam,
            EscalatedToDevelopment,
            IssueWithReplication,
            DeployedToBetaPortal,
            Duplicated
        };

        public static TicketStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TicketStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
