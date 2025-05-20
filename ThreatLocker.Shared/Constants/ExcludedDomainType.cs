namespace ThreatLocker.Shared.Constants
{
    public class ExcludedDomainType
    {
        public static readonly ExcludedDomainType Marketing = new ExcludedDomainType(1, "marketing@threatlocker.com");
        public static readonly ExcludedDomainType Billing = new ExcludedDomainType(2, "billing@threatlocker.com");
        public static readonly ExcludedDomainType CyberHeros = new ExcludedDomainType(3, "cyberheros@threatlocker.com");
        public static readonly ExcludedDomainType Webinar = new ExcludedDomainType(4, "webinar@threatlocker.com");

        public ExcludedDomainType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly string[] All =
        {
            Marketing.Name,
            Billing.Name,
            CyberHeros.Name,
            Webinar.Name
        };

    }
}
