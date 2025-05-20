using System;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class TicketAttachment
    {
        public Guid TicketAttachmentID { get; set; }

        public long TicketHistoryID { get; set; }

        public byte[] Attachment { get; set; }

        public string FileName { get; set; }

        public string FileType { get; set; }
    }
}
