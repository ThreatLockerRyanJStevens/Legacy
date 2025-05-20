using System;

namespace ThreatLocker.Shared.Models
{
    public class HelpDeskTicketCCContacts
    {
        public Guid HelpDeskTicketCCContactId { get; set; }

        public Guid HelpDeskTicketId { get; set; }

        public string CCContact { get; set; }

        public DateTime? DateAssigned { get; set; }
    }
}
