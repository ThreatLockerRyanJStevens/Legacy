using System.Collections.Generic;

namespace ThreatLocker.Shared.Models
{
    public class ServiceNowTicketSetting
    {
        public string TicketType { get; set; }
        public string AssignmentGroup { get; set; }
        public string Impact { get; set; }
        public string Urgency { get; set; }
        public string State { get; set; }
        public string AutoCloseState { get; set; }
        public string EscalationState { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string Service { get; set; }
        public string AssignedTo { get; set; }
        public string Catalog { get; set; }
        public List<string> Tags { get; set; }
    }
}
