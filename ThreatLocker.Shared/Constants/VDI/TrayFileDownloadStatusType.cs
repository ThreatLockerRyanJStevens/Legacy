using System.Linq;

namespace ThreatLocker.Shared.Constants.VDI
{
    public class TrayFileDownloadStatus
    {
        public static readonly TrayFileDownloadStatus Pending = new TrayFileDownloadStatus(1, "Pending");
        public static readonly TrayFileDownloadStatus Downloaded = new TrayFileDownloadStatus(2, "Downloaded");

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

        //Optional Find method
        public static TrayFileDownloadStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static TrayFileDownloadStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
