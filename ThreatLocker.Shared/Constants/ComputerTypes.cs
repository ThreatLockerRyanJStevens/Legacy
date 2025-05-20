using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ComputerTypes
    {
        public static readonly ComputerTypes PolicyRemovalStatus = new ComputerTypes(2, "PolicyRemovalStatus");

        public ComputerTypes(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ComputerTypes[] All =
        {
            PolicyRemovalStatus
        };

        public static ComputerTypes Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ComputerTypes FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
