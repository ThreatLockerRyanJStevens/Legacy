using System;

namespace ThreatLocker.Shared.Models
{
    public class HelpDeskTicketEmail
    {
        public Guid HelpDeskTicketEmailId { get; set; }

        public Guid HelpDeskTicketId { get; set; }

        public Guid EmailId { get; set; }

        public string SendGridId { get; set; }

    }
}
