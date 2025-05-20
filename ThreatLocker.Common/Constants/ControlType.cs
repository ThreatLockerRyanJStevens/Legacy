using System.Linq;

namespace ThreatLockerCommon.Constants
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

        public int Id { get; }
        public string Name { get; }

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
