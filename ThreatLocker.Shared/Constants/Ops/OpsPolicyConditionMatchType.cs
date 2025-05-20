using System.ComponentModel;

namespace ThreatLocker.Shared.Constants.Ops
{
    public enum OpsPolicyConditionMatchType
    {
        [Description("Match Any Conditions")]
        MatchAny = 0,

        [Description("Match All Conditions")]
        MatchAll = 1,

        [Description("Match Combination")]
        MatchCombination = 3
    }
}
