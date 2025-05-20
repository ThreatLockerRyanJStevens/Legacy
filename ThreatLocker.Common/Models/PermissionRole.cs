using System;

namespace ThreatLockerCommon.Models
{
    public class PermissionRole
    {
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public Guid UserRoleId { get; set; }
        public Guid PermissionId { get; set; }
    }
}
