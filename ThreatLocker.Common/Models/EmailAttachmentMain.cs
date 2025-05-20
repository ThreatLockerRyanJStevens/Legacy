using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class EmailAttachmentMain
    {
        public Guid EmailAttachmentMainID { get; set; }

        public Guid? EmailId { get; set; }

        public byte[] Attachment { get; set; }

        public string Url { get; set; }

        public string FileName { get; set; }

        public string FileType { get; set; }

        public int? Size { get; set; }

        public string Disposition { get; set; }

        public string InlineContentId { get; set; }

    }
}
