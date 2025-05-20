using System;

namespace ThreatLockerCommon.Models
{
    public class Payment
    {
        public Guid PaymentId { get; set; }
        public Guid OrganizationId { get; set; }
        public string PaymentType { get; set; }
        public string StripePaymentId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string AddedBy { get; set; }
        public Guid? QuoteId { get; set; }
        public string StripeCustomerId { get; set; }
    }
}
