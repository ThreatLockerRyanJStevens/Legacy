using System;
using System.ComponentModel;

namespace ThreatLocker.Shared.Models
{
    public class AuthorizationHost
    {
        [DefaultValue(null)]
        public Guid? AuthorizationHostId { get; set; }

        [DefaultValue("")]
        public string Host { get; set; }

        [DefaultValue("")]
        public string DestinationServer { get; set; }

        [DefaultValue("")]
        public int PortNumber { get; set; }

        [DefaultValue("")]
        public string Keyword { get; set; }

        [DefaultValue(null)]
        public Guid? AppliesToId { get; set; }

        [DefaultValue(1)]
        public int AppliesToType { get; set; }

        [DefaultValue("")]
        public string AppliesToDisplayName { get; set; }

        [DefaultValue(false)]
        public bool Deleted { get; set; }

        [DefaultValue(null)]
        public DateTime CreatedDate { get; set; }
    }
}
