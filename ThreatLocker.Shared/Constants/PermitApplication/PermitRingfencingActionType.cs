using System.Linq;

namespace ThreatLocker.Shared.Constants.PermitApplication
{
    public class PermitRingfencingActionType
    {
        /// <summary>
        /// Don't create any new policies, just update the application definition
        /// </summary>
        public static readonly PermitRingfencingActionType None = new PermitRingfencingActionType(0, "Permit without Restriction");
        /// <summary>
        /// Permit the application and add Ringfencing restrictions
        /// </summary>
        public static readonly PermitRingfencingActionType Custom = new PermitRingfencingActionType(1, "Permit with Ringfencing");
        /// <summary>
        /// Use suggested Ringfencing policy
        /// </summary>
        public static readonly PermitRingfencingActionType Suggested = new PermitRingfencingActionType(2, "Use Suggested Ringfencing Policy");

        public PermitRingfencingActionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PermitRingfencingActionType[] All =
        {
            None,
            Custom,
            Suggested
        };

        public static PermitRingfencingActionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PermitRingfencingActionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
