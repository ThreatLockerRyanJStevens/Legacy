using System;

namespace ThreatLockerCommon.Models
{
    public class ProxySetting
    {
        /// <summary>
        /// Fully qualified proxy URL. i.e. http://myproxy.mycompany.com:8001
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The setting of the BypassProxyOnLocal property determines whether to use the proxy server when accessing local Internet resources.
        /// 
        /// If BypassProxyOnLocal is true, requests to local Internet resources do not use the proxy server. Local requests are identified by the lack of a period (.) in the URI, as in http://webserver/, or access the local server, including http://localhost, http://loopback, or http://127.0.0.1. When BypassProxyOnLocal is false, all Internet requests are made through the proxy server.
        /// </summary>
        public bool BypassOnLocal { get; set; }

        /// <summary>
        /// An array of regular expression strings that contain the URIs of the servers to bypass. i.e. new string[]{";*.mycompany.com"};
        /// </summary>
        public string[] BypassList { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
