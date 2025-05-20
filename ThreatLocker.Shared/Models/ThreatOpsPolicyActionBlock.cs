using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class ThreatOpsPolicyActionBlock
    {
        public Guid ThreatOpsPolicyActionBlockId { get; set; }

        public Guid ThreatOpsPolicyId { get; set; }

        public int? ActionIndex { get; set; }
    }
}
