using Newtonsoft.Json;
using System;

namespace ThreatLockerCommon.DTOs
{
    [Serializable]
    public class EmailValidationResponseDto
    {
        [JsonProperty("result")]
        public EmailValidationResultDto result { get; set; }
    }

    public class EmailValidationResultDto
    {
        [JsonProperty("email")]
        public string email { get; set; }
        [JsonProperty("verdict")]
        public string verdict { get; set; }
        [JsonProperty("score")]
        public decimal score { get; set; }
        [JsonProperty("local")]
        public string local { get; set; }
        [JsonProperty("checks")]
        public object checks { get; set; }
    }

    public class SendGridEmailValidation
    {
        [JsonProperty("email")]
        public string email { get; set; }
        [JsonProperty("source")]
        public string source { get; set; }
    }
}
