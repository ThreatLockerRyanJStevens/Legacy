using ThreatLocker.Framework;
using ThreatLocker.Framework.Utils;

namespace ThreatLocker.Framework_UnitTests
{
    public class StringUtilTests : BaseTest
    {
        private char[] Symbols = { '.', '#', '$', '*', '@' };

        #region GenerateRandomString

        [Fact(DisplayName = "GenerateRandomString: Returns a string without symbols.")]
        public void GenerateRandomString_ReturnStringNoSymbols()
        {
            var result = StringUtil.GenerateRandomString(8, false);
            Assert.NotEmpty(result);
            Assert.True(result.Length == 8);
            Assert.False(result.Any(a => Symbols.Contains(a)), $"Value: {result}");
        }

        [Fact(DisplayName = "GenerateRandomString: Returns a string with symbols.")]
        public void GenerateRandomString_ReturnStringWithSymbols()
        {
            var result = StringUtil.GenerateRandomString(8, true);
            Assert.NotEmpty(result);
            Assert.True(result.Length == 8);
            Assert.True(result.Any(a => Symbols.Contains(a)), $"Value: {result}");
        }

        #endregion

        #region GetAgentVersion

        [Theory(DisplayName = "GetAgentVersion: Returns agent version")]
        [InlineData(@"", 0, 0, 0, 1)]
        [InlineData(@"", 0, 0, 0, 2)]
        [InlineData(@"", 0, 0, 0, 3)]
        [InlineData(@"", 0, 0, 0, 5)]
        [InlineData(@"", 0, 0, 0, 10)]
        [InlineData(@"1.2", 1, 2, 0, 1)]
        [InlineData(@"3.4", 3, 4, 0, 5)]
        [InlineData(@"5.6.7", 5, 6, 0, 1)]
        [InlineData(@"5.6.7.100", 5, 6, 7, 1)]
        [InlineData(@"8.9.10", 8, 9, 0, 5)]
        [InlineData(@"8.9.10.101", 8, 9, 10, 5)]
        [InlineData(@"11.12/Unit Test", 11, 12, 0, 1)]
        [InlineData(@"13.14/Unit Test", 13, 14, 0, 5)]
        [InlineData(@"15.16.17/Unit Test", 15, 16, 0, 5)]
        [InlineData(@"15.16.17.103/Unit Test", 15, 16, 17, 5)]
        [InlineData(@"18.19.20/Unit Test", 18, 19, 0, 1)]
        [InlineData(@"18.19.20.104/Unit Test", 18, 19, 20, 1)]
        [InlineData(@"[Mac] 24.25", 24, 25, 0, 2)]
        [InlineData(@"[Mac] 21.22.23", 21, 22, 0, 2)]
        [InlineData(@"[Mac] 21.22.23.105", 21, 22, 23, 2)]
        [InlineData(@"[LINUX] 29.30", 29, 30, 0, 3)]
        [InlineData(@"[LINUX] 26.27.28", 26, 27, 0, 3)]
        [InlineData(@"[LINUX] 26.27.28.106", 26, 27, 28, 3)]
        public void GetAgentVersion_ReturnsAgentVersion(string version, int major, int minor, int patch, int osType)
        {
            StringUtil.GetAgentVersion(version, out int _major, out int _minor, out int _patch, osType);

            Assert.Equal(major, _major);
            Assert.Equal(minor, _minor);
            Assert.Equal(patch, _patch);
        }

        #endregion
    }
}
