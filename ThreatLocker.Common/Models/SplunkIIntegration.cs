using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class SplunkIIntegration
    {
        public string SplunkURL { get; set; }
        public string SplunkKey { get; set; }
        public string policyName { get; set; }
    }
    public class SplunkLoggedInformation
    {
        public string FullPath { get; set; }
        public string Username { get; set; }
        public int ActionId { get; set; }
        public string Hash { get; set; }
        public List<ThreatLockerCert> Certs { get; set; }
        public string ProcessName { get; set; }
        public string ApplicationId { get; set; }
        public string SerialNumber { get; set; }
        public string DeviceType { get; set; }
        public string ActionType { get; set; }
        public string PolicyName { get; set; }
        public string ApplicationName { get; set; }
    }
    public class SplunkIntegrationSettings
    {
        public string SplunkURL { get; set; }
        public string SplunkKey { get; set; }
    }
}