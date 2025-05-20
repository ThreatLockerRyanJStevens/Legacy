using System;

namespace ThreatLocker.Shared.Models
{
    public class HelpDeskTicket
    {
        public Guid HelpDeskTicketId { get; set; }

        public long HelpDeskTicketNumber { get; set; }

        public Guid? HelpDeskTicketMergedId { get; set; }

        public long HelpDeskTicketMergedNumber { get; set; }

        public Guid? OrganizationId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string PrimaryContact { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public string TicketOwner { get; set; }

        public int HelpDeskStatusId { get; set; }

        public int HelpDeskCategoryId { get; set; }

        public string LastUpdatedBy { get; set; }

        public DateTime? LastUpdated { get; set; }

        public DateTime? DueDate { get; set; }

        public string HelpDeskTicketNumberDepreciated { get; set; }

        public int? StatusOverdue { get; set; }

        public int? HelpDeskStatusCategoryId { get; set; }
        public string? InstanceForAppLogger { get; set; }
        public Guid? AppLoggerId { get; set; }

        public DateTime? TimeResolvedOwner { get; set; }

        public string JiraTicketNumber { get; set; }

        public long JiraTicketId { get; set; }

        public string JiraTicketStatus { get; set; }
    }
}
