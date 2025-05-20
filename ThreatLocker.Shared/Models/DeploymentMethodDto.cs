using System;

namespace ThreatLocker.Shared.Models
{
    public class DeploymentMethod
    {
        public Guid DeploymentMethodId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string DownloadUrl { get; set; }
        public string InstructionsUrl { get; set; }
        public bool IsActive { get; set; }
        //DV-5998 - the script files will be removed from Legacy and upload on file server, that's why it's needed those new fields (to adjust the data needed)
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int FileSize { get; set; }
        public string Sha256 { get; set; }
        public bool HasFileOnFileServer {
            get
            {
                return (
                       !string.IsNullOrEmpty(FileName)
                       && !string.IsNullOrEmpty(Sha256)
                       && !string.IsNullOrEmpty(FileType)
                       && FileSize > 0
                    );
            } 
        }
    }
}
