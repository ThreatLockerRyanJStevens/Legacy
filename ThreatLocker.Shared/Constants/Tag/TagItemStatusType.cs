using System.Linq;

namespace ThreatLocker.Shared.Constants.Tag
{
    public class TagItemStatusType
    {
        public static readonly TagItemStatusType Enabled = new TagItemStatusType(1, "Enabled");
        public static readonly TagItemStatusType Disabled = new TagItemStatusType(2, "Disabled");

        public TagItemStatusType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TagItemStatusType[] All =
        {
            Enabled,
            Disabled
        };

        public static TagItemStatusType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TagItemStatusType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToLower() == name);
        }
    }
}
