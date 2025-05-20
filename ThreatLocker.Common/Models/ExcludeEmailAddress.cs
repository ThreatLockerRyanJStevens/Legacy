using System;

namespace ThreatLockerCommon.Models
{
    public class ExcludeEmailAddress
    {
        public Guid ExcludeEmailAddressId { get; set; }

        public string Sender { get; set; }

        public string Recipients { get; set; }

        public string Domain { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
