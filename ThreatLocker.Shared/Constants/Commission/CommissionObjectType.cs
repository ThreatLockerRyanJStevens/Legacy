using System.Linq;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Shared.Constants
{
    public class CommissionObjectType
    {
        public static readonly CommissionObjectType Quote = new (1, "Quote");

        public CommissionObjectType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public static implicit operator int(CommissionObjectType type) => type.Id;

        public static readonly CommissionObjectType[] All =
        {
            Quote
        };

        public static CommissionObjectType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CommissionObjectType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name.ToSafeString().ToLower() == name.ToSafeString().ToLower());
        }
    }
}
