using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ComputerGroupTypes
    {
        public static readonly ComputerGroupTypes StatusRegular = new ComputerGroupTypes(1, "Regular");
        public static readonly ComputerGroupTypes StatusRemoval = new ComputerGroupTypes(2, "StatusRemoval");

        public ComputerGroupTypes(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ComputerGroupTypes[] All =
        {
            StatusRegular,
            StatusRemoval
        };

        public static ComputerGroupTypes Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ComputerGroupTypes FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
