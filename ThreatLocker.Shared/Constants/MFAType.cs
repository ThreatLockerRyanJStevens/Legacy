using System.Collections.Generic;
using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class MFAType
    {
        public static readonly MFAType Off = new(-1, "Off");
        public static readonly MFAType None = new(0, "None");
        public static readonly MFAType SMS = new(1, "SMS");
        public static readonly MFAType DUO = new(2, "DUO");
        public static readonly MFAType Passwordless = new(3, "Passwordless");
        public static readonly MFAType OTC = new(4, "OTC");
        public static readonly MFAType TLApp = new(5, "TLApp");

        public MFAType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly MFAType[] All =
        {
            Off,
            None,
            SMS,
            DUO,
            Passwordless,
            OTC,
            TLApp
        };

        public static readonly MFAType[] AllForContacts =
        {
            Off,
            SMS,
            DUO,
            OTC
        };

        public static readonly MFAType[] EnforcedMFA =
        {
            OTC, SMS, DUO, Passwordless, TLApp
        };

        public static bool HasEnforcedMFA(List<string> mfas)
        {
            return EnforcedMFA.Any(m => mfas.Contains(m.Name));
        }

        // Optional Find method.
        public static MFAType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static List<MFAType> FindByNames(List<string> names)
        {
            return All.Where(x => names.Contains(x.Name) ).ToList();
        }

        public static MFAType FindByName(string name)
        {
            return All.FirstOrDefault(x => name == x.Name);
        }
    }
}