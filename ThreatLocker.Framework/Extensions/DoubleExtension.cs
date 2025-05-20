using System;

namespace ThreatLocker.Framework.Extensions
{
    public static class DoubleExtension
    {
        public static double ToSafeDouble(this object value) => ToSafeNullableDouble(value).GetValueOrDefault();

        public static double? ToSafeNullableDouble(this object value)
        {
            try
            {
                double testVal = default(double);

                if (double.TryParse(value.ToSafeString(), out testVal))
                    return testVal;

                return default(double?);
            }
            catch (Exception)
            {
                return default(double?);
            }
        }
    }
}
