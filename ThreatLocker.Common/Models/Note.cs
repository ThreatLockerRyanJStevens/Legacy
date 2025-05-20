using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
	public class Note
	{
		public Guid noteId { get; set; }
		public Guid organizationId { get; set; }
		public string details { get; set; }
		public string createdBy { get; set; }
		public DateTime createdDate { get; set; }
		public string lastModifiedBy { get; set; }
		public DateTime lastModifiedDate { get; set; }
	}
}