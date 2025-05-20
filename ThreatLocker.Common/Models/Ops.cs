using System;
using System.Collections.Generic;
using ThreatLockerCommon.Enums;

namespace ThreatLockerCommon.Models
{
    public class OpsPolicy
    {
        public Guid OpsPolicyId { get; set; }
        public string PolicyName { get; set; }
        public DateTime StartDate { get; set; } = DateTime.MinValue;
        public DateTime EndDate { get; set; } = DateTime.MaxValue;
        public int OrderBy { get; set; } = 0;
        public eOpsPolicyConditionMatchType OpsPolicyConditionMatchType { get; set; }
        public List<OpsPolicyCondition> OpsPolicyConditions { get; set; } = new List<OpsPolicyCondition>();
        public List<OpsPolicyAction> OpsPolicyActions { get; set; } = new List<OpsPolicyAction>();
        public List<PolicySchedule> Schedule {  get; set; } = new List<PolicySchedule>();
    }
    public class TLOpsPolicy
    {
        public long TLOpsPolicyVersion { get; set; } = 0;
        public List<OpsPolicy> TLOpsPolicies { get; set; } = new List<OpsPolicy>();
    }
    public class TLOpsPolicyV2
    {
        public long PublishedTLOpsPolicyId { get; set; } = 0;
        public Guid OpsPolicyId { get; set; }
        public OpsPolicy OpsPolicy { get; set; }
        public int TransactionType { get; set; }
        public long RelatedPublishedTLOpsPolicyId { get; set; } = 0;
    }
    public class OpsPolicyCondition
    {
        public eOpsCondition OpsConditionId { get; set; }
        public eOpsOperator OpsOperatorId { get; set; }
        public eOpsPolicyConditionMatchType OpsPolicyConditionMatchType { get; set; }
        public string Value { get; set; }
    }
    public class OpsPolicyAction
    {
        public Guid? OpsAlertId { get; set; }
        public long OpsPolicyActionId { get; set; }
        public eOpsAction OpsActionId { get; set; }
        public List<OpsPolicyActionDataField> OpsPolicyActionDataFields { get; set; } = new List<OpsPolicyActionDataField>();
    }
    public class OpsPolicyActionDataField
    {
        public eOpsActionDataField OpsActionDataFieldId { get; set; }
        public string Value { get; set; }
    }

    public class OpsPolicyMatch
    {
        public Guid OpsPolicyId { get; set; }
        public string OpsPolicyName { get; set; } = string.Empty;
        public bool IsTLPolicy { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime DateTime { get; set; }
        public int Occurrences { get; set; }
        public int ComputerThreatLevel { get; set; }
        public List<OpsPolicyAction> Actions { get; set; } = new List<OpsPolicyAction>();
        public ThreatLockerItemDTO ItemDTO { get; set; }
    }
    public class OpsPolicyExclusion
    {
        public long OpsPolicyExclusionId { get; set; }
        public Guid OpsPolicyId { get; set; }
        public int OpsConditionId { get; set; }
        public string Value { get; set; }
        public int TransactionType { get; set; }
        public long RelatedOpsPolicyExclusionId { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}