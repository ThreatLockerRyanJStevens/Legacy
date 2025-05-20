using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum EmailCampaignRecipientPreStatus
    {
        [Description("Contact is ready to receive email")]
        ReadyToRecieve = 0,

        [Description("Contact wishes to opt out of the emailing campaign")]
        Exclude = 1,

        [Description("Contact does not want the email yet")]
        Defer = 2
    }
}
