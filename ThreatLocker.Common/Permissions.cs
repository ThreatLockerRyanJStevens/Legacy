using System;
using System.Collections.Generic;

namespace ThreatLockerCommon
{
    public enum PermissionNames
    {
        ApproveForEntireOrganization,
        ApproveForComputerGroup,
        ApproveForSingleComputer,
        ApproveForSingleComputerApplicationOnly,
        ElevationAdministrator
    }


    public class Permissions
    {
        public static Dictionary<int, Guid> Permission = new Dictionary<int, Guid>()
        {
            {(int)PermissionNames.ApproveForEntireOrganization, Guid.Parse("1EAF014F-7F9F-4B60-9DC1-54E98FAB50F7")},
            {(int)PermissionNames.ApproveForComputerGroup, Guid.Parse("A955E157-FD8F-46DE-80E0-AD069201D510")},
            {(int)PermissionNames.ApproveForSingleComputer, Guid.Parse("940DE5BE-F8E2-4DB7-AA4E-CB083AB2599F")},
            {(int)PermissionNames.ApproveForSingleComputerApplicationOnly, Guid.Parse("764B45A4-A25A-475D-8ECC-51A48B284B4D")},
            {(int)PermissionNames.ElevationAdministrator, Guid.Parse("29AB9B6D-0AB8-4164-95B7-E60C7738EED7")}
        };
    }
}
