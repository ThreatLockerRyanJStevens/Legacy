using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum DenyRequestStatus
    {
        [Description("The request is pending")]
        Composing = 0,

        [Description("Request is ready to be sent")]
        ReadyToSend = 1,

        [Description("Request is removed")]
        Removed = 2,

        [Description("Request has been processed")]
        Processed = 3,

        [Description("Request was not processed")]
        Errored = 4,

        [Description("Request is a duplicate")]
        Duplicate = 5
    }
}
