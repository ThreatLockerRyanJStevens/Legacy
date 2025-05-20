using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class ResearchApplicationDTO
    {
        public string ApplicationName { get; set; }
        public string CompanyName { get; set; }
        public Dictionary<Guid, List<string>> ResearchInformation { get; set; }
        public List<string> CountryCodes { get; set; } = new List<string>();
        public List<string> Categories { get; set; } = new List<string>();
    }

    public class ResearchApplicationPackage
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ApplicationName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Guid ResearchApplicationId { get; set; }
        /// <summary>
        /// RresearchInformationTypeId, values of that research type.
        /// </summary>
        public Dictionary<Guid, List<string>> ResearchInformation { get; set; } = new Dictionary<Guid, List<string>>();
    }
}
