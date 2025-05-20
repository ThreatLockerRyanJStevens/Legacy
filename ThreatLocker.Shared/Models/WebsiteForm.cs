using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class WebsiteForm
    {
        public Guid WebsiteFormId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public string FormName { get; set; }

        public DateTime SubmitDate { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public string PhoneNumber { get; set; }

        public string OrganizationName { get; set; }

        public string Message { get; set; }

        public bool? Newsletter { get; set; }

        public bool? ThirdWall { get; set; }

    }
}
