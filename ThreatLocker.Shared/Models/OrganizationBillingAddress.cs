using System;

namespace ThreatLocker.Shared.Models
{
    public class OrganizationBillingAddress
    {
        public Guid OrganizationBillingAddressId { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid PartnerId { get; set; }
        public string MailingAddressName { get; set; }
        public string MailingAddressCountry { get; set; }
        public string MailingAddressState { get; set; }
        public string MailingAddressCity { get; set; }
        public string MailingAddressLine1 { get; set; }
        public string MailingAddressLine2 { get; set; }
        public string MailingAddressZipCode { get; set; }
        public bool UseMailingForBilling { get; set; }
        public int MailingAddressStatus { get; set; }
        public string BillingAddressName { get; set; }
        public string BillingAddressCountry { get; set; }
        public string BillingAddressState { get; set; }
        public string BillingAddressCity { get; set; }
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingAddressZipCode { get; set; }
        public int? BillingAddressStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
