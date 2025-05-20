using System.ComponentModel;

namespace ThreatLocker.Shared.Constants.CloudDetect
{
    public enum CloudDetectMatchType
    {
        [Description("Match Any Conditions")]
        MatchAny = 0,

        [Description("Match All Conditions")]
        MatchAll = 1,
    }
}
