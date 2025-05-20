using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class WebsiteCaseStudy
    {
        public Guid WebsiteCaseStudyId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string OrganizationName { get; set; }

        public bool Newsletter { get; set; }

        public DateTime SubmitDate { get; set; }

    }
}
