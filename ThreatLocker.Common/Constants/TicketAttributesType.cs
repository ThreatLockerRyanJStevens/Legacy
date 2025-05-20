using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Constants
{
    public class TicketAttributesType
    {
        public static readonly TicketAttributesType OwnerOfTicket = new TicketAttributesType(1, "Owner Of Ticket");
        public static readonly TicketAttributesType TicketStatus = new TicketAttributesType(2, "Ticket Status");
        public static readonly TicketAttributesType TicketCategory = new TicketAttributesType(3, "Ticket Category");

        public TicketAttributesType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TicketAttributesType[] All =
       {
            OwnerOfTicket,
            TicketStatus,
            TicketCategory
        };

        public static TicketAttributesType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TicketAttributesType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
