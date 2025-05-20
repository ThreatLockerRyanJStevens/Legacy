using System;
using System.Collections.Generic;
using System.Linq;
using ThreatLockerCommon.Constants;

namespace ThreatLockerCommon.Models
{
    public class MatchingApplicationRequest
    {
        public MatchingApplicationRequest()
        {
            
        }

        public MatchingApplicationRequest(ThreatLockerItemDTO threatLockerItemDTO)
        {
            Hash = threatLockerItemDTO.GetAttributeValue(ThreatLockerAttribute.TLHash).ToSafeString();
            Sha256 = threatLockerItemDTO.GetAttributeValue(ThreatLockerAttribute.SHA256).ToSafeString();

            List<ThreatLockerCert> certs = threatLockerItemDTO.GetAttributeValues(ThreatLockerAttribute.Certificate)?.ToList();

            Certs = certs.IsNullOrEmpty() ? new List<ThreatLockerCert> { new ThreatLockerCert() } : certs;

            List<string> createdBys = threatLockerItemDTO.GetAttributeValues(ThreatLockerAttribute.CreatedByProcess)?.ToList();

            CreatedBys = createdBys.IsNullOrEmpty() ? new List<string> { string.Empty } : createdBys;

            OSType = OperatingSystemType.Windows.Id;
            Path = threatLockerItemDTO.GetAttributeValue(ThreatLockerAttribute.FullPath).ToSafeString();
            ProcessPath = threatLockerItemDTO.GetAttributeValue(ThreatLockerAttribute.ProcessPath).ToSafeString();

            try
            {
                Filename = System.IO.Path.GetFileName(Path);
                Folder = System.IO.Path.GetDirectoryName(Path);
            }
            catch
            {

            }
        }

        public MatchingApplicationRequest(ThreatLockerAction threatLockerAction)
        {
            Hash = threatLockerAction.hash;
            Sha256 = threatLockerAction.sha256;
            Certs = threatLockerAction.certs.IsNullOrEmpty() ? new List<ThreatLockerCert> { new ThreatLockerCert() } : threatLockerAction.certs;
            CreatedBys = threatLockerAction.installedBy.IsNullOrEmpty() ? new List<string> { string.Empty } : threatLockerAction.installedBy;
            OSType = threatLockerAction.OSType;
            Path = threatLockerAction.fullpath;
            ProcessPath = threatLockerAction.processName;

            try
            {
                Filename = System.IO.Path.GetFileName(Path);
                Folder = System.IO.Path.GetDirectoryName(Path);
            }
            catch
            {

            }
        }

        public string Hash { get; set; } = string.Empty;
        public string Sha256 { get; set; } = string.Empty;
        public string CertSubject { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string ProcessPath { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public Guid OrganizationId { get; set; }
        public List<ThreatLockerCert> Certs { get; set; } = new List<ThreatLockerCert>();
        public List<string> CreatedBys { get; set; } = new List<string>();
        public int OSType { get; set; } = 1;
        public string Filename { get; set; } = string.Empty;
        public string Folder { get; set; } = string.Empty;
    }
}