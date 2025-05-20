using System;

namespace ThreatLocker.Shared.Models
{
    public class FacebookPost
    {
        public Guid FacebookId { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public string Picture { get; set; }

        public string Link { get; set; }

        public string FacebookInternalId { get; set; }

        public string PermalinkUrl { get; set; }
    }
}
