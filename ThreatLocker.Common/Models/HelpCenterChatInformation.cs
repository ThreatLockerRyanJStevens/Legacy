using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class HelpCenterChatInformation
    {
       
        public Guid ChatInformationId { get; set; }

        public long TicketId { get; set; }

        public string ChatId { get; set; }

        public string ThreadId { get; set; }

        public DateTime DateAdded { get; set; }

        public string Status { get; set; }

        public bool HasReceived { get; set; }

    }
}
