using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class TouchPoint
    {
        public Guid TouchPointId { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime DateTime { get; set; }

        public string TouchPointType { get; set; }

        public string Details { get; set; }

        public string TouchedBy { get; set; }

        public Guid? ContactId { get; set; }

        public string TradeShowName { get; set; }

        public DateTime CreatedDateTime { get; set; }

    }
}
