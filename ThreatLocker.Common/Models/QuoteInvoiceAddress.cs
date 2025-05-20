using System;

namespace ThreatLockerCommon.Models
{
    public class QuoteInvoiceAddress
    {
        public Guid CRMInvoiceAddressId { get; set; }
        public Guid QuoteId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public bool Active { get; set; }
        public Guid? OrganizationId { get; set; }
        public bool IsDefault { get; set; }
    }
}
