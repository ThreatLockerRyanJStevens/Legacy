using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class DoubleExtensionTests : BaseTest
    {
        #region ToSafeDouble
        [Fact(DisplayName = "ToSafeDouble: From Same")]
        public void ToSafeDouble_FromSame()
        {
            var expected = fixture.Create<double>();
            Assert.Equal(expected, expected.ToSafeDouble());
        }

        [Theory(DisplayName = "ToSafeDouble: Returns a value.")]
        [InlineData("234.23", 234.23d)]
        [InlineData("-234.23", -234.23d)]
        [InlineData(-234.23, -234.23d)]
        [InlineData("ss", 0d)]
        [InlineData("0", 0d)]
        [InlineData(45, 45d)]
        [InlineData(4564.456F, 4564.456d)]
        [InlineData(4564.456D, 4564.456d)]
        public void ToSafeDouble_ReturnValue(object value, double expected)
        {
            Assert.Equal(expected, value.ToSafeDouble());
        }

        [Fact(DisplayName = "ToSafeDouble: Returns value from decimal")]
        public void ToSafeDouble_ReturnFromDecimal() => Assert.Equal(234.23D, (234.23D).ToSafeDouble());
        #endregion

        #region ToSafeNullableDouble
        [Fact(DisplayName = "ToSafeNullableDouble: From Same")]
        public void ToSafeNullableDouble_FromSame()
        {
            var expected = fixture.Create<double>();
            Assert.Equal(expected, expected.ToSafeNullableDouble());
        }

        [Theory(DisplayName = "ToSafeNullableDouble: Returns a value.")]
        [InlineData("234.23", 234.23d)]
        [InlineData("-234.23", -234.23d)]
        [InlineData(-234.23, -234.23d)]
        [InlineData("0", 0d)]
        [InlineData(45, 45d)]
        [InlineData(4564.456F, 4564.456d)]
        [InlineData(4564.456D, 4564.456d)]
        public void ToSafeNullableDouble_ReturnValue(object value, decimal expected)
        {
            Assert.Equal((double?)expected, value.ToSafeNullableDouble());
        }

        [Fact(DisplayName = "ToSafeNullableDouble: Returns value from string")]
        public void ToSafeNullableDouble_ReturnFromString()=> Assert.Equal(234.23D, "234.23".ToSafeNullableDouble());
       
        [Fact(DisplayName = "ToSafeNullableDouble: Returns value from negative string")]
        public void ToSafeNullableDouble_ReturnFromNegativeString() => Assert.Equal(-234.23D, "-234.23".ToSafeNullableDouble());
        
        [Fact(DisplayName = "ToSafeNullableDouble: Returns value from null")]
        public void ToSafeNullableDouble_ReturnFromNull() => Assert.Equal(null, ((object)null).ToSafeNullableDouble());
       
        [Fact(DisplayName = "ToSafeNullableDouble: Returns value from invalid string")]
        public void ToSafeNullableDouble_ReturnFromInvalidString() => Assert.Equal(null, "asdfsd".ToSafeNullableDouble());

        [Fact(DisplayName = "ToSafeNullableDouble: Returns value from single")]
        public void ToSafeNullableDouble_ReturnFromSingle() => Assert.Equal(234.23D, (234.23f).ToSafeNullableDouble());

        [Fact(DisplayName = "ToSafeNullableDouble: Returns value from double")]
        public void ToSafeNullableDouble_ReturnFromDouble() => Assert.Equal(234.23D, (234.23d).ToSafeNullableDouble());

        [Fact(DisplayName = "ToSafeNullableDouble: Returns value from decimal")]
        public void ToSafeNullableDouble_ReturnFromDecimal() => Assert.Equal(234.23D, (234.23m).ToSafeNullableDouble());

        #endregion
    }
}
