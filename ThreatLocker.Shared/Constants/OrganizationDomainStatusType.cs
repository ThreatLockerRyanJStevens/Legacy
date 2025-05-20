using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class OrganizationDomainStatusType
    {
        public static readonly int NotRegistered = 0;
        public static readonly int RegisteredToCurrentPartner = 1;
        public static readonly int RegisteredToThreatLockerLead = 2;
        public static readonly int RegisteredToAnotherPartner = 3;

        public static readonly int?[] All =
        {
            NotRegistered,
            RegisteredToCurrentPartner,
            RegisteredToThreatLockerLead,
            RegisteredToAnotherPartner
        };

        public static int Find(int id)
        {
            return All.FirstOrDefault(x => x.Value == id) ?? -1;
        }
    }
}
