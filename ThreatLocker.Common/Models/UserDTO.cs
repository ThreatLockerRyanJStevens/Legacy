using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class UserDTO
    {
        public string Username { get; set; }
        public Guid OrganizationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
