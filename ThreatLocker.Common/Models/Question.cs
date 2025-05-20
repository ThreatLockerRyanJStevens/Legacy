using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
	public class CRMQuestion
	{
		public int CRMQuestionId { get; set; }
		public string Question { get; set; }
	}
	public class QuestionAnswer
	{
		public int crmQuestionAnswerId { get; set; }
		public Guid organizationId { get; set; }
		public string question { get; set; }
		public string answer { get; set; }
		public string createdBy { get; set; }
		public DateTime dateTime { get; set; }
		public string lastModifiedBy { get; set; }
		public DateTime lastModifiedDate { get; set; }
		public bool success { get; set; }
	}
}
