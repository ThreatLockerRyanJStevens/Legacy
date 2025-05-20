using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class TicketEmail
    {
        public Guid TicketEmailId { get; set; }

        public Guid EmailId { get; set; }

        public long TicketId { get; set; }

        public string SendGridId { get; set; }

    }
}
