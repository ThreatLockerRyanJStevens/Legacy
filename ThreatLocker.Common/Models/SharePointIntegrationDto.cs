using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class SharePointIntegrationDto
    {
        public Guid IntegrationId { get; set; }
        public Guid OrganizationId { get; set; }
        public List<SharePointTenantDto> Tenants { get; set; } = new List<SharePointTenantDto>();
        public SharePointIntegrationAdditionalDataDto AdditionalData { get; set; } = new SharePointIntegrationAdditionalDataDto();
    }

    public class SharePointTenantDto
    {
        public int Id { get; set; }
        public Guid TenantId { get; set; }
        public string TenantName { get; set; }
        public bool GrantedConsent { get; set; }
        public List<string> FilePaths { get; set; } = new List<string>();
        public List<SharePointTenantPermissionDto> Permissions { get; set; } = new List<SharePointTenantPermissionDto>();
    }

    public class SharePointTenantPermissionDto
    {
        public string Permission { get; set; }
        public bool AdminConsent { get; set; }

        public SharePointTenantPermissionDto() { }

        public SharePointTenantPermissionDto(string permission, bool adminConsent = false)
        {
            Permission = permission;
            AdminConsent = adminConsent;
        }
    }

    public class SharePointTenantPermissionListDto
    {
        public Guid TenantId { get; set; }
        public List<SharePointTenantPermissionDto> Permissions { get; set; } = new List<SharePointTenantPermissionDto>();

        public SharePointTenantPermissionListDto() { }

        public SharePointTenantPermissionListDto(Guid tenantId, List<SharePointTenantPermissionDto> permissions = null)
        {
            TenantId = tenantId;
            Permissions = permissions ?? new List<SharePointTenantPermissionDto>();
        }
    }

    public class SharePointIntegrationAdditionalDataDto
    {
        public int LogsInLastHour { get; set; }
        public DateTime? FirstHourlyRetrievalDateTime { get; set; }
        public DateTime? LastRetrievalDateTime { get; set; }
        public List<SharePointTenantPermissionListDto> TenantPermissions { get; set; } = new List<SharePointTenantPermissionListDto>();
    }
}