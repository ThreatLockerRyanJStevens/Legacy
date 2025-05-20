using System;
using System.Collections.Generic;

namespace ThreatLocker.Shared.Models
{
    public class AzureTenant
    {
        public int Id { get; set; }
        public Guid TenantId { get; set; }
        public bool AdminConsent { get; set; }
        public bool GrantedConsent { get; set; }
        public bool SyncNestedGroups { get; set; }
        public List<AzureGroup> Groups { get; set; } = new List<AzureGroup>();
    }
}
