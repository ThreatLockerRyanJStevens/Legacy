using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class CRMQuote
    {
        public Guid CRMQuoteId { get; set; }
        public string Name { get; set; }
        public Guid OrganizationId { get; set; }
        public string Replace { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string Status { get; set; }
        public DateTime LastStatusChanged { get; set; }
        public DateTime Expires { get; set; }
        public DateTime DateAdded { get; set; }
        public string SignatureId { get; set; }
        public bool IsSigned { get; set; }
        public string SignedDate { get; set; }
        public string SignerEmail { get; set; }
        public string SignerPosition { get; set; }
        public string PaymentType { get; set; }
        public string PaymentCountry { get; set; }
        public string SignerName { get; set; }
        public string SignatureRequestId { get; set; }
        public string VATNumber { get; set; }
    }

    public class CRMQuotePartnerBilling
    {
        public Guid CRMQuoteId { get; set; }
        public string Name { get; set; }
        public DateTime Expires { get; set; }
        public DateTime? SignedDate { get; set; }
    }

    [Serializable]
    public class CRMQuoteOption
    {
        public Guid CRMQuoteId { get; set; }
        public string Name { get; set; }
        public int BusinessClassificationTypeId { get; set; }
    }
}