using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ElevationType
    {
        public static readonly ElevationType DoNotElevate = new ElevationType(0, "Do Not Elevate");
        public static readonly ElevationType AllowElevation = new ElevationType(1, "Allow Elevation");
        public static readonly ElevationType ElevateSilently = new ElevationType(2, "Elevate Silently");
        public static readonly ElevationType SilentRevokeElevation = new ElevationType(3, "Block Elevation");

        public ElevationType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ElevationType[] All =
        {
            DoNotElevate,
            AllowElevation,
            ElevateSilently,
            SilentRevokeElevation
        };

        public static readonly ElevationType[] Elevate =
        {
            AllowElevation,
            ElevateSilently,
            SilentRevokeElevation,
        };

        public static ElevationType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static bool IsElevate(int elevationTypeId)
        {
            return Elevate.Any(x => x.Id == elevationTypeId);
        }
    }
}
