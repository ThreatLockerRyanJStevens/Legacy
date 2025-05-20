using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
	public class MessageTemplate
	{
		public Guid messageTemplateId { get; set; }
		public string templateName { get; set; }
		public string templateSubject { get; set; }
		public string templateBody { get; set; }
		public bool isSystem { get; set; }
		public bool isActive { get; set; }
		public Guid associatedUser { get; set; }
		public string createdBy { get; set; }
		public DateTime createdDate { get; set; }
		public string lastModifiedBy { get; set; }
		public DateTime lastModifiedDate { get; set; }
	}
}
