using System;

namespace ThreatLocker.Shared.Models
{
    public class HelpDeskChatInformation
    {
        public Guid HelpDeskChatInformationId { get; set; }

        public Guid HelpDeskTicketId { get; set; }

        public string ChatId { get; set; }

        public string ThreadId { get; set; }

        public DateTime DateAdded { get; set; }

        public string Status { get; set; }

        public bool? HasReceived { get; set; }

    }
}
