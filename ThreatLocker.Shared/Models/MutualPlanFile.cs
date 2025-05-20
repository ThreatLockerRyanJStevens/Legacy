using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class MutualPlanFile
    {
        public int MutualPlanFileId { get; set; }
        public Guid OrganizationId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int FileSize { get; set; }
        public string Sha256 { get; set; }
        public DateTime DateUploaded { get; set; }
        public string UploadedBy { get; set; }
        public Guid UploadedByUserId { get; set; }
    }
}
