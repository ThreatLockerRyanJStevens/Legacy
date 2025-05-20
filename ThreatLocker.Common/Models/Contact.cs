using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
	public class Contact
	{
		public Guid organizationId { get; set; }
		public Guid contactId { get; set; }
		public string username { get; set; }
		public string firstName { get; set; } = String.Empty;
		public string lastName { get; set; } = String.Empty;
		public string emailAddress { get; set; }
		public string fullEmailAddress { get; set; }
		public string title { get; set; } = String.Empty;
		public string officePhone { get; set; } = String.Empty;
		public string cellPhone { get; set; } = String.Empty;
		public string linkedIn { get; set; } = String.Empty;
		public string notes { get; set; }
		public string results { get; set; }
		public bool success { get; set; }
		public bool canLogin { get; set; }
		public string emailAlias { get; set; }
	}
}
