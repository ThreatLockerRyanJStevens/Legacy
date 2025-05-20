using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
	public class TouchPoint
	{
		public Guid organizationId { get; set; }
		public DateTime touchDateTime { get; set; }
		public string touchPointType { get; set; }
		public string details { get; set; }
		public string touchedBy { get; set; }
		public Contact contact { get; set; }
		public Guid contactId { get; set; }
	}
	public class TouchPointType
    {
		public Guid touchPointTypeId { get; set; }
		public string typeName { get; set; }
	}
}