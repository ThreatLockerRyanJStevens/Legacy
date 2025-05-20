using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class TrayFileDownloadStatus
    {
        public static readonly TrayFileDownloadStatus Pending = new TrayFileDownloadStatus(1, "pending");
        public static readonly TrayFileDownloadStatus Downloaded = new TrayFileDownloadStatus(2, "downloaded");

        public TrayFileDownloadStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TrayFileDownloadStatus[] All =
        {
            Pending, 
            Downloaded
        };

        public static TrayFileDownloadStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
