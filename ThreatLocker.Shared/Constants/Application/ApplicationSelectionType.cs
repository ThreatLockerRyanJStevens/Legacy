using System.Linq;

namespace ThreatLocker.Shared.Constants.Application
{
    public class ApplicationSelectionType
    {
        public static readonly ApplicationSelectionType SpecificApplications = new ApplicationSelectionType(0, "Specific Applications");
        public static readonly ApplicationSelectionType AllApplications = new ApplicationSelectionType(1, "All Applications");
        public static readonly ApplicationSelectionType NewApplication = new ApplicationSelectionType(2, "New Application");

        public ApplicationSelectionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ApplicationSelectionType[] All =
        {
            SpecificApplications,
            AllApplications,
            NewApplication
        };

        public static ApplicationSelectionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ApplicationSelectionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
