using System;

namespace RulesEngine
{
    public class RuleCondition
    {
        public string PropertyName { get; set; }
        public int OperationId { get; set; }
        public string OperationName => Enum.GetName(typeof(RuleOperation), OperationId) ?? "";
        public string Value { get; set; }
        public string AppendOperator { get; set; } = "AND";
        public bool IsNegationRule { get; set; }
        public int GroupId { get; set; }
        public int GroupLevel { get; set; }
    }
}
