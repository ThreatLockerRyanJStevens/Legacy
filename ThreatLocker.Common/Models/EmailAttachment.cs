using System;
using System.IO;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class EmailAttachment
    {
        public Guid EmailCampaignAttachmentId { get; set; }
        public Guid EmailCampaignId { get; set; }
        public byte[] Attachment { get; set; }
        public bool IncludeInEmail { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }

        public void ConvertFileStreamToBytes(Stream input)
        {
            if (input == null)
            {
                throw new ArgumentException("Input cannot be null");
            }

            using (var binaryReader = new BinaryReader(input))
            {
                Attachment = binaryReader.ReadBytes((int)input.Length);
            }
        }

        public string GetBase64() => Attachment.Length > 0 ? Convert.ToBase64String(Attachment) : string.Empty;
    }
}
