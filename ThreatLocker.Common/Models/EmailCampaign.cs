using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class EmailCampaign
    {
        public Guid EmailCampaignId { get; set; } 
        public Guid UserId { get; set; }
        public long TotalContacts { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EmailContent { get; set; }
        public DateTime? DateScheduled { get; set; }
        public DateTime? DateProcessed { get; set; }
        public int Status { get; set; }
        public Guid OrganizationId { get; set; }
        public int? VariableReplaceAction { get; set; }
        public string EmailSubject { get; set; }
        public IEnumerable<EmailAttachment> Attachments { get; set; }
        public IEnumerable<EmailCampaignRecipient> Recipients { get; set; }
    }
}
