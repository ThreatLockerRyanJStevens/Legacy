using ThreatLocker.Framework;
using ThreatLocker.Framework.Utils;

namespace ThreatLocker.Framework_UnitTests
{
    public class ScheduleTests : BaseTest
    {
        #region GetNextSchedule

        [Theory(DisplayName = "GetNextSchedule: Returns the next available schedule date.", Skip = "Unable to test")]
        [InlineData("2025-05-13T14:00:00", new[] { DayOfWeek.Tuesday, DayOfWeek.Wednesday }, new[] { 13, 15, 16 }, "2025-05-13T15:00:00")]
        [InlineData("2025-05-13T14:00:00", new[] { DayOfWeek.Thursday, DayOfWeek.Friday }, new[] { 13, 15, 16 }, "2025-05-15T13:00:00")]
        public void GetNextSchedule_ReturnNextDate(DateTime utcNow, DayOfWeek[] days, int[] hours, DateTime expected)
        {
            //var result = Schedule.GetNextSchedule(days.ToList(), hours.ToList(), utcNow);
            //Assert.Equal(expected, result);
        }

        #endregion

        #region GetSleepTimer

        [Theory(DisplayName = "GetSleepTimer: Returns interval for code sleep.", Skip = "Unable to test")]
        [InlineData("2025-05-13T14:00:00", "2025-05-13T16:00:00", 7200)]
        [InlineData("2025-05-13T14:00:00", "2025-05-13T00:00:00", 0)]
        public void GetSleepTimer_ReturnSleepInterval(DateTime utcNow, DateTime target, int expected)
        {
            //var result = Schedule.GetSleepTimer(target, utcNow);
            //Assert.Equal(expected, result);
        }

        #endregion

        #region GetHourStart

        [Theory(DisplayName = "GetHourStart: Returns a start time.")]
        [InlineData("2025-05-13T14:00:00", "2025-05-13T14:00:00")]
        [InlineData("2025-05-13T14:45:00", "2025-05-13T14:00:00")]
        [InlineData("2025-05-13T14:34:46", "2025-05-13T14:00:00")]
        public void GetHourStart_ReturnStartTime(DateTime source, DateTime expected)
        {
            var result = Schedule.GetHourStart(source);
            Assert.Equal(expected, result);
        }

        #endregion

    }
}
