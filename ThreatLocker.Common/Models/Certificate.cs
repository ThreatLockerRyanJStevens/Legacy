using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class Certificate
    {
        public Guid CertificateId { get; set; }
        public Guid OrganizationId { get; set; }

        public string Sha { get; set; }
    }

    public class Cert
    {
        public string sha { get; set; }
        public string subject { get; set; }
    }
}
