namespace ThreatLockerCommon.Enums
{
    /// <summary>
    ///     Supported Languages
    /// </summary>
    public enum Language
    {
        Unknown,
        English
    }

    /// <summary>
    ///     Static class responsible for converting strings to Languge enums and Language enums to strings
    /// </summary>
    public static class LanguageParser
    {
        #region Enum To Full String

        /// <summary>
        ///     Converts a Language enum to it's string representation. 
        /// </summary>
        /// <param name="value">
        ///     The Languge Enum to convert
        /// </param>
        /// <param name="language">
        ///     The Language to convert it in
        /// </param>
        /// <remarks>
        ///     If no language is provided, then the order of languages to convert to, if there is no 
        ///     representation of the enum in the previous language, are as follows
        ///     1) English
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static string ToStringValue(this Language value, Language language = Language.Unknown)
        {
            switch (language)
            {
                case Language.English:
                    return value.ToString_English();
                case Language.Unknown:
                    string stringValue = string.Empty;
                    if (string.IsNullOrWhiteSpace(stringValue))
                    {
                        stringValue = value.ToStringValue(Language.English);
                    }
                    return stringValue;
                default:
                    return string.Empty;
            }
        }

        #region Different Languages

        /// <summary>
        ///     Returns the string representation of the Language enum in the English Language
        /// </summary>
        /// <param name="value">
        ///     The Language enum to convert
        /// </param>
        /// <remarks>
        ///     If there is no english representation of the Language enum, then a blank string is returned.
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static string ToString_English(this Language value)
        {
            switch (value)
            {
                case Language.English:
                    return "English";
                default:
                    return string.Empty;
            }
        }

        #endregion

        #endregion

        #region Enum To String Code

        /// <summary>
        ///     Converts a Language enum to it's ISO639 code
        /// </summary>
        /// <param name="value">
        ///     The Language enum to convert
        /// </param>
        /// <remarks>
        ///     Will try to convert to ISO639-1 code first (two letters). If none found will attempt a ISO639-3 code (three letters).
        ///     If none found there, then a blank string is returned.
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static string ToISO639Code(this Language value)
        {
            string stringValue = value.ToISO639_1Code();
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                stringValue = value.ToISO639_3Code();
            }
            return stringValue;
        }

        #region Enum to Subsets of ISO639 Standard

        /// <summary>
        ///     Converts a Language enum to it's 2 letter ISO639-1 code. 
        /// </summary>
        /// <param name="value">
        ///     The Language enum to convert.
        /// </param>
        /// <remarks>
        ///     Empty string is returned if there is no ISO639-1 code for the language
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static string ToISO639_1Code(this Language value)
        {
            switch (value)
            {
                case Language.English:
                    return "EN";
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        ///     Converts a Language enum to it's 3 letter ISO639-3 code
        /// </summary>
        /// <param name="value">
        ///     The Language enum to convert
        /// </param>
        /// <remarks>
        ///     Empty string is returned if there is no ISO639-3 code for the language
        /// </remarks>
        /// <returns></returns>
        public static string ToISO639_3Code(this Language value)
        {
            switch (value)
            {
                case Language.English:
                    return "ENG";
                default:
                    return string.Empty;
            }
        }

        #endregion

        #endregion

        #region String To Enum

        /// <summary>
        ///     Converts a string to a Language Enum. 
        /// </summary>
        /// <param name="value">
        ///     The string to convert
        /// </param>
        /// <returns>
        ///     Language Enum
        /// </returns>
        /// <remarks>
        ///     Expects correct spelling of the language in a supported language, two letter ISO 639-1 compliant code, or 
        ///     three letter ISO 639-3 compliant code.
        ///     Order of languages to convert from are as follows
        ///     1) English
        /// </remarks>
        public static Language ToLanguageEnum(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Language.Unknown;
            }

            if (value.Length == 2)
            {
                return value.ToLanguageEnumFromISO639_1();
            }

            if (value.Length == 3)
            {
                return value.ToLanguageEnumFromISO639_3();
            }

            Language _enumValue = Language.Unknown;
            if (_enumValue == Language.Unknown)
            {
                _enumValue = value.ToLanguageEnumFromEnglish();
            }

            return _enumValue;
        }

        /// <summary>
        ///     Converts a string to a Language enum
        /// </summary>
        /// <param name="value">
        ///     The string to convert
        /// </param>
        /// <remarks>
        ///     Expects English Language string for input
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static Language ToLanguageEnumFromEnglish(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Language.Unknown;
            }

            switch (value.ToLower())
            {
                case "english":
                    return Language.English;
                default:
                    return Language.Unknown;
            }
        }

        /// <summary>
        ///     Converts a string to a Langauge enum
        /// </summary>
        /// <param name="value">
        ///     The string to convert
        /// </param>
        /// <remarks>
        ///     Expects a two character code
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static Language ToLanguageEnumFromISO639_1(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Language.Unknown;
            }

            switch (value.ToLower())
            {
                case "en":
                    return Language.English;
                default:
                    return Language.Unknown;
            }
        }

        /// <summary>
        ///     Converts a string to a Language enum
        /// </summary>
        /// <param name="value">
        ///     The string to convert
        /// </param>
        /// <remarks>
        ///     Expects a three character code
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static Language ToLanguageEnumFromISO639_3(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Language.Unknown;
            }

            switch (value.ToLower())
            {
                case "eng":
                    return Language.English;
                default:
                    return Language.Unknown;
            }
        }

        #endregion

    }
}
