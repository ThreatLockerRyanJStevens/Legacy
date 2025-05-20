using System;
using System.Collections.Generic;
using System.Linq;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework.Utils
{
    public class Schedule
    {
        public static List<DayOfWeek> EveryDay = new List<DayOfWeek>()
        {
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday,
            DayOfWeek.Saturday,
            DayOfWeek.Sunday
        };

        public static List<DayOfWeek> Weekdays = new List<DayOfWeek>()
        {
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday
        };

        public static List<int> Midnight = new List<int>() { 0 };

        public static List<int> EveryHour = new List<int>()
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23
        };

        public static DateTime GetNextSchedule(List<DayOfWeek> days, List<int> hours)
        {
            DateTime ret = DateTime.UtcNow;

            try
            {
                List<DayOfWeek> srDays = days;
                List<int> srHours = hours;

                srDays.Sort();
                srHours.Sort();

                DateTime now = DateTime.UtcNow;
                DayOfWeek currentDay = now.DayOfWeek;
                int currentHour = now.Hour;

                List<DayOfWeek> sortedDays = srDays.Where(x => x >= currentDay).ToList();
                sortedDays.AddRange(srDays.Where(x => x < currentDay).ToList());

                DayOfWeek nextDay = sortedDays.First();

                List<int> sortedHours = new List<int>();
                if (nextDay == currentDay)
                {
                    sortedHours = srHours.Where(x => x > currentHour).ToList();
                    sortedHours.AddRange(srHours.Where(x => x <= currentHour).ToList());
                }
                else
                {
                    sortedHours = srHours;
                }

                int nextHour = sortedHours.First();
                int daysToNext = nextDay - currentDay;


                if (nextHour <= currentHour)
                {
                    if (sortedDays.Where(x => x != currentDay).ToList().Any())
                    {
                        nextDay = sortedDays.First(x => x != currentDay);
                        daysToNext = nextDay - currentDay;
                    }
                    else
                    {
                        daysToNext += 7;
                    }
                }

                if (daysToNext < 0)
                {
                    daysToNext += 7;
                }

                ret = DateTime.Today.AddDays(daysToNext).AddHours(nextHour);
            }
            catch (Exception ex)
            {
                //Logger.Log($"Failed", exception: ex);
            }

            return ret;
        }

        public static int GetSleepTimer(DateTime target)
        {
            int timer = 0;

            try
            {
                timer = Math.Round(target.Subtract(DateTime.UtcNow).TotalSeconds, 0).ToSafeInt();

                if (timer < 0)
                    timer = 0;
            }
            catch (Exception ex)
            {
                //Logger.Log($"Current DateTime: {DateTime.UtcNow} - Target DateTime: {target}", exception: ex);
            }

            return timer;
        }

        public static DateTime GetHourStart(DateTime dateTime) => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0);
    }
}
