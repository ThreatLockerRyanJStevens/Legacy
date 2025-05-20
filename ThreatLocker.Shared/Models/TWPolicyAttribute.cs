using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class TWPolicyAttribute
    {
        public int TWPolicyAttributeId { get; set; }

        public Guid TWPolicyId { get; set; }

        public int TWConfigurationAttributeId { get; set; }

        public string Value { get; set; }

    }

}
