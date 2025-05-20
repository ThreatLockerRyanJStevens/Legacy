using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class AddApplicationFiles
    {
        public bool CertValid { get; set; }
        public Guid ApplicationId { get; set; }
        public string Match { get; set; }
        public string ComputerName { get; set; }
        public string Username { get; set; }
        public string Path { get; set; } = string.Empty;
        public string CertSubject { get; set; }
        public string Hash { get; set; } = string.Empty;
        public string CertSha { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public string ProcessPath { get; set; } = string.Empty;
    }
}
