namespace RulesEngine
{
    public enum RuleOperation
    {
        Equal = 1,
        NotEqual = 2,
        StartsWith = 3,
        EndsWith = 4,
        Contains = 5,
        NotContains = 6,
        RegexIsMatch = 7,
        LessThan = 8,
        LessThanOrEqual = 9,
        GreaterThan = 10,
        GreaterThanOrEqual = 11,
        DateIs = 12,
        DateIsNot = 13,
        DateIsBefore = 14,
        DateIsAfter = 15,
        IsInTag = 16
    }
}
