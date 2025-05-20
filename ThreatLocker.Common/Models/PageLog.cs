using System;

namespace ThreatLockerCommon.Models
{
    public class PageLogItem
    {
        public Guid ComputerId { get; set; }
        public Guid OrganizationId { get; set; }
        public string IPAddress { get; set; }
        public string PageName { get; set; }
        public string Json { get; set; } 
    }
}