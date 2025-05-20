using System.Linq;

namespace ThreatLocker.Shared.Constants.Application
{
    public class ApplicationStatus
    {
        public static readonly ApplicationStatus BuiltInMerge = new ApplicationStatus(0, "Built-In Merge");
        public static readonly ApplicationStatus Active = new ApplicationStatus(1, "Active");
        public static readonly ApplicationStatus Deleted = new ApplicationStatus(2, "Deleted");
        public static readonly ApplicationStatus Merged = new ApplicationStatus(3, "Merged");

        public ApplicationStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ApplicationStatus[] All =
       {
            BuiltInMerge,
            Active,
            Deleted,
            Merged
       };

        public static ApplicationStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ApplicationStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
