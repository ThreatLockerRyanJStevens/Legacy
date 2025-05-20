using System;

namespace ThreatLocker.Framework.Extensions
{
    public static class ShortExtension
    {
        public static short ToSafeShort(this object value) => ToSafeNullableShort(value).GetValueOrDefault();

        public static short? ToSafeNullableShort(this object value)
        {
            try
            {
                short testVal = default(short);

                if (short.TryParse(value.ToSafeString(), out testVal))
                    return testVal;

                return default(short?);
            }
            catch (Exception)
            {
                return default(short?);
            }
        }
    }
}
