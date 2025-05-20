using System.Linq;

namespace ThreatLocker.Shared.Constants.MutualPlan
{
    public class MutualPlanTaskNoteStatusType
    {
        public static readonly MutualPlanTaskNoteStatusType Archived = new MutualPlanTaskNoteStatusType(0, "Archived");
        public static readonly MutualPlanTaskNoteStatusType Active = new MutualPlanTaskNoteStatusType(1, "Active");
        public static readonly MutualPlanTaskNoteStatusType Deleted = new MutualPlanTaskNoteStatusType(2, "Deleted");

        public MutualPlanTaskNoteStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly MutualPlanTaskNoteStatusType[] All =
        {
            Archived,
            Active,
            Deleted
        };

        public static MutualPlanTaskNoteStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static MutualPlanTaskNoteStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
