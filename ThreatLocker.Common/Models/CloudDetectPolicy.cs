using System;
using System.Collections.Generic;
using System.Linq;
using ThreatLockerCommon.Enums;

namespace ThreatLockerCommon.Models
{
    // {CP} {DV-9978} Used by API and CloudDetectPolicyMatchProcessing
    public class CloudDetectPolicy
    {
        public Guid CloudDetectPolicyId { get; set; }
        public Guid OrganizationId { get; set; }
        public int CloudDetectTypeId { get; set; }
        public string Name { get; set; }
        public int? Occurrences { get; set; }
        public int? OccurrenceFrequency { get; set; }
        public List<CloudDetectPolicyCondition> AnyConditions { get; set; } = new List<CloudDetectPolicyCondition>();
        public List<CloudDetectPolicyCondition> AllConditions { get; set; } = new List<CloudDetectPolicyCondition>();
        public List<CloudDetectPolicyExclusion> Exclusions { get; set; } = new List<CloudDetectPolicyExclusion>();
        public List<CloudDetectPolicyAction> Actions { get; set; } = new List<CloudDetectPolicyAction>();
        public List<PolicySchedule> Schedule { get; set; } = new List<PolicySchedule>();
    }

    public class CloudDetectPolicyCondition
    {
        public string Condition { get; set; }
        public eOpsOperator Operator { get; set; }
        public eOpsPolicyConditionMatchType MatchType { get; set; }
        public string Value { get; set; }
    }

    public class CloudDetectPolicyExclusion
    {
        public string Condition { get; set; }
        public string Value { get; set; }
    }

    public class CloudDetectPolicyAction
    {
        public long CloudDetectPolicyActionId { get; set; }
        public eCloudDetectAction Action { get; set; }
        public List<CloudDetectPolicyActionDataField> DataFields { get; set; } = new List<CloudDetectPolicyActionDataField>();
        public bool Completed { get; set; }
    }

    public class CloudDetectPolicyActionDataField
    {
        public eCloudDetectActionDataField DataField { get; set; }
        public string Value { get; set; }
    }

    public class CloudDetectPolicyMatch
    {
        public long CloudDetectPolicyMatchId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
