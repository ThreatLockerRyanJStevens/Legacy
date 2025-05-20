using System;

namespace ThreatLocker.Shared.Models
{
    public class Reports
    {
        public Guid ReportId { get; set; }

        public string ReportName { get; set; }

        public string TSql { get; set; }

        public int ReportTypeId { get; set; }

        public Guid OrganizationId { get; set; }

        public string Category { get; set; }

        public Guid PermissionId { get; set; }

        public bool DateOption { get; set; }

        public bool DataOption { get; set; }

        public bool GuidOption { get; set; }

        public string DataOptionName { get; set; }

        public string GuidOptionName { get; set; }

        public bool IsActive { get; set; }

    }
}
