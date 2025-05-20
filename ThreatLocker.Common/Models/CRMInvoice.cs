using System;

namespace ThreatLockerCommon.Models
{
    public class CRMInvoice
    {
        public Guid CRMInvoiceId { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public string SalesEngineerEmail { get; set; }
        public string SalesEmail { get; set; }
        public string PaymentType { get; set; }
        public Guid PaymentId { get; set; }
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
        public Guid? ThreatLockerAddressId { get; set; }
        public string VATNumber { get; set; }
        public string LicenseBreakdown { get; set; }
    }

    public class CRMInvoiceItem
    {
        public Guid CRMInvoiceItemId { get; set; }
        public Guid CRMInvoiceId { get; set; }
        public DateTime LicenseStartDate { get; set; }
        public int LicenseTerm { get; set; }
        public string Product { get; set; }
        public int TotalLicenses { get; set; }
        public int CreditedLicenses { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Tax { get; set; }
        public int Status { get; set; }
        public string Currency { get; set; }
        public Guid CRMQuoteId { get; set; }
        public Guid CRMQuoteItemId { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class CRMInvoicePartnerBilling
    {
        public Guid CRMInvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public int Status { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Total { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal AmountOutstanding 
        {
            get
            {
                return Total - AmountPaid;
            } 
        }
        public string Currency { get; set; }
    }

    public class InvoiceTotal
    {
        public string Currency { get; set; }
        public decimal Value { get; set; }
    }
}
