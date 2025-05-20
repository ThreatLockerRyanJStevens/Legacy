using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
	public class OrganizationAssignment
	{
		public Guid organizationId { get; set; }
		public Guid previousSalesUserId { get; set; }
		public string previousSalesEmail { get; set; }
		public Guid salesUserId { get; set; }
		public string salesEmail { get; set; }
	}
}
