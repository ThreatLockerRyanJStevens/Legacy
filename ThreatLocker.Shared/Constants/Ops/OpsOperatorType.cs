namespace ThreatLocker.Shared.Constants.Ops
{
    public enum OpsOperatorType
    {
        Matches = 1,
        DoesNotMatch = 2,
        StartsWith = 3,
        EndsWith = 4,
        Contains = 5,
        DoesNotContain = 6,
        RegExMatches = 7,
        LessThan = 8,
        LessThanOrEqualTo = 9,
        GreaterThan = 10,
        GreaterThanOrEqualTo = 11,
    }
}
