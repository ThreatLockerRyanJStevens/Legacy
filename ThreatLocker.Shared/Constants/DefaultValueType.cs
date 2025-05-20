using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class DefaultValueType
    {
        public static readonly DefaultValueType None = new DefaultValueType(1, "none");

        public DefaultValueType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly DefaultValueType[] All =
        {
            None
        };

        public static DefaultValueType Find(int value)
        {
            return All.FirstOrDefault(x => x.Id == value);
        }

        public static DefaultValueType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
