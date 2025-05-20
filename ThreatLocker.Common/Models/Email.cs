using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
	public class Email
	{
		public Guid EmailId { get; set; }
		public Guid OrganizationId { get; set; }
		public string Sender { get; set; }
		public List<string> Recipients { get; set; }
		public List<string> CCRecipients { get; set; } = new List<string>();
		public List<string> BCCRecipients { get; set; } = new List<string>();
		public string Subject { get; set; }
		public string Body { get; set; }
		public string UnsanitizedBody { get; set; }
		public DateTime DateTime { get; set; }
		public int Direction { get; set; }
		public string SendGridId { get; set; }
		public string RecipientString { get; set; }
		public string CCRecipientString { get; set; }
		public int? Opens { get; set; }
		public int? Clicks { get; set; }
		public bool? IsFlagged { get; set; }
		public bool? IsArchived { get; set; }
		public bool? IsPhishing { get; set; }
		public bool? IsExcluded { get; set; }
		public string OrganizationName { get; set; }
		public int? TotalRows { get; set; }

		public List<EmailAttachmentMain> Attachments { get; set; }
}
}
