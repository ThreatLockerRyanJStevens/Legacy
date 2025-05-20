using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class LearningModeSettings
    {
        public Guid ComputerId { get; set; }
        public Guid ApplicationId { get; set; }
        public int ProfilingMethod { get; set; }
        public string InstallModeSecurityLevel { get; set; }
        public int Hours { get; set; }

        public string Username { get; set; }
    }
}
