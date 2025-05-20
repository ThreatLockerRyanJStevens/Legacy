using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
	public class UserTasks
    {
		public int totalOpenTasks { get; set; }
		public int totalClosedTasks { get; set; }
		public List<Tasks> taskList { get; set; }
    }
	public class Tasks
	{
		public Guid taskId { get; set; }
		public string title { get; set; }
		public string details { get; set; }
		public DateTime dueDateTime { get; set; }
		public Guid assignedTo { get; set; }
		public Guid relatedOrganizationId { get; set; }
		public Guid relatedContactId { get; set; }
		public Guid statusId { get; set; }
		public Guid priorityId { get; set; }
		public string createdBy { get; set; }
		public DateTime createdDate { get; set; }
		public string lastModifiedBy { get; set; }
		public DateTime lastModifiedDate { get; set; }
		public bool success { get; set; }
		public string taskType { get; set; }
		public string outcome { get; set; }
		public bool isClosed { get; set; }
		public bool isPendingClosed { get; set; }
		public string relatedOrganizationName { get; set; }
		public string salesEmail { get; set; }
	}

	public class TaskStatus
    {
		public Guid taskStatusId { get; set; }
		public string statusName { get; set; }
	}

	public class TaskPriority
    {
		public Guid taskPriorityId { get; set; }
		public string priorityName { get; set; }
	}

	public class TaskType
    {
		public Guid taskTypeId { get; set; }
		public string typeName { get; set; }
	}
}
