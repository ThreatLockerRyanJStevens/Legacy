using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class MissingHashStatus
    {
        public static readonly MissingHashStatus Pending = new MissingHashStatus(1, "Pending");
        public static readonly MissingHashStatus Resolved = new MissingHashStatus(2, "Resolved");
        public static readonly MissingHashStatus CantFindHash = new MissingHashStatus(3, "Can't Find Hash");
        
        public MissingHashStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly MissingHashStatus[] All =
        {
            Pending,
            Resolved,
            CantFindHash
        };

        //Optional Find method
        public static MissingHashStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static MissingHashStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}

