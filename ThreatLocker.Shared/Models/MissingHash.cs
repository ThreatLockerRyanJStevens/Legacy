using System;

namespace ThreatLocker.Shared.Models
{
    public class MissingHash
    {
        public Guid MissingHashId { get; set; }
        public Guid ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public DateTime DateTimeNotMatched { get; set; }
        public string SubmittedNotes { get; set; }
        public string Hash { get; set; }
        public string SHA256Hash { get; set; }
        public string FullPath { get; set; }
        public string ReportedBy { get; set; }
        public DateTime ReportedDate { get; set; }
        public string ProcessPath { get; set; }
        public string FileHistoryURL { get; set; }
        public int Status { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Action { get; set; }
        public DateTime? DateTimeCaptured { get; set; }
        public string ReasonMissed { get; set; }
        public bool? ConfirmedUpdate { get; set; }
        public string NextSteps { get; set; }
        public string OtherDetails { get; set; }
        public string Certificate { get; set; }
        public string CreatedByProcess { get; set; }
        public Guid OrganizationId { get; set; }
    }
}
