using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class EntityType
    {
        public static readonly EntityType None = new EntityType(0, "None");
        public static readonly EntityType Organization = new EntityType(1, "Organization");
        public static readonly EntityType ComputerGroup = new EntityType(2, "Computer Group");
        public static readonly EntityType Computer = new EntityType(3, "Computer");
        public static readonly EntityType ApplicationPolicy = new EntityType(4, "Application Policy");
        public static readonly EntityType StoragePolicy = new EntityType(5, "Storage Policy");

        public EntityType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
        public static readonly EntityType[] All =
        {
            Organization,
            ComputerGroup,
            Computer
        };

        //Optional Find method
        public static EntityType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static EntityType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
