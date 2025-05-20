using ThreatLockerCommon.Constants;

namespace ThreatLockerCommon.Models
{
    public class AttributeType_old<T> : ThreatLockerAttribute_old
    {
        public AttributeType_old(int id, string name, bool isArray = false)
        {
            Id = id;
            Name = name;
        }
    }

    public class AttributeType<T> : ThreatLockerAttribute
    {
        public AttributeType(int id, string name, bool isArray = false)
        {
            Id = id;
            Name = name;
            IsArray = isArray;
        }
    }
}
