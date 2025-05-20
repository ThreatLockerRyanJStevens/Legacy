using System;

namespace ThreatLocker.Shared.Models
{
    public class OpsPolicyAction
    {
        public long OpsPolicyActionId { get; set; }
        public Guid OpsPolicyId { get; set; }
        public int OpsActionId { get; set; }
    }
}
