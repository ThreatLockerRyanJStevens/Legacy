using System;

namespace ThreatLocker.Shared.Models
{
    public class EmailCampaignAttachment
    {
        public Guid EmailCampaignAttachmentId { get; set; }
        public Guid EmailCampaignId { get; set; }
        public byte[] Attachment { get ; set; }
        public bool IncludeInEmail { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
    }
}
