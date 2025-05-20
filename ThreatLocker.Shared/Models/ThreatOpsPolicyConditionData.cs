using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class ThreatOpsPolicyConditionData
    {
        public Guid ThreatOpsPolicyConditionDataId { get; set; }

        public Guid ThreatOpsPolicyId { get; set; }

        public int ThreatOpsConditionOperatorId { get; set; }

        public string Value { get; set; }
    }
}
