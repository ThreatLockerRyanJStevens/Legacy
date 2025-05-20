using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class TicketStatusCategoryType
    {
        public static readonly TicketStatusCategoryType Undefined = new TicketStatusCategoryType(0, "Undefined");
        public static readonly TicketStatusCategoryType OpenorInProgress = new TicketStatusCategoryType(1, "Open or In Progress");
        public static readonly TicketStatusCategoryType WaitingOnCustomer = new TicketStatusCategoryType(2, "Waiting On Customer");
        public static readonly TicketStatusCategoryType WaitingOnCyberHero = new TicketStatusCategoryType(3, "Waiting On CyberHero");
        public static readonly TicketStatusCategoryType PendingClosed = new TicketStatusCategoryType(4, "Pending Closed");
        public static readonly TicketStatusCategoryType Closed = new TicketStatusCategoryType(5, "Closed");
        public TicketStatusCategoryType(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
