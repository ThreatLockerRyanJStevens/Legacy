using System;

namespace ThreatLocker.Shared.Models
{
    public class HelpDeskTicketAssigned
    {
        public Guid HelpDeskTicketAssignedId { get; set; }

        public Guid HelpDeskTicketId { get; set; }

        public string Assignee { get; set; }

        public DateTime? DateAssigned { get; set; }

    }
}
