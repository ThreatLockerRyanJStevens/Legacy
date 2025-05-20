using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class TwoFactorMethodType
    {
        public static readonly TwoFactorMethodType Off = new TwoFactorMethodType(1, "Off");
        public static readonly TwoFactorMethodType DUO = new TwoFactorMethodType(2, "DUO");
        public static readonly TwoFactorMethodType OTC = new TwoFactorMethodType(3, "OTC");

        public TwoFactorMethodType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TwoFactorMethodType[] All =
        {
            Off, 
            DUO
        };

        public static TwoFactorMethodType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TwoFactorMethodType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
