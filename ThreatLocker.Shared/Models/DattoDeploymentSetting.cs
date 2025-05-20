using System.Collections.Generic;

namespace ThreatLocker.Shared.Models
{
    public class DattoDeploymentSetting
    {
        public string ComponentId { get; set; }
        public bool HasAutoPushEnabled { get; set; }
        public List<string> RMMSites { get; set; }
    }
}
