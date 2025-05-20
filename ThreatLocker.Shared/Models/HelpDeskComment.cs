using System;

namespace ThreatLocker.Shared.Models
{
    public class HelpDeskComment
    {
        public Guid HelpDeskChatInformationId { get; set; }

        public Guid HelpDeskTicketId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Comment { get; set; }

        public bool IsCreatedByClient { get; set; }

        public bool IsViewableByCustomer { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public Guid HelpDeskCommentId { get; set; }

        public long JiraCommentId { get; set; }
    }
}
