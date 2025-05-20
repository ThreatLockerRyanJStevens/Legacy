using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class CrmContact
    {
        public Guid UserId { get; set; }
        public string ContactName { get; set; }
        public string EmailAddress { get; set; }
        public Guid OrganizationId { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string SalesEmail { get; set; }
        public string SalesPerson { get; set; }
        public string Country { get; set; }
        public string ReferralCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
    }
}
