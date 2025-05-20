using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class ITGlueIntegration
    {
        public string apiKey { get; set; }
        public bool computersChecked { get; set; }
        public bool groupsChecked { get; set; }
        public int syncFrequency { get; set; }
        public List<ITGlueOrganization> itGlueOrganizations { get; set; } = new List<ITGlueOrganization>();

        public List<ITGlueCompanyMapping> itGlueCompanyMapping { get; set; } = new List<ITGlueCompanyMapping>();
        public bool euPartner { get; set; }
        public bool auPartner { get; set; }
        public DateTime? LastForcedSyncDate { get; set; }
    }

    [Serializable]
    public class ITGlueValidation
    {
        public string apiKey { get; set; }
    }
    [Serializable]
    public class ITGlueOrganization
    {
        public string itGlueOrgId { get; set; }
        public string name { get; set; }
    }
    [Serializable]
    public class ResponseITGlueOrganizations
    {
        public List<Data> data { get; set; }
        public ITGlueMeta meta { get; set; }
    }
    [Serializable]
    public class ITGlueCompanyMapping
    {
        public string itGlueOrganizationName;
        public string itGlueOrganizationId;
        public string OrganizationId;
    }
    [Serializable]
    public class ITGlueMeta
    {
        [JsonProperty("current-page")]
        public int CurrentPage { get; set; }

        [JsonProperty("next-page")]
        public int NextPage { get; set; }

        [JsonProperty("prev-page")]
        public int PrevPage { get; set; }

        [JsonProperty("total-pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total-count")]
        public int TotalCount { get; set; }
    }
    [Serializable]
    public class Attributes
    {
        public string name { get; set; }

        [JsonProperty("organization-type-id")]
        public long OrganizationTypeId { get; set; }

        [JsonProperty("organization-type-name")]
        public string OrganizationTypeName { get; set; }
    }
    [Serializable]
    public class Data
    {
        public string id { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
    }
}
