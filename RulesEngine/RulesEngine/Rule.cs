namespace RulesEngine
{
    public class Rule
    {
        public long RuleId { get; set; }
        public int SortOrder { get; set; }
        public string RuleEvaluation { get; set; }
        public RuleCondition[] Conditions { get; set; }
        public string ReturnValueMethod { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
    }
}
