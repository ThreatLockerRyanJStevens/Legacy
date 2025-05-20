using System;

namespace ThreatLocker.Shared.Models
{
    public class LinkedAccountQueue
    {
        public string Username { get; set; }

        public int Timeout { get; set; }

        public Guid LinkedAccountId { get; set; }

        public string Nonce { get; set; }

        public string Identifier { get; set; }

        public long LinkedAccountQueueId { get; set; }

        public DateTime DateAdded { get; set; }

        public string IpAddress { get; set; }

    }
}
