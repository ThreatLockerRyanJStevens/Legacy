using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class IEnumerableExtensionTests : BaseTest
    {

        #region IsNotNullOrEmpty<T>

        [Fact(DisplayName = "IsNotNullOrEmpty: Return True")]
        public void IsNotNullOrEmpty_ReturnsTrue()=>Assert.True(new string[] {"test", "dumby"}.IsNotNullOrEmpty());

        [Fact(DisplayName = "IsNotNullOrEmpty: Return False (empty)")]
        public void IsNotNullOrEmpty_ReturnsFalseEmpty() => Assert.False(new string[] {}.IsNotNullOrEmpty());

        [Fact(DisplayName = "IsNotNullOrEmpty: Return False (null)")]
        public void IsNotNullOrEmpty_ReturnsFalseNull() => Assert.False(((string[])null).IsNotNullOrEmpty());

        #endregion

        #region IsNullOrEmpty<T>

        [Fact(DisplayName = "IsNotNullOrEmpty: Return False")]
        public void IsNullOrEmpty_ReturnsFalse() => Assert.False(new string[] { "test", "dumby" }.IsNullOrEmpty());

        [Fact(DisplayName = "IsNotNullOrEmpty: Return True (empty)")]
        public void IsNullOrEmpty_ReturnsTrueEmpty() => Assert.True(new string[] { }.IsNullOrEmpty());

        [Fact(DisplayName = "IsNotNullOrEmpty: Return True (null)")]
        public void IsNullOrEmpty_ReturnsTrueNull() => Assert.True(((string[])null).IsNullOrEmpty());

        #endregion

        #region IsNotNullOrEmptyAny<T>

        [Fact(DisplayName = "IsNotNullOrEmptyAny: Return True")]
        public void IsNotNullOrEmptyAny_ReturnsTrue() => Assert.True(new string[] { "test", "dumby" }.IsNotNullOrEmptyAny(m=> true));

        [Fact(DisplayName = "IsNotNullOrEmptyAny: Return False (any = false)")]
        public void IsNotNullOrEmptyAny_ReturnsFalseAny() => Assert.False(new string[] { "test", "dumby" }.IsNotNullOrEmptyAny(m => false));

        [Fact(DisplayName = "IsNotNullOrEmptyAny: Return True (empty)")]
        public void IsNotNullOrEmptyAny_ReturnsFalseEmpty() => Assert.False(new string[] { }.IsNotNullOrEmptyAny(m => true));

        [Fact(DisplayName = "IsNotNullOrEmptyAny: Return True (null)")]
        public void IsNotNullOrEmptyAny_ReturnsFalseNull() => Assert.False(((string[])null).IsNotNullOrEmptyAny(m => true));

        #endregion

        #region SplitBy<T>

        [Fact(DisplayName = "SplitBy: Return matched and not matched")]
        public void SplitBy_ReturnsMatched()
        {
            var items = new string[] { "test", "dumby", "", null };
            var matched = items.SplitBy(out IEnumerable<string> notMatched, x => string.IsNullOrEmpty(x));


            var expectedMatched = new string[] { "", null };
            var expectedNotMatched = new string[] { "test", "dumby" };
            Assert.Equal(expectedMatched, matched);
            Assert.Equal(expectedNotMatched, notMatched);
        }
        #endregion

        #region SplitBy<T> (List)

        [Fact(DisplayName = "SplitBy: Return matched and not matched (List)")]
        public void SplitBy_ReturnsMatchedList()
        {
            var items = new List<string> { "test", "dumby", "", null };
            var matched = items.SplitBy(out List<string> notMatched, x => string.IsNullOrEmpty(x));


            var expectedMatched = new List<string> { "", null };
            var expectedNotMatched = new List<string> { "test", "dumby" };
            Assert.Equal(expectedMatched, matched);
            Assert.Equal(expectedNotMatched, notMatched);
        }

        #endregion

        #region ContainsAll<T>

        [Fact(DisplayName = "ContainsAll: Return True")]
        public void ContainsAll_ReturnsTrue() => Assert.True(new string[] { "test", "dumby" }.ContainsAll(new string[] { "test", "dumby" }));
       
        [Fact(DisplayName = "ContainsAll: Return False")]
        public void ContainsAll_ReturnsFalse() => Assert.False(new string[] { "test", "dumby" }.ContainsAll(new string[] { "test", "dumby", "threatlocker" }));

        #endregion
    }
}
