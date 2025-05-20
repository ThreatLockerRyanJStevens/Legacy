using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class EmailTemplateAttachment
    {
        public Guid EmailTemplateAttachmentId { get; set; }
        public Guid EmailTemplateId { get; set; }
        public byte[] Attachment { get; set; }
        public bool IncludeInEmail { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
    }
}
