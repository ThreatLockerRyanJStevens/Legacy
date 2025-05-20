using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class UserRoles
    {
        public Guid UserRoleId { get; set; }
        public Guid OrganizationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastEdited { get; set; }
        public List<Guid> PermissionIds { get; set; } = new List<Guid>();
    }
}
