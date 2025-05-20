using System;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class HelpDeskStatusCategoryType
    {
        public static readonly HelpDeskStatusCategoryType Open = new HelpDeskStatusCategoryType(1, "Open");
        public static readonly HelpDeskStatusCategoryType AwaitingCustomer = new HelpDeskStatusCategoryType(2, "Awaiting Customer");
        public static readonly HelpDeskStatusCategoryType AwaitingCyberhero = new HelpDeskStatusCategoryType(3, "Awaiting Cyberhero");
        public static readonly HelpDeskStatusCategoryType PendingClosed = new HelpDeskStatusCategoryType(4, "Pending Closed");
        public static readonly HelpDeskStatusCategoryType ClosedTicket = new HelpDeskStatusCategoryType(5, "Closed");
        public static readonly HelpDeskStatusCategoryType InProgress = new HelpDeskStatusCategoryType(6, "In-Progress");

        public HelpDeskStatusCategoryType(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value { get; set; }
        public string Name { get; set; }

       public static readonly HelpDeskStatusCategoryType[] All =
       {
            Open,
            AwaitingCustomer,
            AwaitingCyberhero,
            InProgress,
            PendingClosed,
            ClosedTicket
        };

        public static readonly int[] Closed =
        {
            PendingClosed.Value,
            ClosedTicket.Value
        };

        public static HelpDeskStatusCategoryType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static HelpDeskStatusCategoryType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
