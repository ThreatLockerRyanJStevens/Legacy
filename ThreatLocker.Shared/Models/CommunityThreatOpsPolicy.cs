using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class CommunityThreatOpsPolicy
    {
		public Guid CommunityThreatOpsPolicyId { get; set; }

		public Guid CommunityUserId { get; set; }

		public Guid ThreatOpsPolicyId { get; set; }

		public bool? IsEnabled { get; set; }

		public decimal Rating { get; set; }

		public int? RatingCount { get; set; }

		public int? Popularity { get; set; }

		public string LastUpdatedBy { get; set; }

		public DateTime? LastUpdatedDate { get; set; }

		public DateTime? CreatedDate { get; set; }

		public string CreatedBy { get; set; }

		public bool IsFeatured { get; set; }

		public string FeaturedImage { get; set; }

		public Guid OriginThreatOpsPolicyId { get; set; }

		public Guid OrganizationId { get; set; }

    }
}
