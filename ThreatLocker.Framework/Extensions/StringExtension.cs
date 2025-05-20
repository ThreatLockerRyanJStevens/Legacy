using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ThreatLocker.Framework.Utils;

namespace ThreatLocker.Framework.Extensions
{
    public static class StringExtension
    {
        public static string ToSafeString(this object value) => Convert.ToString(value) ?? string.Empty;

        public static string ToSafeNullableString(this object value)
        {
            try
            {
                if (value != null)
                    return Convert.ToString(value);

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string Truncate(this string value, int maxChars)
        {
            return value.Truncate(maxChars, "");
        }

        public static string Truncate(this string value, int maxChars, string substring)
        {
            if (value == null)
            {
                return value;
            }

            if (maxChars < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxChars), "MaxChars must be >= 0");
            }

            int substringLength = !string.IsNullOrEmpty(substring) ? substring.Length : 0;

            return value.Length <= maxChars ? value : value.Substring(0, maxChars - substringLength) + substring;
        }

        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !char.IsWhiteSpace(c))
                .ToArray());
        }

        public static bool IsEmptyHash(this string hash)
        {
            if (!string.IsNullOrWhiteSpace(hash))
            {
                return hash == "00000000000000000000000000000000";
            }

            return true;
        }

        public static bool IsEmptySha256(this string sha256)
        {
            if (!string.IsNullOrWhiteSpace(sha256))
            {
                return sha256 == "0000000000000000000000000000000000000000000000000000000000000000";
            }

            return true;
        }

        public static bool IsZeroHash(this string hash) => Regex.IsMatch(hash ?? "", "^0+$");

        public static string StripCharacters(this string value, params char[] chars)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            foreach (char c in chars)
            {
                value = value.Replace(c.ToString(), string.Empty);
            }

            return value;
        }

        public static string CleanForJsonPost(this string value)
        {
            string valueWithoutHTML = Regex.Replace(value, @"<[^>]+>|&nbsp;", "").Trim().Replace("\\", "/");
            return Regex.Replace(valueWithoutHTML, @"\s{2,}", " ");
        }

        public static string Base64Encode(this string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return string.Empty;
            }

            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(this string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return string.Empty;
            }

            if (plainText.Length % 4 > 0)
            {
                while (plainText.Length % 4 > 0)
                {
                    plainText += "=";
                }
            }

            var base64EncodedBytes = Convert.FromBase64String(plainText);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static byte[] Base64StringToByte(this string input)
        {
            return Convert.FromBase64String(input);
        }

        public static bool IsIn(this string s, params string[] args)
        {
            return s.IsIn(StringComparison.Ordinal, args);
        }

        public static bool IsIn(this string s, StringComparison comparisonType, params string[] args)
        {
            return args.Any((string arg) => arg.Equals(s, comparisonType));
        }

        public static string ToTitleCase(this object value)
        {
            string origin = Convert.ToString(value);

            if (origin != null && origin.Length > 1)
            {
                origin = origin.Substring(0, 1).ToUpper() + origin.Substring(1);
            }

            return origin;
        }

        /// <summary>
        /// This method will accept a ThreatLocker Version string and determine if the version is greater than or equal to the values passed in through
        /// the parameters.
        /// </summary>
        /// <param name="version">The ThreatLockerVersion you want to evaluate</param>
        /// <param name="majorVersionNumber">The Major Version Number</param>
        /// <param name="minorVersionNumber">The Minor Version Number</param>
        /// <param name="versionPatchNumber">The Version Patch Number</param>
        /// <param name="osType"></param>
        /// <returns></returns>
        public static bool IsThreatLockerVersionGreaterThanOrEqualTo(this string version, int majorVersionNumber, int minorVersionNumber, int versionPatchNumber, int osType = 1)
        {
            StringUtil.GetAgentVersion(version, out int versionMajor, out int versionMinor, out int versionPatch, osType);

            bool greaterThanOrEqualToVersion = (versionMajor >= majorVersionNumber && versionMinor > minorVersionNumber)
                || (versionMajor == majorVersionNumber && versionMinor == minorVersionNumber && versionPatch >= versionPatchNumber)
                || (versionMajor > majorVersionNumber);

            return greaterThanOrEqualToVersion;
        }
    }
}
