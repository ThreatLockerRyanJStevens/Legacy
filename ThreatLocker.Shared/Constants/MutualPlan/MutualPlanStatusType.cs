using System.Linq;

namespace ThreatLocker.Shared.Constants.MutualPlan
{
    public class MutualPlanStatusType
    {
        public static readonly MutualPlanStatusType Draft = new MutualPlanStatusType(0, "Draft");
        public static readonly MutualPlanStatusType Published = new MutualPlanStatusType(1, "Published");

        public MutualPlanStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly MutualPlanStatusType[] All =
        {
            Draft,
            Published
        };

        public static MutualPlanStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static MutualPlanStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
