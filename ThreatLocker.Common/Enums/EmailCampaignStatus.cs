using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum EmailCampaignStatus
    {
        [Description("Emails has not been sent yet")]
        Composing = 0,

        [Description("Emails are ready to be sent out to users")]
        ReadyToSend = 1,

        [Description("Email has been sent to all users")]
        Successful = 2,

        [Description("Not all of the user have received their emails")]
        PartiallySuccessful = 3,

        [Description("Scheduled emails has been delayed")]
        Delayed = 4,

        [Description("This campaign has been abandonded")]
        Abandonded = 5,

        [Description("Campagin has been reopened")]
        Reopened = 6,

        [Description("Something went during the processing of the campaign")]
        Failed = 7
    }
}
