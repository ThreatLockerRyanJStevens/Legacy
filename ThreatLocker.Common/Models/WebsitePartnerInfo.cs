using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class WebsitePartnerInfo
    {
        public Guid WebsitePartnerInfoId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string OrganizationName { get; set; }

        public DateTime SubmitDate { get; set; }

    }
}
