using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class Office365IntegrationDto
    {
        public Guid IntegrationId { get; set; }
        public Guid OrganizationId { get; set; }
        public List<Office365TenantDto> Tenants { get; set; } = new List<Office365TenantDto>();
        public Office365IntegrationAdditionalDataDto AdditionalData { get; set; } = new Office365IntegrationAdditionalDataDto();
    }

    public class Office365TenantDto
    {
        public int Id { get; set; }
        public Guid TenantId { get; set; }
        public string TenantName { get; set; }
        public int ApiTypeId { get; set; }
        public bool GrantedConsent { get; set; }
        public List<Office365TenantPermissionDto> Permissions { get; set; } = new List<Office365TenantPermissionDto>();
    }

    public class Office365TenantPermissionDto
    {
        public string Permission { get; set; }
        public bool AdminConsent { get; set; }
    }

    public class Office365TenantPermissionListDto
    {
        public Guid TenantId { get; set; }
        public List<Office365TenantPermissionDto> Permissions { get; set; } = new List<Office365TenantPermissionDto>();

        public Office365TenantPermissionListDto() { }

        public Office365TenantPermissionListDto(Guid tenantId, List<Office365TenantPermissionDto> permissions = null)
        {
            TenantId = tenantId;
            Permissions = permissions ?? new List<Office365TenantPermissionDto>();
        }
    }

    public class Office365IntegrationAdditionalDataDto
    {
        public int LogsInLastHour { get; set; }
        public DateTime? FirstHourlyRetrievalDateTime { get; set; }
        public DateTime? LastRetrievalDateTime { get; set; }
        public List<Office365TenantPermissionListDto> TenantPermissions { get; set; } = new List<Office365TenantPermissionListDto>();
    }
}