using System;

namespace ThreatLocker.Shared.Models
{
    public class StripeBankVerification
    {
        public long StripeBankVerificationId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid PaymentId { get; set; }
        public string Username { get; set; }
        public string Input { get; set; }
        public int Status { get; set; }
    }
}
