using System;

namespace ThreatLocker.Shared.Models
{
    public class HelpDeskFile
    {
        public Guid HelpDeskTicketId { get; set; }

        public Guid? HelpDeskHistoryId { get; set; }

        public Guid? HelpDeskCommentId { get; set; }

        public int TargetType { get; set; }

        public string FileName { get; set; }

        public string FileType { get; set; }

        public int FileSize { get; set; }

        public Guid HelpDeskFileId { get; set; }

        public string Sha256 { get; set; }

        public bool IsViewableByCustomer { get; set; }

    }
}
