using System;

namespace ThreatLockerCommon.Constants
{
    public class ThreatLockerAddress
    {
        public static Guid Ireland => new Guid("DC210BA1-5C91-4805-B4EA-9CF2B994566D");
        public static Guid UnitedStatesInc => new Guid("91BCEDA2-0740-4232-9B1E-FD24B2E75C94");
        public static Guid UnitedStates => new Guid("1BCE1EF0-4FDA-4132-9062-2F07A6BA8D3E");
        public static Guid UnitedStatesIncNew => new Guid("C5BA49C9-26F7-4E1B-A0F9-C5894D198E6E");
        public static Guid UnitedStatesNew => new Guid("2B6030F8-F601-4DC6-B3A0-92225A725055");
        public static Guid AustraliaInc => new Guid("962795F4-6BFB-46AD-BE63-55E3E585CF5B");

        public static readonly Guid[] All =
        {
            Ireland,
            UnitedStatesInc,
            UnitedStates,
            UnitedStatesIncNew,
            UnitedStatesNew,
            AustraliaInc
        };

        public static readonly Guid[] AllUS =
        {
            UnitedStatesInc,
            UnitedStates,
            UnitedStatesIncNew,
            UnitedStatesNew
        };
    }
}
