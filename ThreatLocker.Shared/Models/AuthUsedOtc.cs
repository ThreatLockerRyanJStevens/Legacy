using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class AuthUsedOtc
    {
        public Guid AuthUsedOtcId { get; set; }

        public Guid OrganizationId { get; set; }

        public string Code { get; set; }

        public string QrSecret { get; set; }

        public DateTime DateTime { get; set; }
    }
}
