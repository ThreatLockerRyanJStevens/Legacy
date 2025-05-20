using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class OrganizationDataSource
    {
        public Guid OrganizationId { get; set; }

        public Guid DataSourceId { get; set; }

        public int Priority { get; set; }
    }
}
