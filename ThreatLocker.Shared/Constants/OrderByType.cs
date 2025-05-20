using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class OrderByType
    {
        public static readonly OrderByType LastCheckIn = new OrderByType(1, "LastCheckIn");
        public static readonly OrderByType LastCheckInDesc = new OrderByType(2, "LastCheckInDesc");
        public static readonly OrderByType NameOrder = new OrderByType(3, "Name");
        public static readonly OrderByType DeniedCountThreeDays = new OrderByType(4, "DeniedCountThreeDays");

        public OrderByType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly OrderByType[] All =
        {
            LastCheckIn,
            LastCheckInDesc,
            NameOrder
        };

        public static OrderByType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static OrderByType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
