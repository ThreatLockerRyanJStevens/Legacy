using System;

namespace ThreatLockerCommon.Models
{
    public class Report
    {
        public string ReportId { get; set; }
        public string ReportName { get; set; }
        public string Category { get; set; }
        public bool DateOption { get; set; }
        public bool DataOption { get; set; }
        public bool GuidOption { get; set; }
        public string DataOptionName { get; set; }
        public string GuidOptionName { get; set; }
    }
    public class ReportRequest
    {
        public string Data { get; set; }
        public Guid Guid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid OrganizationId { get; set; }
    }
}
