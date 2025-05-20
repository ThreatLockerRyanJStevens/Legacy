using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class ProductLicenseCount
    {
        public int Platform { get; set; }
        public int DefaultDeny { get; set; }
        public int Ringfencing { get; set; }
        public int StorageControl { get; set; }
        public int Elevation { get; set; }
        public int NetworkAccessControl { get; set; }
        public int CyberHeroManagement { get; set; }
        public int CoManagedDirectSupport { get; set; }
        public int ConfigurationManagement { get; set; }
        public int ThreatLockerOps { get; set; }
        public int CyberHeroDetectionResponse { get; set; }

        public ProductLicenseCount()
        {

        }

        public ProductLicenseCount(int platform, int defaultDeny, int ringfencing, int storageControl, int elevation, int networkAccessControl,
            int cyberHeroManagement, int coManagedDirectSupport, int configurationManagement, int threatLockerOps, int cyberHeroDetectionResponse)
        {
            Platform = platform;
            DefaultDeny = defaultDeny;
            Ringfencing = ringfencing;
            StorageControl = storageControl;
            Elevation = elevation;
            NetworkAccessControl = networkAccessControl;
            CyberHeroManagement = cyberHeroManagement;
            CoManagedDirectSupport = coManagedDirectSupport;
            ConfigurationManagement = configurationManagement;
            ThreatLockerOps = threatLockerOps;
            CyberHeroDetectionResponse = cyberHeroDetectionResponse;
        }

        public ProductLicenseCount(int value)
        {
            Platform = value;
            DefaultDeny = value;
            Ringfencing = value;
            StorageControl = value;
            Elevation = value;
            NetworkAccessControl = value;
            CyberHeroManagement = value;
            CoManagedDirectSupport = value;
            ConfigurationManagement = value;
            ThreatLockerOps = value;
            CyberHeroDetectionResponse = value;
        }
    }
}
