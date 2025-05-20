using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class UserCreated
    {
        public Guid UserId { get; set; }
        public Guid OrganizationId { get; set; }
    }
}
