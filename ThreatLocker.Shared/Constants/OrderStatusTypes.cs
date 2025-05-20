

using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class OrderStatusTypes
    {
        public static readonly OrderStatusTypes Lead = new OrderStatusTypes(1, "Lead");
        public static readonly OrderStatusTypes Qualified = new OrderStatusTypes(2, "Qualified");
        public static readonly OrderStatusTypes Demo = new OrderStatusTypes(3, "Demo");
        public static readonly OrderStatusTypes Trial = new OrderStatusTypes(4, "Trial");
        public static readonly OrderStatusTypes Ramp = new OrderStatusTypes(5, "Ramp");
        public static readonly OrderStatusTypes OrderComplete = new OrderStatusTypes(6, "Order Complete");
        public static readonly OrderStatusTypes Dead = new OrderStatusTypes(7, "Dead");
        public static readonly OrderStatusTypes DoNotCall = new OrderStatusTypes(8, "Do not call");

        public OrderStatusTypes(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly OrderStatusTypes[] All =
        {
            Lead,
            Qualified,
            Demo,
            Trial,
            Ramp,
            OrderComplete,
            Dead,
            DoNotCall
        };

        public static readonly int[] AllIds =
        {
            Lead.Id,
            Qualified.Id,
            Demo.Id,
            Trial.Id,
            Ramp.Id,
            OrderComplete.Id,
            Dead.Id,
            DoNotCall.Id
        };

        // Optional Find method.
        public static OrderStatusTypes Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
