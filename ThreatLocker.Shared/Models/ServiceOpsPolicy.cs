using System;
using System.Collections.Generic;
using ThreatLocker.Shared.Constants.Ops;

namespace ThreatLocker.Shared.Models
{
    public class ServiceOpsPolicy
    {
        public Guid OpsPolicyId { get; set; }
        public string PolicyName { get; set; }
        public DateTime StartDate { get; set; } = DateTime.MinValue;
        public DateTime EndDate { get; set; } = DateTime.MaxValue;
        public int OrderBy { get; set; } = 0;
        public OpsPolicyConditionMatchType OpsPolicyConditionMatchType { get; set; }
        public List<ServiceOpsPolicyCondition> OpsPolicyConditions { get; set; } = new List<ServiceOpsPolicyCondition>();
        public List<ServiceOpsPolicyAction> OpsPolicyActions { get; set; } = new List<ServiceOpsPolicyAction>();
    }

    public class ServiceOpsPolicyCondition
    {
        public OpsConditionType OpsConditionId { get; set; }
        public OpsOperatorType OpsOperatorId { get; set; }
        public OpsPolicyConditionMatchType OpsPolicyConditionMatchType { get; set; }
        public string Value { get; set; }
    }

    public class ServiceOpsPolicyAction
    {
        public OpsActionType OpsActionId { get; set; }
        public List<ServiceOpsPolicyActionDataField> OpsPolicyActionDataFields { get; set; } = new List<ServiceOpsPolicyActionDataField>();
    }

    public class ServiceOpsPolicyActionDataField
    {
        public OpsActionDataFieldType OpsActionDataFieldId { get; set; }
        public string Value { get; set; }
    }
}
