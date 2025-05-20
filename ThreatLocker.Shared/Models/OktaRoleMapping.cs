using System;
using System.Collections.Generic;

namespace ThreatLocker.Shared.Models
{
    public class OktaRoleMapping
    {
        public Guid OktaRoleMappingId { get; set; }

        public Guid IntegrationId { get; set; }

        public string OktaRoleId { get; set; }

        public string OktaName { get; set; }

        public Guid UserRoleId { get; set; }

        public List<UserRoles>? UserRoles { get; set; }
    }
}
