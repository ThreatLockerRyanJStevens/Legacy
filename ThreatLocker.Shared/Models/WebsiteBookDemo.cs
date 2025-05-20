using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class WebsiteBookDemo
    {
        public Guid WebsiteBookDemoId { get; set; }

        public Guid WebsiteUserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public string OrganizationName { get; set; }

        public string BusinessType { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public int? EstimatedSeats { get; set; }

        public string GeneralLocation { get; set; }

        public DateTime SubmitDate { get; set; }

    }
}
