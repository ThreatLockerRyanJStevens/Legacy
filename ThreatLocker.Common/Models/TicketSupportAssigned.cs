using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class TicketSupportAssigned
    {
        public long TicketSupportAssignedID { get; set; }

        public Guid UserID { get; set; }
        public string TicketNumber { get; set; }
        public DateTime DateAssigned { get; set; }

        public string EmailAddress { get; set; }


        // Can Be Deleted after helpdesk goes live.
        public long ID { get; set; }
        public Guid AssidnedID { get; set; }
        public string TicketNo { get; set; }
        public DateTime DateAssignd { get; set; }
    }
}
