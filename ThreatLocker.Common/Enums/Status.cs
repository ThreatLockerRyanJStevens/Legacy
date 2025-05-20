using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum Status
    {
        [Description("Default DB entry")]
        Created = 0,

        [Description("Entity is active")]
        Active = 1,

        [Description("Entity is marked as deactivated or deleted")]
        InactiveOrDeleted = 2
    }
}
