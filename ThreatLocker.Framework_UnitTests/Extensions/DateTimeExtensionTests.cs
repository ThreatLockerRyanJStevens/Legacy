using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class DateTimeExtensionTests : BaseTest
    {

        #region IsBetween (DateTime, DateTime, DateTime)

        [Theory(DisplayName ="IsBetween: Return True")]
        [InlineData("2025-01-15 02:00:00", "2025-01-14 02:00:00", "2025-01-16 02:00:00")]
        [InlineData("2025-01-15 02:00:00", "2025-01-15 01:00:00", "2025-01-15 03:00:00")]
        [InlineData("2025-01-15 02:00:00", "2025-01-15 01:59:99", "2025-01-15 02:00:01")]
        [InlineData("2025-01-15 02:00:00", "2025-01-15 01:59:99.999", "2025-01-15 02:00:00.001")]
        public void IsBetween_ReturnTrue(string subjectDate, string startDate, string endDate)
        {
            var subject = subjectDate.ToSafeDateTime();
            var start = startDate.ToSafeDateTime();
            var end = endDate.ToSafeDateTime();

            Assert.True(subject.IsBetween(start, end)); 
        }

        [Theory(DisplayName = "IsBetween: Return False")]
        [InlineData("2025-01-15 01:00:00", "2025-01-15 02:00:00", "2025-01-15 03:00:00")]
        [InlineData("2025-01-15 04:00:00", "2025-01-15 02:00:00", "2025-01-15 03:00:00")]
        [InlineData("2025-01-15 02:00:00", "2025-01-15 02:00:00", "2025-01-15 02:00:00")]
        public void IsBetween_ReturnFalse(string subjectDate, string startDate, string endDate)
        {
            var subject = subjectDate.ToSafeDateTime();
            var start = startDate.ToSafeDateTime();
            var end = endDate.ToSafeDateTime();

            Assert.False(subject.IsBetween(start, end));
        }

        #endregion

        #region IsMinDateTimeOrNull (DateTime?)

        [Fact(DisplayName ="IsMinDateTimeOrNull: Return True for Null")]
        public void IsMinDateTimeOrNull_ReturnTrueNull()
        {
            Assert.True(((DateTime?)null).IsMinDateTimeOrNull());
        }

        [Fact(DisplayName = "IsMinDateTimeOrNull: Return True for Min Value")]
        public void IsMinDateTimeOrNull_ReturnTrueMinValue()
        {
            Assert.True(((DateTime?)DateTime.MinValue).IsMinDateTimeOrNull());
        }

        [Fact(DisplayName = "IsMinDateTimeOrNull: Return False for a valid date")]
        public void IsMinDateTimeOrNull_ReturnFalseDate()
        {
            Assert.False(((DateTime?)new DateTime(2025,01,15)).IsMinDateTimeOrNull());
        }
        #endregion

        #region IsMinDateTime (DateTime)
        [Fact(DisplayName = "IsMinDateTime: Returns True.")]
        public void IsMinDateTime_ReturnsTrue()
        {
            var subject = DateTime.MinValue;
            Assert.True(subject.IsMinDateTime());
        }

        [Theory(DisplayName = "IsMinDateTime: Returns False.")]
        [InlineData("2025-01-01 12:45:11")]
        [InlineData("2025-01-01")]
        [InlineData("2025-01-01 12:45:11.000")]
        [InlineData("2025-05-01T14:30:00Z")]
        public void IsMinDateTime_ReturnsFalse(string datetime)
        {
            var subject = datetime.ToSafeDateTime();
            Assert.False(subject.IsMinDateTime());
        }

        #endregion

        #region ToSafeDateTime (object)
        [Fact(DisplayName = "ToSafeDateTime: From Same")]
        public void ToSafeDateTime_FromSame()
        {
            var expected = fixture.Create<DateTime>();
            Assert.Equal(expected, expected.ToSafeDateTime());
        }

        [Theory(DisplayName = "ToSafeDateTime: Returns DateTime with valid Date/Time.")]
        [InlineData("2025-01-01 12:45:11")]
        [InlineData("2025-01-01")]
        [InlineData("2025-01-01 12:45:11.000")]
        [InlineData("2025-05-01T14:30:00Z")]
        public void ToSafeDateTime_ReturnsDateTime(string datetime)
        {
            var result = datetime.ToSafeDateTime();
            Assert.NotNull(result);
            Assert.NotEqual(DateTime.MinValue, result);
            Assert.NotEqual(new DateTime(), result);
        }


        [Fact(DisplayName = "ToSafeDateTime: Returns Matching value")]
        public void ToSafeDateTime_MatchingValue()
        {
            var result = "2025-01-04 12:45:11.486".ToSafeDateTime();

            Assert.Equal(2025, result.Year);
            Assert.Equal(1, result.Month);
            Assert.Equal(4, result.Day);
            Assert.Equal(12, result.Hour);
            Assert.Equal(45, result.Minute);
            Assert.Equal(11, result.Second);
            Assert.Equal(486, result.Millisecond);
        }

        [Theory(DisplayName = "ToSafeDateTime: Returns empty date with invalid Date/Time")]
        [InlineData("")]
        [InlineData("asdfsdf")]
        [InlineData("2015-45-45")]
        public void ToSafeDateTime_ReturnsEmptyDate(string datetime)
        {
            Assert.Equal(new DateTime(), datetime.ToSafeDateTime());
        }

        [Fact(DisplayName = "ToSafeDateTime: Handles null target.")]
        public void ToSafeDateTime_HandlesNullTarget()
        {
            string? subject = null;
            subject.ToSafeDateTime();
        }
        #endregion

        #region ToSafeNullableDateTime (object)

        [Theory(DisplayName = "ToSafeNullableDateTime: From Same")]
        [InlineData("2025-01-01 12:45:11")]
        [InlineData("2025-01-01")]
        [InlineData("2025-01-01 12:45:11.000")]
        [InlineData("2025-05-01T14:30:00Z")]
        public void ToSafeNullableDateTime_FromSame(string datetime)
        {
            var result = datetime.ToSafeNullableDateTime();
            Assert.NotNull(result);
        }

        [Fact(DisplayName ="ToSafeNullableDateTime: Returns Matching value")]
        public void ToSafeNullableDateTime_MatchingValue()
        {
            var result = "2025-01-04 12:45:11.486".ToSafeNullableDateTime();

            Assert.NotNull(result);
            Assert.Equal(2025, result.Value.Year);
            Assert.Equal(1, result.Value.Month);
            Assert.Equal(4, result.Value.Day);
            Assert.Equal(12, result.Value.Hour);
            Assert.Equal(45, result.Value.Minute);
            Assert.Equal(11, result.Value.Second);
            Assert.Equal(486, result.Value.Millisecond);
        }


        [Theory(DisplayName = "ToSafeNullableDateTime: Returns NULL with invalid Date/Time")]
        [InlineData("")]
        [InlineData("asdfsdf")]
        [InlineData("2015-45-45")]
        public void ToSafeNullableDateTime_ReturnsNull(string datetime)
        {
            Assert.Null(datetime.ToSafeNullableDateTime());
        }

        [Fact(DisplayName ="ToSafeNullableDateTime: Handles null target.")]
        public void ToSafeNullableDateTime_HandlesNullTarget()
        {
            string? subject = null;
            subject.ToSafeNullableDateTime();
        }

#endregion

        #region ToSafePreciseDateTime (object)
        [Theory(DisplayName = "ToSafePreciseDateTime: Returns DateTime object.")]
        [InlineData("2025-01-01 12:45:11")]
        [InlineData("2025-01-01")]
        [InlineData("2025-01-01 12:45:11.000")]
        [InlineData("2025-05-01T14:30:00Z")]
        [InlineData("")]
        [InlineData("asdfsdf")]
        [InlineData("2015-45-45")]
        public void ToSafePreciseDateTime_ReturnsDateTime(string datetime)
        {
            var subject = datetime.ToSafeNullableDateTime();
            var result = subject.ToSafePreciseDateTime();
            Assert.NotNull(result);   
        }

        [Fact(DisplayName = "ToSafePreciseDateTime: Handles null target.")]
        public void ToSafePreciseDateTime_HandlesNullTarget()
        {
            string? subject = null;
            subject.ToSafePreciseDateTime();
        }
        #endregion
    }
}
