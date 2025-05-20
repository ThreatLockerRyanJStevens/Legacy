using System;

namespace ThreatLockerCommon.Enums
{
    [Flags]
    public enum Protocol
    {
        None = 0,
        TCP = 1,
        UDP = 2
    }
}
