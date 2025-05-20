using System.Linq;

namespace ThreatLocker.Shared.Constants.Application
{
    public class ApplicationFileStatusType
    {
        public static readonly ApplicationFileStatusType Inactive = new ApplicationFileStatusType(0, "Inactive");
        public static readonly ApplicationFileStatusType Active = new ApplicationFileStatusType(1, "Active");

        public ApplicationFileStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ApplicationFileStatusType[] All =
        {
            Inactive,
            Active
        };

        public static ApplicationFileStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ApplicationFileStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
