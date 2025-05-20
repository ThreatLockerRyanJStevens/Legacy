using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.DTOs
{
    public class EmailParams
    {
        public bool UseOrganization { get; set; }
        public Guid OrganizationId { get; set; }
        public string Category { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
    }
}
