using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class LongExtensionTests : BaseTest
    {
        #region ToSafeLong

        [Fact(DisplayName = "ToSafeLong: From Same")]
        public void ToSafeLong_FromSame()
        {
            var expected = fixture.Create<long>();
            Assert.Equal(expected, expected.ToSafeLong());
        }

        [Theory(DisplayName = "ToSafeLong: Returns a value.")]
        [InlineData("234.23", 234)]
        [InlineData("-234.23", -234)]
        [InlineData(-234.23, -23)]
        [InlineData("ss", 0)]
        [InlineData("0", 0)]
        [InlineData(45, 45)]
        [InlineData(4564.456F, 4564)]
        [InlineData(4564.456D, 4564)]
        public void ToSafeLong_ReturnValue(object value, long expected)
        {
            Assert.Equal(expected, value.ToSafeLong());
        }

        [Fact(DisplayName = "ToSafeLong: Returns value from long")]
        public void ToSafeLong_ReturnFromLong() => Assert.Equal((long)23423, ((long)23423).ToSafeLong());
        #endregion

        #region ToSafeNullableLong

        [Fact(DisplayName = "ToSafeNullableLong: From Same")]
        public void ToSafeNullableLong_FromSame()
        {
            var expected = fixture.Create<long>();
            Assert.Equal(expected, expected.ToSafeNullableLong());
        }


        [Theory(DisplayName = "ToSafeNullableLong: Returns a value.")]
        [InlineData("234.23", 234)]
        [InlineData("-234.23", -234)]
        [InlineData(-234.23, -234)]
        [InlineData("0", 0)]
        [InlineData(45, 45)]
        [InlineData(4564.456F, 4564)]
        [InlineData(4564.456D, 4564)]
        public void ToSafeNullableLong_ReturnValue(object value, decimal expected)
        {
            Assert.Equal((long?)expected, value.ToSafeNullableLong());
        }

        [Fact(DisplayName = "ToSafeNullableLong: Returns value from string")]
        public void ToSafeNullableLong_ReturnFromString() => Assert.Equal((long?)234, "234.23".ToSafeNullableLong());

        [Fact(DisplayName = "ToSafeNullableLong: Returns value from negative string")]
        public void ToSafeNullableLong_ReturnFromNegativeString() => Assert.Equal((long?)-234, "-234.23".ToSafeNullableLong());

        [Fact(DisplayName = "ToSafeNullableLong: Returns value from null")]
        public void ToSafeNullableLong_ReturnFromNull() => Assert.Equal((long?)null, ((object)null).ToSafeNullableLong());

        [Fact(DisplayName = "ToSafeNullableLong: Returns value from invalid string")]
        public void ToSafeNullableLong_ReturnFromInvalidString() => Assert.Equal((long?)null, "asdfsd".ToSafeNullableLong());

        [Fact(DisplayName = "ToSafeNullableLong: Returns value from single")]
        public void ToSafeNullableLong_ReturnFromSingle() => Assert.Equal((long?)234, (234.23f).ToSafeNullableLong());

        [Fact(DisplayName = "ToSafeNullableLong: Returns value from long")]
        public void ToSafeNullableLong_ReturnFromLong() => Assert.Equal((long?)234, (234.23d).ToSafeNullableLong());

        [Fact(DisplayName = "ToSafeNullableLong: Returns value from decimal")]
        public void ToSafeNullableLong_ReturnFromDecimal() => Assert.Equal((long?)234, (234.23m).ToSafeNullableLong());

        #endregion
    }
}
