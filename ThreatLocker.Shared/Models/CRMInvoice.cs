using System;

namespace ThreatLocker.Shared.Models
{
    public class CRMInvoice
    {
        public Guid CRMInvoiceId { get; set; }
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public string SalesEngineerEmail { get; set; }
        public string SalesEmail { get; set; }
        public string PaymentType { get; set; }
        public string PaymentId { get; set; }
        public Guid CRMInvoiceAddressId { get; set; }
        public string Total { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Reference { get; set; }
        public string RecipientName { get; set; }
        public string RecipientAddress { get; set; }
        public string RecipientCity { get; set; }
        public string RecipientState { get; set; }
        public string RecipientCountry { get; set; }
        public string RecipientZip { get; set; }
        public Guid ThreatLockerAddressId { get; set; }
        public string VATNumber { get; set; }
        public string LicenseBreakdown { get; set; }
        public string CreatedBy { get; set; }
        public string PONumber { get; set; }
    }
}
