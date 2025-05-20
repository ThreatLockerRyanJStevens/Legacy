using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ObjectType
    {
        public static readonly ObjectType Unknown = new ObjectType(0, "Unknown");
        public static readonly ObjectType User = new ObjectType(1, "User");
        public static readonly ObjectType Organization = new ObjectType(2, "Organization");

        public ObjectType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ObjectType[] All =
        {
            Unknown,
            User,
            Organization
        };

        // Optional Find method.
        public static ObjectType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
