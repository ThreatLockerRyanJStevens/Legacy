using System.ComponentModel;

namespace ThreatLockerCommon.Enums
{
    public enum PermissionCheckType
    {
        [Description("Unset")]
        Unset = -1,

        [Description("Permission Only")]
        PermissionOnly = 0,

        [Description("Permission and Super Admin")]
        WithSuperAdmin = 1,

        [Description("Permission, Super Admin, and Super Admin - Child")]
        WithSuperAdminAndChild = 2,

        [Description("Permission, Super Admin, and Super Admin - Parent Only")]
        WithSuperAdminAndParentOnly = 3
    }
}
