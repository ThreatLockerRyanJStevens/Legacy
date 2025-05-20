using System;

namespace ThreatLocker.Shared.Models
{
    public class HelpDeskHistory
    {
        public Guid HelpDeskHistoryId { get; set; }

        public Guid HelpDeskTicketId { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string Action { get; set; }

        public string FieldLabel { get; set; }

        public string Details { get; set; }

        public bool IsCreatedByClient { get; set; }

        public bool IsViewableByClient { get; set; }

    }
}
