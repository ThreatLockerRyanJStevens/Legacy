using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class CommunityUser
    {
        public Guid CommunityUserId { get; set; }

        public Guid OrganizationId { get; set; }

        public int CommunityUserTypeId { get; set; }

        public string Username { get; set; }

        public int Status { get; set; }

        public DateTime RequestDate { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public string ApprovedBy { get; set; }

        public decimal? PolicyRating { get; set; }

        public int? PolicyPopularity { get; set; }

        public int? PolicyRatingCount { get; set; }

        public string Json { get; set; }

        public string EmailAddress { get; set; }
    }
}
