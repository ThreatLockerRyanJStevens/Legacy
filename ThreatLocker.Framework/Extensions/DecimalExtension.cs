using System;

namespace ThreatLocker.Framework.Extensions
{
    public static class DecimalExtension
    {
        public static decimal ToSafeDecimal(this object value) => ToSafeNullableDecimal(value).GetValueOrDefault();

        public static decimal? ToSafeNullableDecimal(this object value)
        {
            try
            {
                decimal testVal = default(decimal);

                if (decimal.TryParse(value.ToSafeString(), out testVal))
                    return testVal;

                return default(decimal?);
            }
            catch (Exception)
            {
                return default(decimal?);
            }
        }
    }
}
