using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class ApplicationFile
    {
        public long ApplicationFileId { get; set; }
        public Guid ApplicationId { get; set; }
        public string FullPath { get; set; }
        public string Cert { get; set; }
        public string Hash { get; set; }
        public string PermitLibraries { get; set; }
        public bool PermitAppUpdate { get; set; }
        public string CertSubject { get; set; }
        public string ProcessPath { get; set; }
        public string Notes { get; set; }
        public bool KeyFile { get; set; }
        public string NewCert { get; set; }
        public DateTime? OutdatedDate { get; set; }
        public string InstalledBy { get; set; }
        public bool HashOnly { get; set; }
        public string ApplicationIdHash { get; set; }
    }
    public class OnlineApplicationFile
    {
        public long OnlineApplicationFileId { get; set; }
        public Guid ApplicationOnlineId { get; set; }
        public string FullPath { get; set; }
        public string Cert { get; set; }
        public string Hash { get; set; }
        public string PermitLibraries { get; set; }
        public bool PermitAppUpdate { get; set; }
        public string CertSubject { get; set; }
        public string ProcessPath { get; set; }
        public string Notes { get; set; }
        public bool KeyFile { get; set; }
        public string NewCert { get; set; }
        public DateTime? OutdatedDate { get; set; }
        public string InstalledBy { get; set; }
        public bool HashOnly { get; set; }
        public string ApplicationIdHash { get; set; }
    }
    public class AppFile
    {
        public long ApplicationFileId { get; set; }
        public Guid ApplicationId { get; set; }
        public string FullPath { get; set; }
        public string Cert { get; set; }
        public string Hash { get; set; }
        public string ProcessPath { get; set; }
        public string Notes { get; set; }
        public bool KeyFile { get; set; }
        public string InstalledBy { get; set; }
    }
    public class ServiceAppFile
    {
        public long ApplicationFileId { get; set; }
        public string ApplicationId { get; set; }
        public string Hash { get; set; }
        public string Cert { get; set; }
        public string FullPath { get; set; }
        public string ProcessPath { get; set; }
        public string InstalledBy { get; set; } = "";
        public long MinSize { get; set; } = -1;
        public long MaxSize { get; set; } = -1;
        public long RelatedAppFileId { get; set; } = 0;
        public int TransactionType { get; set; } = 1;
    }
    public class ApplicationFileV3
    {
        public string FullPath { get; set; }
        public string Hash { get; set; }
        public string Cert { get; set; }
        public string ProcessPath { get; set; }
        public string ApplicationId { get; set; }
        public string InstalledBy { get; set; }
        public long AppFileId { get; set; }
        public int TransactionType { get; set; } //1 = add, 2 = delete
        public long RelatedAppFileId { get; set; }
    }

    public class ApplicationFileHash
    {
        public long ApplicationFileId { get; set; }
        public string ApplicationId { get; set; }
        public string Hash { get; set; }
    }
}
