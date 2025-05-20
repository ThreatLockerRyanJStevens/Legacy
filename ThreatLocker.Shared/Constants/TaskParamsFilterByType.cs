using System;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class TaskParamsFilterByType
    {
        public static readonly TaskParamsFilterByType FilterNoPriority = new TaskParamsFilterByType(Guid.Empty, "none");
        public static readonly TaskParamsFilterByType FilterLowPriority = new TaskParamsFilterByType(Guid.Parse("F8DE61AA-34AC-4F34-A4A1-0EEC20AB8191"), "low");
        public static readonly TaskParamsFilterByType FilterMediumPriority = new TaskParamsFilterByType(Guid.Parse("F7157024-C0E1-479E-B459-FB9BD582454C"), "medium");
        public static readonly TaskParamsFilterByType FilterHighPriority = new TaskParamsFilterByType(Guid.Parse("57EA213C-6E01-4CA1-B893-F622D3BBA0BB"), "high");

        public TaskParamsFilterByType(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public static readonly TaskParamsFilterByType[] All =
        {
            FilterNoPriority,
            FilterLowPriority,
            FilterMediumPriority,
            FilterHighPriority
        };

        public static TaskParamsFilterByType Find(Guid id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TaskParamsFilterByType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}