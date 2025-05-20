using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class WebsiteEvent
    {
        public Guid WebsiteEventId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public DateTime SubmitDate { get; set; }

        public string Url { get; set; }

        public string Section { get; set; }

        public string ElementName { get; set; }

        public string EventType { get; set; }

    }
}
