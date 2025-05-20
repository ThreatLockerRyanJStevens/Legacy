using System;

namespace ThreatLocker.Shared.Models
{
    public class Payment
    {
        public Guid PaymentId { get; set; }
        public Guid OrganizationId { get; set; }
        public string PaymentType { get; set; }
        public string PaymentName { get; set; }
        public string StripePaymentId { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
        public string AddedBy { get; set; }
        public Guid QuoteId { get; set; }
        public string StripeCustomerId { get; set; }
        public string EncryptedDetails { get; set; }
        public bool Active { get; set; }
        public bool IsDefault { get; set; }
        public Guid CRMInvoiceAddressId { get; set; }
        public string PONumber { get; set; }

    }
}
