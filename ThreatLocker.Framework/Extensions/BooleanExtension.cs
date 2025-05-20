using System;

namespace ThreatLocker.Framework.Extensions
{
    public static class BooleanExtension
    {
        public static bool ToSafeBool(this object value) => ToSafeNullableBool(value).GetValueOrDefault();

        public static bool? ToSafeNullableBool(this object value)
        {
            try
            {
                if (value == null)
                {
                    return default(bool?);
                }
                else if (value.GetType() == typeof(int))
                {
                    return Convert.ToBoolean(value);
                }
                else
                {
                    if (int.TryParse(value.ToSafeString(), out int _))
                    {
                        return Convert.ToBoolean(value.ToSafeInt());
                    }
                    else
                    {
                        bool testVal = default(bool);

                        if (bool.TryParse(value.ToSafeString(), out testVal))
                        {
                            return testVal;
                        }
                    }
                }

                return default(bool?);
            }
            catch (Exception)
            {
                return default(bool?);
            }
        }
    }
}
