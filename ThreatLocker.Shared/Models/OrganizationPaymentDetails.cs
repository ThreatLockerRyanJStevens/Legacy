using System;

namespace ThreatLocker.Shared.Models
{
    public class OrganizationPaymentDetails
    {
        public Guid QuoteId { get; set; }
        public Guid? CRMInvoiceAddressId { get; set; }
        public string EmailAddress { get; set; }
        public string PaymentType { get; set; }
        public string StripeCustomerId { get; set; }
        public string EncryptedDetails { get; set; }
        public string PONumber { get; set; }
        public bool IsDefault { get; set; }
        public OrganizationPaymentCreditCardDetails CreditCardDetails { get; set; } = new OrganizationPaymentCreditCardDetails();
        public OrganizationPaymentACHDetails ACHDetails { get; set; } = new OrganizationPaymentACHDetails();
        public OrganizationPaymentInvoiceDetails InvoiceDetails { get; set; } = new OrganizationPaymentInvoiceDetails();
    }

    public class OrganizationPaymentCreditCardDetails
    {
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryYear { get; set; }
        public string ExpiryMonth { get; set; }
        public string CVV { get; set; }
        public string ZipCode { get; set; }
        public string PaymentMethodId { get; set; }
        public string Source { get; set; }
    }

    public class OrganizationPaymentACHDetails
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountType { get; set; }
        public string BankId { get; set; }
        public string StripeToken { get; set; }
    }

    public class OrganizationPaymentInvoiceDetails
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string County { get; set; }
    }
}
