using System;
using System.Linq;

namespace ThreatLocker.Framework.Extensions
{
    public static class IntegerExtension
    {
        public static int ToSafeInt(this object value) => ToSafeNullableInt(value).GetValueOrDefault();

        public static int? ToSafeNullableInt(this object value)
        {
            try
            {
                if (value is Enum)
                {
                    return Convert.ToInt32(value);
                }
                else
                {
                    int testVal = default(int);

                    if (int.TryParse(value.ToSafeString(), out testVal))
                        return testVal;
                }

                return default(int?);
            }
            catch (Exception)
            {
                return default(int?);
            }
        }

        public static bool IsIn(this int i, params int[] args)
        {
            return args.Contains(i);
        }
    }
}
