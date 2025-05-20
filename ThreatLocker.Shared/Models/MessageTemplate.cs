using System;

namespace ThreatLocker.Shared.Models
{
    public class MessageTemplate
    {
        public Guid MessageTemplateId { get; set; }

        public string TemplateName { get; set; }

        public string TemplateSubject { get; set; }

        public string TemplateBody { get; set; }

        public bool IsActive { get; set; }

        public Guid? AssociatedUser { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public bool IsSystem { get; set; }

    }

}
