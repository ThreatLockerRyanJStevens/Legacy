using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class WebsiteContactUs
    {
        public Guid WebsiteContactUsId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string JobTitle { get; set; }

        public string OrganizationName { get; set; }

        public string Message { get; set; }

        public DateTime SubmitDate { get; set; }

    }
}
