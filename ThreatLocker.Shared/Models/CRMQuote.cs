using System;

namespace ThreatLocker.Shared.Models
{
    public class CRMQuote
    {
        public Guid OrganizationId { get; set; }

        public string Replace { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Zip { get; set; }

        public string Status { get; set; }

        public DateTime LastStatusChanged { get; set; }

        public DateTime DateAdded { get; set; }

        public string SignatureId { get; set; }

        public bool IsSigned { get; set; }

        public string SignerEmail { get; set; }

        public string SignerPosition { get; set; }

        public string PaymentCountry { get; set; }

        public string SignerName { get; set; }

        public string SignatureRequestId { get; set; }

        public string SalesEngineerEmail { get; set; }

        public string SalesEmail { get; set; }

        public string VATNumber { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public bool? HasAdditionalTerms { get; set; }

        public string AdditionalTerms { get; set; }

        public Guid? ReplaceQuoteId { get; set; }

        public Guid AssignedOrganizationId { get; set; }
        public Guid CRMQuoteId { get; set; }

        public DateTime Expires { get; set; }

        public string Name { get; set; }

        public string OrganizationName { get; set; }

        public string TabName { get; set; }

        public DateTime? SignedDate { get; set; }
    }
}
