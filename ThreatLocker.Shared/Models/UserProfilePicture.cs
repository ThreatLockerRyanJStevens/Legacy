using System;

namespace ThreatLocker.Shared.Models
{
    public class UserProfilePicture
    {
        public Guid UserProfilePictureId { get; set; }
        public Guid UserId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int FileSize { get; set; }
        public string Sha256 { get; set; }
    }
}
