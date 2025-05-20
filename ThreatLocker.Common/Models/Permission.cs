using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class PermissionUser
    {
        public Guid UserId { get; set; }
        public List<Guid> Permissions { get; set; }
    }
}
