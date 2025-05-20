using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class StringExtensionTests : BaseTest
    {

        #region ToSafeString

        [Fact(DisplayName = "ToSafeString: From Same")]
        public void ToSafeString_FromSame()
        {
            var expected = fixture.Create<string>();
            Assert.Equal(expected, expected.ToSafeString());
        }


        [Theory(DisplayName = "ToSafeString: Returns string.")]
        [InlineData("a lsdjkfd")]
        [InlineData(456465)]
        public void ToSafeString_ReturnsString(object value)
        {
            Assert.False(string.IsNullOrEmpty(value.ToSafeString()));
        }

        [Theory(DisplayName = "ToSafeString: Returns empty string.")]
        [InlineData(null)]
        [InlineData("")]
        public void ToSafeString_ReturnsEmptyString(object value)
        {
            Assert.True(string.IsNullOrEmpty(value.ToSafeString()));
        }

        #endregion

        #region ToSafeNullableString

        [Fact(DisplayName = "ToSafeNullableString: From Same")]
        public void ToSafeNullableString_FromSame()
        {
            var expected = fixture.Create<string>();
            Assert.Equal(expected, expected.ToSafeNullableString());
        }


        [Theory(DisplayName = "ToSafeNullableString: Returns string.")]
        [InlineData("a lsdjkfd")]
        [InlineData(456465)]
        public void ToSafeNullableString_ReturnsString(object value)
        {
            Assert.NotNull(value.ToSafeNullableString());
        }

        [Theory(DisplayName = "ToSafeNullableString: Returns null.")]
        [InlineData(null)]
        public void ToSafeNullableString_ReturnsNull(object value)
        {
            Assert.Null(value.ToSafeNullableString());
        }

        #endregion

        #region Truncate

        [Theory(DisplayName = "Truncate: Returns truncated string")]
        [InlineData("Lorem ipsum dolor sit amet", 0, "")]
        [InlineData("Lorem ipsum dolor sit amet", 10, "Lorem ipsu")]
        public void Truncate_ReturnsValidString(string source, int maxChars, string expected)
        {
            var result = source?.Truncate(maxChars);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "Truncate: Returns truncated string using substring")]
        [InlineData("Lorem ipsum dolor sit amet", 0, "", "")]
        [InlineData("Lorem ipsum dolor sit amet", 10, "", "Lorem ipsu")]
        [InlineData("Lorem ipsum dolor sit amet", 10, "dolor", "Loremdolor")]
        public void Truncate_ReturnsValidStringSubStrings(string source, int maxChars, string substring, string expected)
        {
            var result = source?.Truncate(maxChars, substring);
            Assert.Equal(expected, result);
        }

        #endregion

        #region RemoveWhitespace

        [Theory(DisplayName = "RemoveWhitespace: Returns string without whitespace")]
        [InlineData("Lorem ipsum dolor sit amet", "Loremipsumdolorsitamet")]
        [InlineData("  Lorem ipsum dolor sit amet", "Loremipsumdolorsitamet")]
        [InlineData("  Lorem ipsum dolor sit amet   ", "Loremipsumdolorsitamet")]
        public void RemoveWhitespace_ReturnsValidString(string source, string expected)
        {
            var result = source?.RemoveWhitespace();
            Assert.Equal(expected, result);
        }

        #endregion

        #region IsEmptyHash

        [Theory(DisplayName = "IsEmptyHash: Returns is empty hash")]
        [InlineData("00000000000000000000000000000000", true)]
        [InlineData("0000000000000000000000000000000", false)]
        [InlineData("000000000000000000000000000000000", false)]
        [InlineData("Lorem ipsum dolor sit amet", false)]
        public void IsEmptyHash_ReturnsValidString(string source, bool expected)
        {
            var result = source?.IsEmptyHash();
            Assert.Equal(expected, result);
        }

        #endregion

        #region IsEmptySha256

        [Theory(DisplayName = "IsEmptySha256: Returns is empty SHA")]
        [InlineData("0000000000000000000000000000000000000000000000000000000000000000", true)]
        [InlineData("000000000000000000000000000000000000000000000000000000000000000", false)]
        [InlineData("00000000000000000000000000000000000000000000000000000000000000000", false)]
        [InlineData("Lorem ipsum dolor sit amet", false)]
        public void IsEmptySha256_ReturnsValidString(string source, bool expected)
        {
            var result = source?.IsEmptySha256();
            Assert.Equal(expected, result);
        }

        #endregion

        #region IsZeroHash

        [Theory(DisplayName = "IsZeroHash: Returns is zero hash")]
        [InlineData("0", true)]
        [InlineData("000000000000000000000000000000000000000000000000000000000000000", true)]
        [InlineData("00000000000000000000000000000000000000000000000000000000000000000", true)]
        [InlineData("Lorem ipsum dolor sit amet", false)]
        public void IsZeroHash_ReturnsValidString(string source, bool expected)
        {
            var result = source?.IsZeroHash();
            Assert.Equal(expected, result);
        }

        #endregion

        #region StripCharacters

        [Theory(DisplayName = "StripCharacters: Returns string without requested characters.")]
        [InlineData("Lorem ipsum dolor sit amet",new char[] {'p'}, "Lorem isum dolor sit amet")]
        [InlineData("Lorem ipsum dolor sit amet", new char[] { 'p','a' }, "Lorem isum dolor sit met")]
        [InlineData("Lorem ipsum dolor sit amet", new char[] { 'l','d','e' }, "Lorm ipsum oor sit amt")]
        [InlineData("Lorem ipsum dolor sit amet", new char[] { 'L', 'd', 'e' }, "orm ipsum olor sit amt")]
        public void StripCharacters_ReturnsValidString(string source,char[] chars, string expected)
        {
            var result = source?.StripCharacters(chars);
            Assert.Equal(expected, result);
        }

        #endregion

        #region CleanForJsonPost

        [Theory(DisplayName = "CleanForJsonPost: Returns clean string")]
        [InlineData("{\"test\":\"dakk\"}", "{\"test\":\"dakk\"}")]
        public void CleanForJsonPost_ReturnsValidString(string source, string expected)
        {
            var result = source?.CleanForJsonPost();
            Assert.Equal(expected, result);
        }

        #endregion

        #region Base64Encode

        [Theory(DisplayName = "Base64Encode: Returns base64 encode string")]
        [InlineData("Lorem ipsum dolor sit amet", "TG9yZW0gaXBzdW0gZG9sb3Igc2l0IGFtZXQ=")]
        [InlineData("threatlockerkey", "dGhyZWF0bG9ja2Vya2V5")]
        //[InlineData(@"㚔#\u001d�V����%_*�`��}o��#��<\u0004Du&_F", @"45qUIx2TVoj7wtwlXyryYJTYfW+ysiPM1jwERHUmX0Y=")]
        public void Base64Encode_ReturnsValidString(string source, string expected)
        {
            var result = source?.Base64Encode();
            Assert.Equal(expected, result);
        }

        #endregion

        #region Base64Decode

        [Theory(DisplayName = "Base64Decode: Returns decoded string")]
        [InlineData("TG9yZW0gaXBzdW0gZG9sb3Igc2l0IGFtZXQ=", "Lorem ipsum dolor sit amet")]
        [InlineData("dGhyZWF0bG9ja2Vya2V5", "threatlockerkey")]
        [InlineData("45qUIx2TVoj7wtwlXyryYJTYfW+ysiPM1jwERHUmX0Y=", "㚔#\u001d�V����%_*�`��}o��#��<\u0004Du&_F")]
        public void Base64Decode_ReturnsValidString(string source, string expected)
        {
            var result = source?.Base64Decode();
            Assert.Equal(expected, result);
        }

        #endregion

        #region Base64StringToByte

        [Theory(DisplayName = "Base64StringToByte: Returns byte array")]
        [InlineData("dGhyZWF0bG9ja2Vya2V5", new byte[] { 116, 104, 114, 101, 97, 116, 108, 111, 99, 107, 101, 114, 107, 101, 121 })]
        public void Base64StringToByte_ReturnsByteArray(string source, byte[] expected)
        {
            var result = source?.Base64StringToByte();
            Assert.Equal(expected, result);
        }

        #endregion

        #region IsIn

        [Theory(DisplayName = "IsIn: Returns True/false")]
        [InlineData("ipsum", new string[] { "ipsum", "threatlocker" }, true)]
        [InlineData("sit", new string[] { "sit", "threatlocker" }, true)]
        [InlineData("he", new string[] { "Lorem", "threatlocker" }, false)]
        public void IsIn_ReturnsBool(string source, string[] args, bool expected)
        {
            var result = source?.IsIn(args);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "IsIn: Returns True/false using comparison")]
        [InlineData("threatlocker", StringComparison.Ordinal, new string[] { "", "threatlocker" }, true)]
        [InlineData("ipsum", StringComparison.InvariantCultureIgnoreCase, new string[] { "IPSUM" }, true)]
        [InlineData("sit", StringComparison.InvariantCultureIgnoreCase, new string[] { "IPSUM", "SIT" }, true)]
        [InlineData("amet", StringComparison.InvariantCultureIgnoreCase, new string[] { "SAM", "HE" }, false)]
        public void IsIn_ReturnsBoolComparison(string source, StringComparison compare, string[] args, bool expected)
        {
            var result = source?.IsIn(compare, args);
            Assert.Equal(expected, result);
        }

        #endregion

        #region ToTitleCase

        [Theory(DisplayName = "ToTitleCase: Returns valid string")]
        [InlineData("lorem ipsum dolor sit amet", "Lorem ipsum dolor sit amet")]
        public void ToTitleCase_ReturnsValidString(string source, string expected)
        {
            var result = source?.ToTitleCase();
            Assert.Equal(expected, result);
        }

        #endregion

        #region IsThreatLockerVersionGreaterThanOrEqualTo

        [Theory(DisplayName = "IsThreatLockerVersionGreaterThanOrEqualTo: Returns True/False")]
        [InlineData("1.2.3.4/some", 1, 2, 3, 0, true)]
        [InlineData("1.2.3.4/some", 1, 2, 4, 0, false)]
        public void IsThreatLockerVersionGreaterThanOrEqualTo_ReturnsTrueOrFalse(string source, int major, int minor, int patch, int os, bool expected)
        {
            var result = source?.IsThreatLockerVersionGreaterThanOrEqualTo(major, minor, patch, os);
            Assert.Equal(expected, result);
        }

        #endregion
    }
}
