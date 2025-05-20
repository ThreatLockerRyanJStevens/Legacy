using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class ComputerLocalAdmin
    {
        public string Username { get; set; }
        public string SID { get; set; }
        public DateTime DateAdminCreated { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
