using System.Linq;

namespace ThreatLocker.Shared.Constants.PermitApplication
{
    public class PermitActionType
    {
        /// <summary>
        /// Don't create any new policies, just update the application definition
        /// </summary>
        public static readonly PermitActionType None = new PermitActionType(0, "Update Application Files only");
        /// <summary>
        /// Permit the application without restriction
        /// </summary>
        public static readonly PermitActionType Permit = new PermitActionType(1, "Permit without Restriction");
        /// <summary>
        /// Permit the application and add Ringfencing restrictions
        /// </summary>
        public static readonly PermitActionType PermitWithRingfencing = new PermitActionType(2, "Permit with Ringfencing");
        /// <summary>
        /// Use suggested Ringfencing policy
        /// </summary>
        public static readonly PermitActionType SuggestedRingfencing = new PermitActionType(3, "Use Suggested Ringfencing Policy");

        public PermitActionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly PermitActionType[] All =
        {
            None,
            Permit,
            PermitWithRingfencing,
            SuggestedRingfencing
        };

        public static readonly int[] Permits =
        {
            Permit.Id,
            PermitWithRingfencing.Id
        };

        public static PermitActionType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static PermitActionType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
