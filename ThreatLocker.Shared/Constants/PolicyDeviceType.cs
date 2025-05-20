namespace ThreatLocker.Shared.Constants
{
    public class PolicyDeviceType
    {
        public static readonly PolicyDeviceType All = new (string.Empty);
        public static readonly PolicyDeviceType USB = new ("USB");
        public static readonly PolicyDeviceType DVD = new ("DVD");
        public static readonly PolicyDeviceType UNC = new ("UNC");
        public static readonly PolicyDeviceType SCSI = new ("SCSI");
        public static readonly PolicyDeviceType SATA = new ("SATA");
        public static readonly PolicyDeviceType IDE = new ("IDE");
        public static readonly PolicyDeviceType UserProfileDisk = new ("FILEBACKEDVIRTUAL");
        public static readonly PolicyDeviceType NVME = new ("NVME");
        public static readonly PolicyDeviceType PCIE = new ("PCIE");
        public static readonly PolicyDeviceType SDCX = new ("SD Card");

        public string Value { get; set; }

        PolicyDeviceType(string value)
        {
            Value = value;
        }

        public static readonly PolicyDeviceType[] AllTypes =
        {
            USB,
            DVD,
            UNC,
            SCSI,
            SATA,
            IDE,
            UserProfileDisk,
            NVME,
            PCIE,
            SDCX,
        };
    }
}
