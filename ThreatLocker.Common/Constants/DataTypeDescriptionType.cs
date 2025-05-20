using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class DataTypeDescriptionType
    {
        public static readonly DataTypeDescriptionType DateTime = new DataTypeDescriptionType(1, "DateTime");
        public static readonly DataTypeDescriptionType String = new DataTypeDescriptionType(2, "String");
        public static readonly DataTypeDescriptionType Boolean = new DataTypeDescriptionType(3, "Boolean");
        public static readonly DataTypeDescriptionType Guid = new DataTypeDescriptionType(4, "Guid");

        public DataTypeDescriptionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public static readonly DataTypeDescriptionType[] All =
        {
            DateTime,
            String,
            Guid
        };

        // Optional Find method.
        public static DataTypeDescriptionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
