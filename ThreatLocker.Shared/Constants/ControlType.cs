using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ControlType
    {
        public static readonly ControlType Button = new ControlType(1, "button");
        public static readonly ControlType Link = new ControlType(2, "link");

        public ControlType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ControlType[] All =
        {
            Button,
            Link
        };

        public static ControlType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ControlType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

    }
}
