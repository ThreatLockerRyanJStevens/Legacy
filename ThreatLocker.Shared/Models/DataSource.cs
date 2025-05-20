using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class DataSource
    {
        public Guid DataSourceId { get; set; }
        public string ConnectionString { get; set; }
        public int RetentionPeriod { get; set; }
        public int ConnectionType { get; set; }
        public bool IsActive { get; set; }
        public string RemoteAPIURL { get; set; }
        public string DatabaseName { get; set; }
        public int LogShipInterval { get; set; }
    }
}
