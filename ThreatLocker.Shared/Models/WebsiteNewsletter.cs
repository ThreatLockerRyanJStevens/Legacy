using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class WebsiteNewsletter
    {
        public Guid WebsiteNewsletterId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public string EmailAddress { get; set; }

        public DateTime SubmitDate { get; set; }

    }
}
