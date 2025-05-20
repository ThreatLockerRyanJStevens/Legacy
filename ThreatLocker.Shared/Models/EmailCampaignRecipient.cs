using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class EmailCampaignRecipient
    {
        public Guid EmailCampaignRecipientId { get; set; }

        public Guid EmailCampaignId { get; set; }

        public Guid UserId { get; set; }

        public bool EmailSent { get; set; }

        public DateTime? DateProcessed { get; set; }

        public int PreStatus { get; set; }

        public string? EmailAddress { get; set; }

        public string? ReferenceId { get; set; }
    }
}
