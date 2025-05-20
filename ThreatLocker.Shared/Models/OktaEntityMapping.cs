using System;

namespace ThreatLocker.Shared.Models
{
    public class OktaEntityMapping
    {
        public Guid OktaEntityMappingId { get; set; }

        public Guid IntegrationId { get; set; }

        public string OktaEntityId { get; set; }

        public Guid UserRoleId { get; set; }

        public int OktaEntityType { get; set; }

        public bool IsRemovedFromOkta { get; set; }
    }
}
