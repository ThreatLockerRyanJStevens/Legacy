using System.Linq;

namespace ThreatLocker.Shared.Constants.Organization
{
    public class OrganizationOrderType
    {
        public static readonly OrganizationOrderType Duedatetime = new OrganizationOrderType(0, "duedatetime");
        public static readonly OrganizationOrderType InvoiceDate = new OrganizationOrderType(1, "invoicedate");
        public static readonly OrganizationOrderType Lastlogin = new OrganizationOrderType(1, "lastlogin");
        public static readonly OrganizationOrderType Touchdate = new OrganizationOrderType(1, "touchdate");
        public static readonly OrganizationOrderType DateAdded = new OrganizationOrderType(1, "dateadded");
        public static readonly OrganizationOrderType TargetSeats = new OrganizationOrderType(1, "targetseats");
        public static readonly OrganizationOrderType TotalSeats = new OrganizationOrderType(1, "totalseats");

        public OrganizationOrderType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly OrganizationOrderType[] All =
        {
            Duedatetime,
            InvoiceDate,
            Lastlogin,
            Touchdate,
            DateAdded,
            TargetSeats,
            TotalSeats
        };

        public static readonly string[] ForBasicQuery =
        {
            Lastlogin.Name.ToLower(),
            DateAdded.Name.ToLower(),
            TargetSeats.Name.ToLower(),
            TotalSeats.Name.ToLower(),
            Touchdate.Name.ToLower()
        };

        public static OrganizationOrderType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static OrganizationOrderType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
