using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum AutomatedInvoicingStatus
    {
        [Description("No action necessary")]
        None = 0,

        [Description("Successfully created invoice")]
        Created = 1,

        [Description("Failed to create invoice")]
        Failed = 2,
    }
}
