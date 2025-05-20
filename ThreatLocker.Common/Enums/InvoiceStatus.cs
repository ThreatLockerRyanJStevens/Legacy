using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum InvoiceStatus
    {
        [Description("Draft")]
        Draft = 0,

        [Description("Ready")]
        Ready = 1,

        [Description("Deleted")]
        Deleted = 2,

        [Description("Paid")]
        Paid = 3,

        [Description("Partially Paid")]
        PartiallyPaid = 4,

        [Description("Overdue")]
        Overdue = 5,

        [Description("Deferred")]
        Deferred = 5,
    }
}
