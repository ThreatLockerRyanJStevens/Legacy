using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum ObjectType
    {
        [Description("Unknown")]
        Unknown = 0,

        [Description("User")]
        User = 1,

        [Description("Organization")]
        Organization = 2
    }
}
