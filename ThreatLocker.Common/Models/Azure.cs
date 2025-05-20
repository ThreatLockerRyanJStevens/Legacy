using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    /// <remarks>
    /// Outdated model. Convert instance to AzureIntegrationV2
    /// </remarks>
    [Serializable]
    public class AzureIntegration
    {
        public Guid TenantId { get; set; }
        public bool AdminConsent { get; set; }
        public bool SyncNestedGroups { get; set; }
        public Dictionary<Guid, string> AzureGroups { get; set; } = new Dictionary<Guid, string>();
    }

    [Serializable]
    public class AzureIntegrationV2
    {
        public List<AzureTenant> Tenants { get; set; } = new List<AzureTenant>();

        public AzureIntegrationV2() { }

        public AzureIntegrationV2(AzureIntegration azureIntegration)
        {
            Tenants = new List<AzureTenant>
            {
                new AzureTenant
                {
                    TenantId = azureIntegration.TenantId,
                    AdminConsent = azureIntegration.AdminConsent,
                    SyncNestedGroups = azureIntegration.SyncNestedGroups,
                    Groups = azureIntegration.AzureGroups.Select(g => new AzureGroup(g.Key, g.Value)).ToList()
                }
            };
        }
    }

    [Serializable]
    public class AzureTenant
    {
        public int Id { get; set; }
        public Guid TenantId { get; set; }
        public bool AdminConsent { get; set; }
        public bool SyncNestedGroups { get; set; }
        public List<AzureGroup> Groups { get; set; } = new List<AzureGroup>();
    }

    [Serializable]
    public class AzureGroupsResponse
    {
        [JsonProperty("@odata.context")]
        public string ODataContext { get; set; }
        [JsonProperty("@odata.count")]
        public int ODataCount { get; set; }
        [JsonProperty("@odata.nextLink")]
        public string ODataNextLink { get; set; }
        public List<AzureGroup> Value { get; set; } = new List<AzureGroup>();
    }

    [Serializable]
    public class AzureGroup
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }

        public AzureGroup() { }

        public AzureGroup(Guid id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }
    }

    public class ServiceAzureGroupMember
    {
        [JsonProperty("AzureGroupMemberId")]
        public long AzureGroupMemberId { get; set; }
        [JsonIgnore]
        public Guid IntegrationId { get; set; }
        [JsonIgnore]
        public Guid OrganizationId { get; set; }
        [JsonIgnore]
        public Guid AzureGroupId { get; set; }
        [JsonIgnore]
        public string GroupMember { get; set; }
        [JsonIgnore]
        public string GroupMemberSID { get; set; }
        [JsonProperty("GroupMemberSHA")]
        public string GroupMemberSHA { get; set; }
        [JsonProperty("TransactionType")]
        public int TransactionTypeId { get; set; }
        [JsonProperty("RelatedAzureGroupMemberId")]
        public long RelatedAzureGroupMemberId { get; set; }
    }
}
