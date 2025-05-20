using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class DecimalExtensionTests : BaseTest
    {
        #region ToSafeDecimal
        [Fact(DisplayName = "ToSafeDecimal: From Same")]
        public void ToSafeDecimal_FromSame()
        {
            var expected = fixture.Create<decimal>();
            Assert.Equal(expected, expected.ToSafeDecimal());
        }

        [Theory(DisplayName = "ToSafeDecimal: Returns a value.")]
        [InlineData("234.23", 234.23)]
        [InlineData("-234.23", -234.23)]
        [InlineData(-234.23, -234.23)]
        [InlineData("ss", 0)]
        [InlineData("0", 0)]
        [InlineData(45, 45)]
        [InlineData(4564.456f, 4564.456)]
        [InlineData(4564.456d, 4564.456)]
        public void ToSafeDecimal_ReturnValue(object value, decimal expected)
        {
            Assert.Equal(expected, value.ToSafeDecimal());
        }

        [Fact(DisplayName = "ToSafeDecimal: Returns value from decimal")]
        public void ToSafeDecimal_ReturnFromDecimal() => Assert.Equal(234.23M, (234.23m).ToSafeDecimal());
        #endregion

        #region ToSafeNullableDecimal
        [Fact(DisplayName = "ToSafeNullableDecimal: From Same")]
        public void ToSafeNullableDecimal_FromSame()
        {
            var expected = fixture.Create<decimal>();
            Assert.Equal(expected, expected.ToSafeNullableDecimal());
        }

        [Theory(DisplayName = "ToSafeDecimal: Returns a value.")]
        [InlineData("234.23", 234.23)]
        [InlineData("-234.23", -234.23)]
        [InlineData(-234.23, -234.23)]
        [InlineData("0", 0)]
        [InlineData(45, 45)]
        [InlineData(4564.456f, 4564.456)]
        public void ToSafeNullableDecimal_ReturnValue(object value, decimal expected)
        {
            Assert.Equal((decimal?)expected, value.ToSafeNullableDecimal());
        }

        [Fact(DisplayName = "ToSafeNullableDecimal: Returns value from string")]
        public void ToSafeNullableDecimal_ReturnFromString()=> Assert.Equal(234.23M, "234.23".ToSafeNullableDecimal());
       
        [Fact(DisplayName = "ToSafeNullableDecimal: Returns value from negative string")]
        public void ToSafeNullableDecimal_ReturnFromNegativeString() => Assert.Equal(-234.23M, "-234.23".ToSafeNullableDecimal());
        
        [Fact(DisplayName = "ToSafeNullableDecimal: Returns value from null")]
        public void ToSafeNullableDecimal_ReturnFromNull() => Assert.Equal(null, ((object)null).ToSafeNullableDecimal());
       
        [Fact(DisplayName = "ToSafeNullableDecimal: Returns value from invalid string")]
        public void ToSafeNullableDecimal_ReturnFromInvalidString() => Assert.Equal(null, "asdfsd".ToSafeNullableDecimal());

        [Fact(DisplayName = "ToSafeNullableDecimal: Returns value from single")]
        public void ToSafeNullableDecimal_ReturnFromSingle() => Assert.Equal(234.23M, (234.23f).ToSafeNullableDecimal());

        [Fact(DisplayName = "ToSafeNullableDecimal: Returns value from double")]
        public void ToSafeNullableDecimal_ReturnFromDouble() => Assert.Equal(234.23M, (234.23d).ToSafeNullableDecimal());

        [Fact(DisplayName = "ToSafeNullableDecimal: Returns value from decimal")]
        public void ToSafeNullableDecimal_ReturnFromDecimal() => Assert.Equal(234.23M, (234.23m).ToSafeNullableDecimal());

        #endregion
    }
}
