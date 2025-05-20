using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class GuidExtensionTests : BaseTest
    {
        #region ToSafeGuid
        [Fact(DisplayName = "ToSafeGuid: From Same")]
        public void ToSafeGuid_FromSame()
        {
            var expected = fixture.Create<Guid>();
            Assert.Equal(expected, expected.ToSafeGuid());
        }

        [Theory(DisplayName = "ToSafeGuid: Returns a value.")]
        [InlineData("FB811603-81DF-4CD2-9908-A4E29734403C", "FB811603-81DF-4CD2-9908-A4E29734403C")]
        public void ToSafeGuid_ReturnValue(object value, Guid expected)
        {
            Assert.Equal(expected, value.ToSafeGuid());
        }

        [Theory(DisplayName = "ToSafeGuid: Returns a empty guid.")]
        [InlineData("asdfsdf")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(23434)]
        [InlineData(true)]
        public void ToSafeGuid_ReturnEmpty(object value)
        {
            Assert.Equal(Guid.Empty, value.ToSafeGuid());
        }

        #endregion

        #region ToSafeNullableGuid
        [Fact(DisplayName = "ToSafeNullableGuid: From Same")]
        public void ToSafeNullableGuid_FromSame()
        {
            var expected = fixture.Create<Guid>();
            Assert.Equal(expected, expected.ToSafeNullableGuid());
        }

        [Theory(DisplayName = "ToSafeNullableGuid: Returns a value.")]
        [InlineData("FB811603-81DF-4CD2-9908-A4E29734403C", "FB811603-81DF-4CD2-9908-A4E29734403C")]
        public void ToSafeNullableGuid_ReturnValue(object value, Guid expected)
        {
            Assert.Equal((Guid?)expected, value.ToSafeNullableGuid());
        }

        [Theory(DisplayName = "ToSafeNullableGuid: Returns a null.")]
        [InlineData("asdfsdf")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(23434)]
        [InlineData(true)]
        public void ToSafeNullableGuid_ReturnNull(object value)
        {
            Assert.Equal((Guid?)null, value.ToSafeNullableGuid());
        }

        #endregion

        #region IsEmptyGuid

        [Fact(DisplayName = "IsEmptyGuid: Returns True")]
        public void IsEmptyGuid_ReturnsTrue() => Assert.True(Guid.Empty.IsEmptyGuid());

        [Fact(DisplayName = "IsEmptyGuid: Returns False")]
        public void IsEmptyGuid_ReturnsFalse() => Assert.False(Guid.NewGuid().IsEmptyGuid());

        #endregion

        #region IsNullOrEmpty

        [Fact(DisplayName = "IsNullOrEmpty: Returns True from empty")]
        public void IsNullOrEmpty_ReturnsTrueFromEmpty() => Assert.True(((Guid?)Guid.Empty).IsNullOrEmpty());

        [Fact(DisplayName = "IsNullOrEmpty: Returns True from null")]
        public void IsNullOrEmpty_ReturnsTrueFromNull() => Assert.True(((Guid?)null).IsNullOrEmpty());

        [Fact(DisplayName = "IsNullOrEmpty: Returns False")]
        public void IsNullOrEmpty_ReturnsFalse() => Assert.False(((Guid?)Guid.NewGuid()).IsNullOrEmpty());

        #endregion

        #region IsNotNullOrEmpty

        [Fact(DisplayName = "IsNotNullOrEmpty: Returns False from empty")]
        public void IsNotNullOrEmpty_ReturnsFalseFromEmpty() => Assert.False(((Guid?)Guid.Empty).IsNotNullOrEmpty());

        [Fact(DisplayName = "IsNotNullOrEmpty: Returns False from null")]
        public void IsNotNullOrEmpty_ReturnsFalseFromNull() => Assert.False(((Guid?)null).IsNotNullOrEmpty());

        [Fact(DisplayName = "IsNotNullOrEmpty: Returns True")]
        public void IsNotNullOrEmpty_ReturnsTrue() => Assert.True(((Guid?)Guid.NewGuid()).IsNotNullOrEmpty());

        #endregion

        #region IsIn

        [Theory(DisplayName = "IsIn: Returns True")]
        [InlineData("FB811603-81DF-4CD2-9908-A4E29734403C", "FB811603-81DF-4CD2-9908-A4E29734403C", "B8A39776-D481-4D3C-8E67-679D349834BB")]
        public void IsIn_ReturnsTrue(Guid target, Guid item1, Guid item2) => Assert.True(target.IsIn(item1, item2));

        [Theory(DisplayName = "IsIn: Returns False")]
        [InlineData("4CED293E-FBAE-49A8-B656-E6AD7DED70AD", "FB811603-81DF-4CD2-9908-A4E29734403C", "B8A39776-D481-4D3C-8E67-679D349834BB")]
        public void IsIn_ReturnsFalse(Guid target, Guid item1, Guid item2) => Assert.False(target.IsIn(item1, item2));

        #endregion
    }
}

