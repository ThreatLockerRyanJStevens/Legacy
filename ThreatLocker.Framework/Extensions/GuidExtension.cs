using System;
using System.Linq;

namespace ThreatLocker.Framework.Extensions
{
    public static class GuidExtension
    {
        public static Guid ToSafeGuid(this object value) => ToSafeNullableGuid(value).GetValueOrDefault();

        public static Guid? ToSafeNullableGuid(this object value)
        {
            try
            {
                if (Guid.TryParse(value.ToSafeString(), out Guid testVal))
                {
                    return testVal;
                }

                return default;
            }
            catch
            {
                return default;
            }
        }

        public static bool IsEmptyGuid(this Guid guid)
        {
            return guid.Equals(Guid.Empty);
        }

        public static bool IsNullOrEmpty(this Guid? guid)
        {
            return !guid.HasValue || guid.Value.Equals(Guid.Empty);
        }

        public static bool IsNotNullOrEmpty(this Guid? guid)
        {
            return guid.HasValue && !guid.Value.Equals(Guid.Empty);
        }

        public static bool IsIn(this Guid g, params Guid[] args)
        {
            return args?.Any((Guid x) => x.Equals(g)) ?? false;
        }
    }
}
