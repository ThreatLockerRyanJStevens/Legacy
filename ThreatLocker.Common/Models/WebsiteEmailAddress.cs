using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class WebsiteEmailAddress
    {
        public Guid WebsiteEmailAddressId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public string EmailAddress { get; set; }
        public DateTime SubmitDate { get; set; }

    }
}
