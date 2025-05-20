using System;


namespace ThreatLocker.Shared.Models
{
    public class Tasks
    {
        public Guid TaskId { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public DateTime DueDateTime { get; set; }

        public Guid AssignedTo { get; set; }

        public Guid RelatedOrganizationId { get; set; }

        public Guid? RelatedContactId { get; set; }

        public Guid StatusId { get; set; }

        public Guid PriorityId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string TaskType { get; set; }

        public string Outcome { get; set; }

        public bool IsClosed { get; set; }

        public bool IsPendingClosed { get; set; }

    }
}
