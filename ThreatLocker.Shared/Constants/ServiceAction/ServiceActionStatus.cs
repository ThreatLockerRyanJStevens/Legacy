using System.Linq;

namespace ThreatLocker.Shared.Constants.ServiceAction
{
    public class ServiceActionStatus
    {
        public static readonly ServiceActionStatus Pending = new ServiceActionStatus(0, "Pending");
        public static readonly ServiceActionStatus Executed = new ServiceActionStatus(1, "Executed");
        public static readonly ServiceActionStatus Cancelled = new ServiceActionStatus(2, "Cancelled");

        public ServiceActionStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ServiceActionStatus[] All =
        {
            Pending,
            Executed,
            Cancelled
        };

        public static ServiceActionStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ServiceActionStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
