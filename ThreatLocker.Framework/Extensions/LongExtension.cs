using System;

namespace ThreatLocker.Framework.Extensions
{
    public static class LongExtension
    {
        public static long ToSafeLong(this object value) => ToSafeNullableLong(value).GetValueOrDefault();

        public static long? ToSafeNullableLong(this object value)
        {
            try
            {
                long testVal = default(long);

                if (long.TryParse(value.ToSafeString(), out testVal))
                    return testVal;

                return default(long?);
            }
            catch (Exception)
            {
                return default(long?);
            }
        }
    }
}
