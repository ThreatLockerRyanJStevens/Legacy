using System;

namespace ThreatLocker.Framework.Extensions
{
    public static class DateTimeExtension
    {
        public static bool IsBetween(this DateTime dateToCheck, DateTime startDate, DateTime endDate)
        {
            return dateToCheck > startDate && dateToCheck < endDate;
        }

        public static bool IsMinDateTimeOrNull(this DateTime? dateTime) => !dateTime.HasValue || dateTime == DateTime.MinValue;
        public static bool IsMinDateTime(this DateTime dateTime) => dateTime == DateTime.MinValue;

        public static DateTime ToSafeDateTime(this object value) => ToSafeNullableDateTime(value).GetValueOrDefault();

        public static DateTime? ToSafeNullableDateTime(this object value)
        {
            try
            {
                DateTime testVal = default(DateTime);

                if (DateTime.TryParse(value.ToSafeString(), out testVal))
                    return testVal;

                return default(DateTime?);
            }
            catch (Exception)
            {
                return default(DateTime?);
            }
        }

        public static DateTime ToSafePreciseDateTime(this object value)
        {
			try
			{
                if (value == null)
                {
                    return default;
                }

                if (value is DateTime)
                {
                    return (DateTime) value;
                }

				return default;
			}
			catch (Exception)
			{
				return default;
			}
		}
	}
}
