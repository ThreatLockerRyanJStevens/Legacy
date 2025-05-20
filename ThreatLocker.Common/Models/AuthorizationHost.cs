using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class AuthorizationHost
    {
        public Guid AuthorizationHostId { get; set; }
        public string Host { get; set; }
        public string Keyword { get; set; }
        public Guid AppliesToId { get; set; }
        public int AppliesToType { get; set; }
        public string AppliesToDisplayName { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
