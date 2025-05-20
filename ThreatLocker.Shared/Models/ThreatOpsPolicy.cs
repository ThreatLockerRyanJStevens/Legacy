using System;

namespace ThreatLocker.Shared.Models
{
    public class ThreatOpsPolicy
    {
		public Guid ThreatOpsPolicyId { get; set; }

		public Guid OrganizationId { get; set; }

		public Guid AppliesTo { get; set; }

		public string PolicyName { get; set; }

		public string Description { get; set; }

		public bool IsEnabled { get; set; }

		public string PolicyIcon { get; set; }

		public bool IsAllConditionsTrue { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public int OrderBy { get; set; }

		public string LastUpdatedBy { get; set; }

		public DateTime LastUpdatedDate { get; set; }

		public DateTime CreatedDate { get; set; }

		public string CreatedBy { get; set; }

		public bool IsCommunityPolicy { get; set; }

		public bool IsCreatedFromCommunity { get; set; }

		public Guid CommunityThreatOpsPolicyId { get; set; }

		public bool IsDeleted { get; set; }
	}
}
