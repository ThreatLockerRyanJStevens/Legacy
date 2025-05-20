using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class IntegerExtensionTests : BaseTest
    {

        #region ToSafeInt

        [Fact(DisplayName = "ToSafeInt: From Same")]
        public void ToSafeInt_FromSame()
        {
            var expected = fixture.Create<int>();
            Assert.Equal(expected, expected.ToSafeInt());
        }

        [Theory(DisplayName = "ToSafeInt: Returns Integer.")]
        [InlineData(2)]
        [InlineData("2")]
        [InlineData("246454654")]
        [InlineData("-45646")]
        [InlineData("2147483647")] // Max Integer
        [InlineData(-45646)]
        [InlineData(2147483647)] // Max Integer
        public void ToSafeInt_ReturnsInt(object val)
        {
            Assert.NotEqual(0, val.ToSafeInt());
        }

        [Theory(DisplayName = "ToSafeInt: Returns Zero.")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("asdfs")]
        [InlineData(9223372036854775807)] // Max Long
        [InlineData("9223372036854775807")] // Max Long
        public void ToSafeInt_ReturnsZero(object val)
        {
            Assert.Equal(0, val.ToSafeInt());
        }
        #endregion

        #region ToSafeNullableInt

        [Fact(DisplayName = "ToSafeNullableInt: From Same")]
        public void ToSafeNullableInt_FromSame()
        {
            var expected = fixture.Create<int>();
            Assert.Equal(expected, expected.ToSafeNullableInt());
        }

        [Theory(DisplayName = "ToSafeNullableInt: Returns Integer.")]
        [InlineData(2)]
        [InlineData("2")]
        [InlineData("246454654")]
        [InlineData("-45646")]
        [InlineData("2147483647")] // Max Integer
        [InlineData(-45646)]
        [InlineData(2147483647)] // Max Integer
        public void ToSafeNullableInt_ReturnsInt(object val)
        {
            Assert.NotNull(val.ToSafeNullableInt());
        }

        [Theory(DisplayName = "ToSafeNullableInt: Returns Zero.")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("asdfs")]
        [InlineData(9223372036854775807)] // Max Long
        [InlineData("9223372036854775807")] // Max Long
        public void ToSafeNullableInt_ReturnsNull(object val)
        {
            Assert.Null(val.ToSafeNullableInt());
        }
        #endregion

        #region IsIn

        [Fact(DisplayName = "IsIn: Returns True")]
        public void IsIn_ReturnsTrue()
        {
            Assert.True(5.IsIn(3, 234, 2234, 5, 23434));
        }

        [Fact(DisplayName = "IsIn: Returns False")]
        public void IsIn_ReturnsFalse()
        {
            Assert.False(5.IsIn(3, 234, 2234, 33, 23434));
        }

        #endregion

    }
}
