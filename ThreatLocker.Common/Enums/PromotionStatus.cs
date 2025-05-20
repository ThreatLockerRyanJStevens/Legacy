using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum PromotionStatus
    {
        [Description("Disabled")]
        Disabled = 0,

        [Description("Active")]
        Active = 1,

        [Description("Accepted")]
        Accepted = 3,

        [Description("Declined")]
        Declined = 2,

        [Description("Ask Again")]
        AskAgain = 4
    }
}
