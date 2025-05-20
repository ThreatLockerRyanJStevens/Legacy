using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class EmailCampaignRecipient
    {
        public Guid EmailCampaignRecipientId { get; set; }
        public Guid EmailCampaignId { get; set; }
        public Guid UserId { get; set; }
        public bool EmailSent { get; set; }
        public DateTime? DateProcessed { get; set; }
        public int PreStatus { get; set; }
    }
}
