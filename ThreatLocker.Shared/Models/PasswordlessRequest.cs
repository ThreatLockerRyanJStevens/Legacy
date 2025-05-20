using System;

namespace ThreatLocker.Shared.Models
{
    public class PasswordlessRequest
    {
        public long PasswordlessRequestId { get; set; }

        public string CallSid { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateTime { get; set; }

        public Guid UserId { get; set; }

        public bool? Verified { get; set; }

    }
}
