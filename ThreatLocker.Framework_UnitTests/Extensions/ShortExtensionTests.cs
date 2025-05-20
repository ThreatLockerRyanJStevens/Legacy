using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class ShortExtensionTests : BaseTest
    {
        #region ToSafeShort

        [Fact(DisplayName = "ToSafeShort: From Same")]
        public void ToSafeShort_FromSame()
        {
            var expected = fixture.Create<short>();
            Assert.Equal(expected, expected.ToSafeShort());
        }


        [Theory(DisplayName = "ToSafeShort: Returns a value.")]
        [InlineData("234.23", 234)]
        [InlineData("-234.23", -234)]
        [InlineData(-234.23, -234)]
        [InlineData("ss", 0)]
        [InlineData("0", 0)]
        [InlineData(45, 45)]
        [InlineData(4564.456F, 4564)]
        [InlineData(4564.456D, 4564)]
        public void ToSafeShort_ReturnValue(object value, short expected)
        {
            Assert.Equal(expected, value.ToSafeShort());
        }

        [Fact(DisplayName = "ToSafeShort: Returns value from short")]
        public void ToSafeShort_ReturnFromShort() => Assert.Equal((short)234, ((short)234).ToSafeShort());
        #endregion

        #region ToSafeNullableShort

        [Fact(DisplayName = "ToSafeNullableShort: From Same")]
        public void ToSafeNullableShort_FromSame()
        {
            var expected = fixture.Create<short>();
            Assert.Equal(expected, expected.ToSafeNullableShort());
        }

        [Theory(DisplayName = "ToSafeNullableShort: Returns a value.")]
        [InlineData("234.23", 234)]
        [InlineData("-234.23", -234)]
        [InlineData(-234.23, -234)]
        [InlineData("0", 0)]
        [InlineData(45, 45)]
        [InlineData(4564.456F, 4564)]
        [InlineData(4564.456D, 4564)]
        public void ToSafeNullableShort_ReturnValue(object value, short expected)
        {
            Assert.Equal((short?)expected, value.ToSafeNullableShort());
        }

        [Fact(DisplayName = "ToSafeNullableShort: Returns value from string")]
        public void ToSafeNullableShort_ReturnFromString() => Assert.Equal((short?)234, "234.23".ToSafeNullableShort());

        [Fact(DisplayName = "ToSafeNullableShort: Returns value from negative string")]
        public void ToSafeNullableShort_ReturnFromNegativeString() => Assert.Equal((short?)-234, "-234.23".ToSafeNullableShort());

        [Fact(DisplayName = "ToSafeNullableShort: Returns value from null")]
        public void ToSafeNullableShort_ReturnFromNull() => Assert.Equal((short?)null, ((object)null).ToSafeNullableShort());

        [Fact(DisplayName = "ToSafeNullableShort: Returns value from invalid string")]
        public void ToSafeNullableShort_ReturnFromInvalidString() => Assert.Equal((short?)null, "asdfsd".ToSafeNullableShort());

        [Fact(DisplayName = "ToSafeNullableShort: Returns value from single")]
        public void ToSafeNullableShort_ReturnFromSingle() => Assert.Equal((short?)234, (234.23f).ToSafeNullableShort());

        [Fact(DisplayName = "ToSafeNullableShort: Returns value from short")]
        public void ToSafeNullableShort_ReturnFromShort() => Assert.Equal((short?)234, (234.23d).ToSafeNullableShort());

        [Fact(DisplayName = "ToSafeNullableShort: Returns value from decimal")]
        public void ToSafeNullableShort_ReturnFromDecimal() => Assert.Equal((short?)234, (234.23m).ToSafeNullableShort());

        #endregion
    }
}
