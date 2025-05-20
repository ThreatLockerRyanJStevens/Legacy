using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class BooleanExtensionTests : BaseTest
    {

        #region ToSafeBool
        [Fact(DisplayName = "ToSafeBool: From Same")]
        public void ToSafeBool_ReturnsFromSame()
        {
            var expected = fixture.Create<bool>();
            Assert.Equal(expected, expected.ToSafeBool());
        }

        [Theory(DisplayName = "ToSafeBool: Returns true.")]
        [InlineData(true)]
        [InlineData("true")]
        [InlineData("True")]
        [InlineData(1)]
        public void ToSafeBool_ReturnsBool(object value)
        {
            Assert.True(value.ToSafeBool());
        }

        [Theory(DisplayName = "ToSafeBool: Returns false.")]
        [InlineData(false)]
        [InlineData("false")]
        [InlineData("False")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(0)]
        [InlineData(456465)]
        public void ToSafeBool_ReturnsFalse(object value)
        {
            Assert.False(value.ToSafeBool());
        }

        #endregion

        #region ToSafeNullableBool
        [Fact(DisplayName = "ToSafeNullableBool: From Same")]
        public void ToSafeNullableBool_ReturnsFromSame()
        {
            var expected = fixture.Create<bool>();
            Assert.Equal(expected, expected.ToSafeNullableBool());
        }

        [Theory(DisplayName = "ToSafeNullableBool: Returns true.")]
        [InlineData(true)]
        [InlineData("true")]
        [InlineData("True")]
        [InlineData(false)]
        [InlineData("false")]
        [InlineData("False")]
        [InlineData(0)]
        [InlineData(1)]
        public void ToSafeNullableBool_ReturnsBool(object value)
        {
            Assert.NotNull(value.ToSafeNullableBool());
        }

        [Theory(DisplayName = "ToSafeNullableBool: Returns null.")]
        [InlineData(null)]
        [InlineData("a lsdjkfd")]
        [InlineData(456465)]
        public void ToSafeNullableBool_ReturnsNull(object value)
        {
            Assert.Null(value.ToSafeNullableBool());
        }

        #endregion
    }
}
