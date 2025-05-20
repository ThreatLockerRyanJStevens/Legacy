using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class StorageApproveByType
    {
        public static readonly StorageApproveByType Path = new StorageApproveByType(1, "Path");
        public static readonly StorageApproveByType SerialNumber = new StorageApproveByType(2, "Serial Number");

        public StorageApproveByType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly StorageApproveByType[] All =
        {
            Path,
            SerialNumber
        };

        public static StorageApproveByType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static StorageApproveByType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
