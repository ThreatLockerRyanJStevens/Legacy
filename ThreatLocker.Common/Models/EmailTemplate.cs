using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class EmailTemplate
    {
        public Guid EmailTemplateId { get; set; }
		public string Template { get; set; }
		public Guid UserId { get; set; }
		public DateTime CreatedOn { get; set; }
		public string TemplateName { get; set; }
        public bool Global { get; set; }
        public string EmailSubject { get; set; }
    }
}
