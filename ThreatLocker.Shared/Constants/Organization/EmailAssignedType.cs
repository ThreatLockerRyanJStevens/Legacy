using System.Linq;

namespace ThreatLocker.Shared.Constants.Organization
{
    public class EmailAssignedType
    {
        public static readonly EmailAssignedType SalesEngineer = new EmailAssignedType(0, "Sales Engineer");
        public static readonly EmailAssignedType SalesPerson = new EmailAssignedType(1, "Sales Person");


        public EmailAssignedType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly EmailAssignedType[] All =
       {
            SalesEngineer,
            SalesPerson
       };

        public static EmailAssignedType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static EmailAssignedType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
