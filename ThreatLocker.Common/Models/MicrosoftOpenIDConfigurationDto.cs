using Newtonsoft.Json;

namespace ThreatLockerCommon.Models
{
    public class MicrosoftOpenIDConfigurationDto
    {
        /// <summary>
        /// Used for Azure window prompts (ex. microsoftonline.com)
        /// </summary>
        [JsonProperty("cloud_instance_name")]
        public string CloudInstanceName { get; set; }
        /// <summary>
        /// Used for Microsoft Graph scopes and API calls (ex. graph.microsoft.com)
        /// </summary>
        [JsonProperty("msgraph_host")]
        public string GraphHost { get; set; }
        /// <summary>
        /// Used for Office 365 Management scopes and API calls (ex. manage.office.com)
        /// </summary>
        public string ManagementHost
        {
            get
            {
                string managementHost = string.Empty;

                if (!string.IsNullOrEmpty(CloudInstanceName))
                {
                    if (CloudInstanceName.EndsWith(".us"))
                    {
                        managementHost = "manage.office365.us";
                    }
                    else
                    {
                        managementHost = "manage.office.com";
                    }
                }

                return managementHost;
            }
        }
    }
}