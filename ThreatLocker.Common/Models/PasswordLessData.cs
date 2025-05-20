using System;
using System.Net;

namespace ThreatLockerCommon.Models
{
    public class PasswordlessData
    {
        public string PasswordlessPhoneNumber { get; set; }

        public string PasswordlessPin { get; set; }

        public Guid UserId { get; set; }
        public string Username { get; set; }
        public IPAddress IPAddress { get; set; }
        public Guid OrganizationId { get; set; }
        public string APIURL { get; set; }
        public string PortalUrl { get; set; }
    }
}
