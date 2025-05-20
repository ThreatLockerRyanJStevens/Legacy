using System;

namespace ThreatLocker.Shared.Models
{
    public class ThreatOpsPolicyActionData
    {
        public Guid ThreatOpsPolicyActionDataId { get; set; }

        public Guid ThreatOpsPolicyId { get; set; }

        public int ThreatOpsActionDataFieldId { get; set; }

        public string Value { get; set; }

        public int? ActionNr { get; set; }
    }
}
