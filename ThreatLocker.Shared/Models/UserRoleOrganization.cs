using System;

namespace ThreatLocker.Shared.Models
{
    public class UserRoleOrganization
    {
        public Guid UserId { get; set; }

        public Guid UserRoleId { get; set; }

        public Guid OrganizationId { get; set; }

    }
}
