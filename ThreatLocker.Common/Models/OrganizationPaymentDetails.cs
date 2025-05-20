using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class OrganizationPaymentDetails
    {
        public Guid PaymentId { get; set;}
        public Guid OrganizationId { get; set;}
        public string PaymentType { get; set; }
        public string StripePaymentId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string AddedBy { get; set; }
        public Guid? QuoteId { get; set; }
        public string StripeCustomerId { get; set; }
        public string EncryptedDetails { get; set; }
        public bool Active { get; set; }
        public bool IsDefault { get; set; }
        public Guid? CRMInvoiceAddressId { get; set; }
        public string PONumber { get; set; }
    }
}
