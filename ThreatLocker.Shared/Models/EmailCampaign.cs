using System;

namespace ThreatLocker.Shared.Models
{
    public class EmailCampaign
    {
        public Guid EmailCampaignId { get; set; }

        public Guid UserId { get; set; }

        public long TotalContacts { get; set; }

        public DateTime CreatedOn { get; set; }

        public string? EmailContent { get; set; }

        public DateTime? DateScheduled { get; set; }

        public DateTime? DateProcessed { get; set; }

        public int? Status { get; set; }

        public Guid OrganizationId { get; set; }

        public int? VariableReplaceAction { get; set; }

        public string? EmailSubject { get; set; }

        public Guid? UnsubscribeTypeId { get; set; }

        public string SenderName { get; set; }

        public string SenderAddress { get; set; }
    }
}
