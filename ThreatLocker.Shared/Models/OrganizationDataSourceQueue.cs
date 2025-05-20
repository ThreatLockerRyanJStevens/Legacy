using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class OrganizationDataSourceQueue
    {
        public long OrganizationDataSourceQueueId { get; set; }

        public Guid OrganizationId { get; set; }

        public string OrganizationName { get; set; }

        public string RemoteAPIUrl { get; set; }

        public string ServerName { get; set; }

        public int Site { get; set; }

        public string RequestedBy { get; set; }

        public DateTime RequestedDateTime { get; set; }
    }
}
