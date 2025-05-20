using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum LearnuponAction
    {
        [Description("Do not ask me again")]
        DoNotAskAgain = 0,

        [Description("Ask me next time I log on")]
        AskMeNextTime = 1,

        [Description("I would like to search for courses now")]
        Accepted = 2
    }
}