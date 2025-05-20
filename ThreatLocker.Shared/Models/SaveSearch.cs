using System;

namespace ThreatLocker.Shared.Models
{
    public class SaveSearch
    {
        public Guid SaveSearchId { get; set; }
        public int SaveSearchPageId { get; set; }
        public string SearchName { get; set; }
        public string SaveParameters { get; set; }
        public string Username { get; set; }
        public Guid OrganizationId { get; set; }
        public long? SearchCount { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
