using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum InvoicePaymentStatus
    {
        [Description("Pending")]
        Pending = 0,

        [Description("Success")]
        Success = 1,

        [Description("Failure")]
        Failure = 2
    }
}
