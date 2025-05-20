using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class WebsiteUtmCode
    {
        public Guid WebsiteUtmSourceId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public DateTime SubmitDate { get; set; }

        public string UtmSource { get; set; }

        public string UtmMedium { get; set; }

        public string UtmCampaign { get; set; }

        public string UtmTerm { get; set; }

        public string UtmContent { get; set; }

    }
}
