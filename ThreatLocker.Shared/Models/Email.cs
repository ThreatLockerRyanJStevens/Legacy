using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class Email
    {
        public Guid EmailId { get; set; }

        public Guid OrganizationId { get; set; }

        public string Sender { get; set; }

        public string Recipients { get; set; }

        public string CCRecipients { get; set; }

        public string BCCRecipients { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime DateTime { get; set; }

        public int Direction { get; set; }

        public string SendGridId { get; set; }

        public int? Opens { get; set; }

        public int? Clicks { get; set; }

        public bool? IsFlagged { get; set; }

        public string UnsanitizedBody { get; set; }

        public bool? IsArchived { get; set; }

        public bool? IsPhishing { get; set; }

        public bool? IsExcluded { get; set; }

        public List<string> RecipientsArray { get; set; } //Added
        public List<string> CCRecipientsArray { get; set; } //Added

    }
}
