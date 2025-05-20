using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class DattoPSAClient
    {
        public long DattoPSAClientId { get; set; }
        public Guid IntegrationId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
