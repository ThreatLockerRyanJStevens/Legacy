using System;

namespace ThreatLocker.Shared.Models
{
    public class PushAuthentication
    {
        public Guid PushAuthenticationId { get; set; }

        public Guid UserId { get; set; }

        public string Username { get; set; }

        public string IPAddress { get; set; }

        public string Location { get; set; }

        public string DeviceToken { get; set; }

        public int PushAuthenticationStatus { get; set; }

        public DateTime DateTime { get; set; }

    }
}
