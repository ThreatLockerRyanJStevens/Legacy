using System;
using ThreatLocker.Shared.Constants;

namespace ThreatLocker.Shared.Models
{
    public class OrganizationProductTrial
    {
        public Guid OrganizationProductTrialId { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int ProductStatus { get; set; }
        public DateTime TrialExpiration { get; set; }
    }
}
