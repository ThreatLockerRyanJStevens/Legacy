using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
	public class Promotion
	{
		public Guid promotionId { get; set; }
		public Guid organizationId { get; set; }
		public Guid userId { get; set; }
		public string title { get; set; }
		public string details { get; set; }
		public string imageURL { get; set; }
		public int seatThreshold { get; set; }
		public int seatCount { get; set; }
		public int lockeddownThreshold { get; set; }
		public int lockeddownCount { get; set; }
		public string completedURL { get; set; }
		public DateTime expiryDate { get; set; }
	}

	[Serializable]
	public class OrgPromo
    {
		public Guid OrganizationId { get; set; }
		public Guid PromotionId { get; set; }
		public DateTime ExpiryDate { get; set; }
		public string Body { get; set; }
		public string Title { get; set; }
		public string AcceptBtnText { get; set; }
		public string ExternalLink { get; set; }
		public string BackgroundImageUrl { get; set; }
		public string BackgroundColor { get; set; }
		public string TextColor { get; set; }
	}

	[Serializable]
	public class OrgPromoCookie
    {
		public Guid OrganizationId { get; set; }
		public int ActionId { get; set; }
		public DateTime? AskAgain { get; set; }
		public Guid PromotionId { get; set; }
	}

	[Serializable]
	public class UserPromo
	{
		public Guid UserId { get; set; }
		public Guid PromotionId { get; set; }
		public string Body { get; set; }
		public string Title { get; set; }
		public string AcceptBtnText { get; set; }
		public string ExternalLink { get; set; }
		public string BackgroundImageUrl { get; set; }
		public string BackgroundColor { get; set; }
		public string TextColor { get; set; }
	}

	[Serializable]
	public class UserPromoCookie
	{
		public Guid UserId { get; set; }
		public int ActionId { get; set; }
		public DateTime? AskAgain { get; set; }
		public Guid PromotionId { get; set; }
	}
}