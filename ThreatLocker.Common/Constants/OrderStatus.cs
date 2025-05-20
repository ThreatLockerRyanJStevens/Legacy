using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class OrderStatus
    {
        public static readonly OrderStatus Lead = new OrderStatus(1, "Lead");
        public static readonly OrderStatus Qualified = new OrderStatus(2, "Qualified");
        public static readonly OrderStatus Demo = new OrderStatus(3, "Demo");
        public static readonly OrderStatus Trial = new OrderStatus(4, "Trial");
        public static readonly OrderStatus Ramp = new OrderStatus(5, "Ramp");
        public static readonly OrderStatus OrderComplete = new OrderStatus(6, "Order Complete");
        public static readonly OrderStatus Dead = new OrderStatus(7, "Dead");
        public static readonly OrderStatus DoNotCall = new OrderStatus(8, "Do not call");

        public OrderStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly OrderStatus[] All =
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

        public static OrderStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static OrderStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
