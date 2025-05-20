using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class TicketStatus
    {
        public int TicketStatusID { get; set; }
        public string Status { get; set; }
        public int TicketStatusCategoryId { get; set; }
    }
}
