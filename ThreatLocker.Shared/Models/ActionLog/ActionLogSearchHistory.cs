using System;

namespace ThreatLocker.Shared.Models.ActionLog
{
    public class ActionLogSearchHistory
    {
        public int ActionLogSearchHistoryId { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SearchQuery { get; set; }
        public string CountQuery { get; set; }
    }
}
