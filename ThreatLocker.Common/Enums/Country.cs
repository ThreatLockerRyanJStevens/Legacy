using System;

namespace ThreatLockerCommon.Enums
{
    /// <summary>
    ///     Enumerations for Countries
    /// </summary>
    public enum eCountry
    {
        NotACountry,
        Andorra,
        United_Arab_Emirates,
        Afghanistan,
        Antigua_And_Barbuda,
        Anguilla,
        Albania,
        Armenia,
        Netherlands_Antilles,
        Angola,
        Antarctica,
        Argentina,
        American_Samoa,
        Austria,
        Australia,
        Aruba,
        Aland,
        Azerbaijan,
        Bosnia_and_Herzegovina,
        Barbados,
        Bangladesh,
        Belgium,
        Burkina_Faso,
        Bulgaria,
        Bahrain,
        Burundi,
        Benin,
        Saint_Barthelemy,
        Bermuda,
        Brunei,
        Bolivia,
        Bonaire_Sint_Eustatius_and_Saba,
        Brazil,
        Bahamas,
        Bhutan,
        Bouvet_Island,
        Botswana,
        Belarus,
        Belize,
        Canada,
        Cocos_Keeling_Islands,
        DR_Congo,
        Central_African_Republic,
        Congo_Republic,
        Switzerland,
        Ivory_Coast,
        Cook_Islands,
        Chile,
        Cameroon,
        China,
        Colombia,
        Costa_Rica,
        Serbia_and_Montenegro,
        Cuba,
        Cabo_Verde,
        Curacao,
        Christmas_Island,
        Cyprus,
        Czechia,
        Germany,
        Djibouti,
        Denmark,
        Dominica,
        Dominican_Republic,
        Algeria,
        Ecuador,
        Estonia,
        Egypt,
        Western_Sahara,
        Eritrea,
        Spain,
        Ethiopia,
        Finland,
        Fiji,
        Falkland_Islands,
        Micronesia,
        Faroe_Islands,
        France,
        Gabon,
        United_Kingdom,
        Grenada,
        Georgia,
        French_Guiana,
        Guernsey,
        Ghana,
        Gibraltar,
        Greenland,
        Gambia,
        Guinea,
        Guadeloupe,
        Equatorial_Guinea,
        Greece,
        South_Georgia_and_South_Sandwich_Islands,
        Guatemala,
        Guam,
        Guinea_Bissau,
        Guyana,
        Hong_Kong,
        Heard_Island_and_McDonald_Islands,
        Honduras,
        Croatia,
        Haiti,
        Hungary,
        Indonesia,
        Ireland,
        Israel,
        Isle_of_Man,
        India,
        British_Indian_Ocean_Territory,
        Iraq,
        Iran,
        Iceland,
        Italy,
        Jersey,
        Jamaica,
        Jordan,
        Japan,
        Kenya,
        Kyrgyzstan,
        Cambodia,
        Kiribati,
        Comoros,
        St_Kitts_and_Nevis,
        North_Korea,
        South_Korea,
        Kuwait,
        Cayman_Islands,
        Kazakhstan,
        Laos,
        Lebanon,
        Saint_Lucia,
        Liechtenstein,
        Sri_Lanka,
        Liberia,
        Lesotho,
        Lithuania,
        Luxembourg,
        Latvia,
        Libya,
        Morocco,
        Monaco,
        Moldova,
        Montenegro,
        Saint_Martin,
        Madagascar,
        Marshall_Islands,
        North_Macedonia,
        Mali,
        Myanmar,
        Mongolia,
        Macao,
        Northern_Mariana_Islands,
        Martinique,
        Mauritania,
        Montserrat,
        Malta,
        Mauritius,
        Maldives,
        Malawi,
        Mexico,
        Malaysia,
        Mozambique,
        Namibia,
        New_Caledonia,
        Niger,
        Norfolk_Island,
        Nigeria,
        Nicaragua,
        Netherlands,
        Norway,
        Nepal,
        Nauru,
        Niue,
        New_Zealand,
        Oman,
        Panama,
        Peru,
        French_Polynesia,
        Papua_New_Guinea,
        Philippines,
        Pakistan,
        Poland,
        Saint_Pierre_and_Miquelon,
        Pitcairn_Islands,
        Puerto_Rico,
        Palestine,
        Portugal,
        Palau,
        Paraguay,
        Qatar,
        Reunion,
        Romania,
        Serbia,
        Russia,
        Rwanda,
        Saudi_Arabia,
        Solomon_Islands,
        Seychelles,
        Sudan,
        Sweden,
        Singapore,
        Saint_Helena,
        Slovenia,
        Svalbard_and_Jan_Mayen,
        Slovakia,
        Sierra_Leone,
        San_Marino,
        Senegal,
        Somalia,
        Suriname,
        South_Sudan,
        Sao_Tome_and_Principe,
        El_Salvador,
        Sint_Maarten,
        Syria,
        Eswatini,
        Turks_and_Caicos_Islands,
        Chad,
        French_Southern_Territories,
        Togo,
        Thailand,
        Tajikistan,
        Tokelau,
        Timor_Leste,
        Turkmenistan,
        Tunisia,
        Tonga,
        Turkey,
        Trinidad_and_Tobago,
        Tuvalu,
        Taiwan,
        Tanzania,
        Ukraine,
        Uganda,
        US_Minor_Outlying_Islands,
        United_States,
        Uruguay,
        Uzbekistan,
        Vatican_City,
        St_Vincent_and_Grenadines,
        Venezuela,
        British_Virgin_Islands,
        US_Virgin_Islands,
        Vietnam,
        Vanuatu,
        Wallis_and_Futuna,
        Samoa,
        Kosovo,
        Yemen,
        Mayotte,
        South_Africa,
        Zambia,
        Zimbabwe,
        OpenSource,
        Unidentified
    }

    /// <summary>
    ///     Static class responsible for converting strings to Country enums and Country enums to string
    /// </summary>
    public static class CountryEnumParser
    {

        #region String To Enum

        /// <summary>
        ///     Converts a Country enum to a string
        /// </summary>
        /// <param name="value">
        ///     The string to convert to a Country enum
        /// </param>
        /// <remarks>
        ///     If the string is two characters, this function assumes it is using a Country Code. 
        ///     Order of languages to convert from are as follows
        ///     1) English
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static eCountry ToCountryEnum(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return eCountry.NotACountry;
            }

            if (value.Equals("UId", StringComparison.OrdinalIgnoreCase))
            {
                return eCountry.Unidentified;
            }

            if (value.Length == 2)
            {
                return value.ToCountryEnumFromCountryCode();
            }

            eCountry enumValue = eCountry.NotACountry;
            if (enumValue == eCountry.NotACountry)
            {
                enumValue = value.ToCountryEnumFromEnglish();
            }

            return enumValue;
        }

        /// <summary>
        ///     Converts a string to a Country enum
        /// </summary>
        /// <param name="value">
        ///     The String to convert
        /// </param>
        /// <remarks>
        ///     This function assumes that the given string is a two letter ISO 3166 standard code for a country
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static eCountry ToCountryEnumFromCountryCode(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return eCountry.NotACountry;
            }

            switch (value.ToLower())
            {
                case "ad":
                    return eCountry.Andorra;
                case "ae":
                    return eCountry.United_Arab_Emirates;
                case "af":
                    return eCountry.Afghanistan;
                case "ag":
                    return eCountry.Antigua_And_Barbuda;
                case "ai":
                    return eCountry.Anguilla;
                case "al":
                    return eCountry.Albania;
                case "am":
                    return eCountry.Armenia;
                case "an":
                    return eCountry.Netherlands_Antilles;
                case "ao":
                    return eCountry.Angola;
                case "aq":
                    return eCountry.Antarctica;
                case "ar":
                    return eCountry.Argentina;
                case "as":
                    return eCountry.American_Samoa;
                case "at":
                    return eCountry.Austria;
                case "au":
                    return eCountry.Australia;
                case "aw":
                    return eCountry.Aruba;
                case "ax":
                    return eCountry.Aland;
                case "az":
                    return eCountry.Azerbaijan;
                case "ba":
                    return eCountry.Bosnia_and_Herzegovina;
                case "bb":
                    return eCountry.Barbados;
                case "bd":
                    return eCountry.Bangladesh;
                case "be":
                    return eCountry.Belgium;
                case "bf":
                    return eCountry.Burkina_Faso;
                case "bg":
                    return eCountry.Bulgaria;
                case "bh":
                    return eCountry.Bahrain;
                case "bi":
                    return eCountry.Burundi;
                case "bj":
                    return eCountry.Benin;
                case "bl":
                    return eCountry.Saint_Barthelemy;
                case "bm":
                    return eCountry.Bermuda;
                case "bn":
                    return eCountry.Brunei;
                case "bo":
                    return eCountry.Bolivia;
                case "bq":
                    return eCountry.Bonaire_Sint_Eustatius_and_Saba;
                case "br":
                    return eCountry.Brazil;
                case "bs":
                    return eCountry.Bahamas;
                case "bt":
                    return eCountry.Bhutan;
                case "bv":
                    return eCountry.Bouvet_Island;
                case "bw":
                    return eCountry.Botswana;
                case "by":
                    return eCountry.Belarus;
                case "bz":
                    return eCountry.Belize;
                case "ca":
                    return eCountry.Canada;
                case "cc":
                    return eCountry.Cocos_Keeling_Islands;
                case "cd":
                    return eCountry.DR_Congo;
                case "cf":
                    return eCountry.Central_African_Republic;
                case "cg":
                    return eCountry.Congo_Republic;
                case "ch":
                    return eCountry.Switzerland;
                case "ci":
                    return eCountry.Ivory_Coast;
                case "ck":
                    return eCountry.Cook_Islands;
                case "cl":
                    return eCountry.Chile;
                case "cm":
                    return eCountry.Cameroon;
                case "cn":
                    return eCountry.China;
                case "co":
                    return eCountry.Colombia;
                case "cr":
                    return eCountry.Costa_Rica;
                case "cs":
                    return eCountry.Serbia_and_Montenegro;
                case "cu":
                    return eCountry.Cuba;
                case "cv":
                    return eCountry.Cabo_Verde;
                case "cw":
                    return eCountry.Curacao;
                case "cx":
                    return eCountry.Christmas_Island;
                case "cy":
                    return eCountry.Cyprus;
                case "cz":
                    return eCountry.Czechia;
                case "de":
                    return eCountry.Germany;
                case "dj":
                    return eCountry.Djibouti;
                case "dk":
                    return eCountry.Denmark;
                case "dm":
                    return eCountry.Dominica;
                case "do":
                    return eCountry.Dominican_Republic;
                case "dz":
                    return eCountry.Algeria;
                case "ec":
                    return eCountry.Ecuador;
                case "ee":
                    return eCountry.Estonia;
                case "eg":
                    return eCountry.Egypt;
                case "eh":
                    return eCountry.Western_Sahara;
                case "er":
                    return eCountry.Eritrea;
                case "es":
                    return eCountry.Spain;
                case "et":
                    return eCountry.Ethiopia;
                case "fi":
                    return eCountry.Finland;
                case "fj":
                    return eCountry.Fiji;
                case "fk":
                    return eCountry.Falkland_Islands;
                case "fm":
                    return eCountry.Micronesia;
                case "fo":
                    return eCountry.Faroe_Islands;
                case "fr":
                    return eCountry.France;
                case "ga":
                    return eCountry.Gabon;
                case "gb":
                    return eCountry.United_Kingdom;
                case "gd":
                    return eCountry.Grenada;
                case "ge":
                    return eCountry.Georgia;
                case "gf":
                    return eCountry.French_Guiana;
                case "gg":
                    return eCountry.Guernsey;
                case "gh":
                    return eCountry.Ghana;
                case "gi":
                    return eCountry.Gibraltar;
                case "gl":
                    return eCountry.Greenland;
                case "gm":
                    return eCountry.Gambia;
                case "gn":
                    return eCountry.Guinea;
                case "gp":
                    return eCountry.Guadeloupe;
                case "gq":
                    return eCountry.Equatorial_Guinea;
                case "gr":
                    return eCountry.Greece;
                case "gs":
                    return eCountry.South_Georgia_and_South_Sandwich_Islands;
                case "gt":
                    return eCountry.Guatemala;
                case "gu":
                    return eCountry.Guam;
                case "gw":
                    return eCountry.Guinea_Bissau;
                case "gy":
                    return eCountry.Guyana;
                case "hk":
                    return eCountry.Hong_Kong;
                case "hm":
                    return eCountry.Heard_Island_and_McDonald_Islands;
                case "hn":
                    return eCountry.Honduras;
                case "hr":
                    return eCountry.Croatia;
                case "ht":
                    return eCountry.Haiti;
                case "hu":
                    return eCountry.Hungary;
                case "id":
                    return eCountry.Indonesia;
                case "ie":
                    return eCountry.Ireland;
                case "il":
                    return eCountry.Israel;
                case "im":
                    return eCountry.Isle_of_Man;
                case "in":
                    return eCountry.India;
                case "io":
                    return eCountry.British_Indian_Ocean_Territory;
                case "iq":
                    return eCountry.Iraq;
                case "ir":
                    return eCountry.Iran;
                case "is":
                    return eCountry.Iceland;
                case "it":
                    return eCountry.Italy;
                case "je":
                    return eCountry.Jersey;
                case "jm":
                    return eCountry.Jamaica;
                case "jo":
                    return eCountry.Jordan;
                case "jp":
                    return eCountry.Japan;
                case "ke":
                    return eCountry.Kenya;
                case "kg":
                    return eCountry.Kyrgyzstan;
                case "kh":
                    return eCountry.Cambodia;
                case "ki":
                    return eCountry.Kiribati;
                case "km":
                    return eCountry.Comoros;
                case "kn":
                    return eCountry.St_Kitts_and_Nevis;
                case "kp":
                    return eCountry.North_Korea;
                case "kr":
                    return eCountry.South_Korea;
                case "kw":
                    return eCountry.Kuwait;
                case "ky":
                    return eCountry.Cayman_Islands;
                case "kz":
                    return eCountry.Kazakhstan;
                case "la":
                    return eCountry.Laos;
                case "lb":
                    return eCountry.Lebanon;
                case "lc":
                    return eCountry.Saint_Lucia;
                case "li":
                    return eCountry.Liechtenstein;
                case "lk":
                    return eCountry.Sri_Lanka;
                case "lr":
                    return eCountry.Liberia;
                case "ls":
                    return eCountry.Lesotho;
                case "lt":
                    return eCountry.Lithuania;
                case "lu":
                    return eCountry.Luxembourg;
                case "lv":
                    return eCountry.Latvia;
                case "ly":
                    return eCountry.Libya;
                case "ma":
                    return eCountry.Morocco;
                case "mc":
                    return eCountry.Monaco;
                case "md":
                    return eCountry.Moldova;
                case "me":
                    return eCountry.Montenegro;
                case "mf":
                    return eCountry.Saint_Martin;
                case "mg":
                    return eCountry.Madagascar;
                case "mh":
                    return eCountry.Marshall_Islands;
                case "mk":
                    return eCountry.North_Macedonia;
                case "ml":
                    return eCountry.Mali;
                case "mm":
                    return eCountry.Myanmar;
                case "mn":
                    return eCountry.Mongolia;
                case "mo":
                    return eCountry.Macao;
                case "mp":
                    return eCountry.Northern_Mariana_Islands;
                case "mq":
                    return eCountry.Martinique;
                case "mr":
                    return eCountry.Mauritania;
                case "ms":
                    return eCountry.Montserrat;
                case "mt":
                    return eCountry.Malta;
                case "mu":
                    return eCountry.Mauritius;
                case "mv":
                    return eCountry.Maldives;
                case "mw":
                    return eCountry.Malawi;
                case "mx":
                    return eCountry.Mexico;
                case "my":
                    return eCountry.Malaysia;
                case "mz":
                    return eCountry.Mozambique;
                case "na":
                    return eCountry.Namibia;
                case "nc":
                    return eCountry.New_Caledonia;
                case "ne":
                    return eCountry.Niger;
                case "nf":
                    return eCountry.Norfolk_Island;
                case "ng":
                    return eCountry.Nigeria;
                case "ni":
                    return eCountry.Nicaragua;
                case "nl":
                    return eCountry.Netherlands;
                case "no":
                    return eCountry.Norway;
                case "np":
                    return eCountry.Nepal;
                case "nr":
                    return eCountry.Nauru;
                case "nu":
                    return eCountry.Niue;
                case "nz":
                    return eCountry.New_Zealand;
                case "om":
                    return eCountry.Oman;
                case "pa":
                    return eCountry.Panama;
                case "pe":
                    return eCountry.Peru;
                case "pf":
                    return eCountry.French_Polynesia;
                case "pg":
                    return eCountry.Papua_New_Guinea;
                case "ph":
                    return eCountry.Philippines;
                case "pk":
                    return eCountry.Pakistan;
                case "pl":
                    return eCountry.Poland;
                case "pm":
                    return eCountry.Saint_Pierre_and_Miquelon;
                case "pn":
                    return eCountry.Pitcairn_Islands;
                case "pr":
                    return eCountry.Puerto_Rico;
                case "ps":
                    return eCountry.Palestine;
                case "pt":
                    return eCountry.Portugal;
                case "pw":
                    return eCountry.Palau;
                case "py":
                    return eCountry.Paraguay;
                case "qa":
                    return eCountry.Qatar;
                case "re":
                    return eCountry.Reunion;
                case "ro":
                    return eCountry.Romania;
                case "rs":
                    return eCountry.Serbia;
                case "ru":
                    return eCountry.Russia;
                case "rw":
                    return eCountry.Rwanda;
                case "sa":
                    return eCountry.Saudi_Arabia;
                case "sb":
                    return eCountry.Solomon_Islands;
                case "sc":
                    return eCountry.Seychelles;
                case "sd":
                    return eCountry.Sudan;
                case "se":
                    return eCountry.Sweden;
                case "sg":
                    return eCountry.Singapore;
                case "sh":
                    return eCountry.Saint_Helena;
                case "si":
                    return eCountry.Slovenia;
                case "sj":
                    return eCountry.Svalbard_and_Jan_Mayen;
                case "sk":
                    return eCountry.Slovakia;
                case "sl":
                    return eCountry.Sierra_Leone;
                case "sm":
                    return eCountry.San_Marino;
                case "sn":
                    return eCountry.Senegal;
                case "so":
                    return eCountry.Somalia;
                case "sr":
                    return eCountry.Suriname;
                case "ss":
                    return eCountry.South_Sudan;
                case "st":
                    return eCountry.Sao_Tome_and_Principe;
                case "sv":
                    return eCountry.El_Salvador;
                case "sx":
                    return eCountry.Sint_Maarten;
                case "sy":
                    return eCountry.Syria;
                case "sz":
                    return eCountry.Eswatini;
                case "tc":
                    return eCountry.Turks_and_Caicos_Islands;
                case "td":
                    return eCountry.Chad;
                case "tf":
                    return eCountry.French_Southern_Territories;
                case "tg":
                    return eCountry.Togo;
                case "th":
                    return eCountry.Thailand;
                case "tj":
                    return eCountry.Tajikistan;
                case "tk":
                    return eCountry.Tokelau;
                case "tl":
                    return eCountry.Timor_Leste;
                case "tm":
                    return eCountry.Turkmenistan;
                case "tn":
                    return eCountry.Tunisia;
                case "to":
                    return eCountry.Tonga;
                case "tr":
                    return eCountry.Turkey;
                case "tt":
                    return eCountry.Trinidad_and_Tobago;
                case "tv":
                    return eCountry.Tuvalu;
                case "tw":
                    return eCountry.Taiwan;
                case "tz":
                    return eCountry.Tanzania;
                case "ua":
                    return eCountry.Ukraine;
                case "ug":
                    return eCountry.Uganda;
                case "um":
                    return eCountry.US_Minor_Outlying_Islands;
                case "us":
                    return eCountry.United_States;
                case "uy":
                    return eCountry.Uruguay;
                case "uz":
                    return eCountry.Uzbekistan;
                case "va":
                    return eCountry.Vatican_City;
                case "vc":
                    return eCountry.St_Vincent_and_Grenadines;
                case "ve":
                    return eCountry.Venezuela;
                case "vg":
                    return eCountry.British_Virgin_Islands;
                case "vi":
                    return eCountry.US_Virgin_Islands;
                case "vn":
                    return eCountry.Vietnam;
                case "vu":
                    return eCountry.Vanuatu;
                case "wf":
                    return eCountry.Wallis_and_Futuna;
                case "ws":
                    return eCountry.Samoa;
                case "xk":
                    return eCountry.Kosovo;
                case "ye":
                    return eCountry.Yemen;
                case "yt":
                    return eCountry.Mayotte;
                case "za":
                    return eCountry.South_Africa;
                case "zm":
                    return eCountry.Zambia;
                case "zw":
                    return eCountry.Zimbabwe;
                case "os":
                    return eCountry.OpenSource;
                case "uid":
                    return eCountry.Unidentified;
                default:
                    return eCountry.NotACountry;
            }
        }

        #region Languages

        /// <summary>
        ///     Converts a string to a Country enum
        /// </summary>
        /// <param name="value">
        ///     The string to convert
        /// </param>
        /// <remarks>
        ///     This functions assumes that the given string is in the English language. If not found or misspelled, 
        ///     the function returns Country.NotACountry
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static eCountry ToCountryEnumFromEnglish(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return eCountry.NotACountry;
            }

            switch (value.ToLower())
            {
                case "andorra":
                    return eCountry.Andorra;
                case "united arab emirates":
                case "unitedarabemirates":
                case "united_arab_emirates":
                    return eCountry.United_Arab_Emirates;
                case "afghanistan":
                    return eCountry.Afghanistan;
                case "antigua and barbuda":
                case "antigua barbuda":
                case "antiguaandbarbuda":
                case "antiguabarbuda":
                case "antigua_and_barbuda":
                case "antigua_barbuda":
                case "antigua":
                case "barbuda":
                    return eCountry.Antigua_And_Barbuda;
                case "anguilla":
                    return eCountry.Anguilla;
                case "albania":
                    return eCountry.Albania;
                case "armenia":
                    return eCountry.Armenia;
                case "netherlands antilles":
                case "netherlandsantilles":
                case "netherlands_antilles":
                    return eCountry.Netherlands_Antilles;
                case "angola":
                    return eCountry.Angola;
                case "antarctica":
                    return eCountry.Antarctica;
                case "argentina":
                    return eCountry.Argentina;
                case "american samoa":
                case "americansamoa":
                case "american_samoa":
                    return eCountry.American_Samoa;
                case "austria":
                    return eCountry.Austria;
                case "australia":
                    return eCountry.Australia;
                case "aruba":
                    return eCountry.Aruba;
                case "åland":
                case "aland":
                    return eCountry.Aland;
                case "azerbaijan":
                    return eCountry.Azerbaijan;
                case "bosnia and herzegovina":
                case "bosniaandherzegovina":
                case "bosnia_and_herzegovina":
                case "bosnia":
                case "herzegovina":
                    return eCountry.Bosnia_and_Herzegovina;
                case "barbados":
                    return eCountry.Barbados;
                case "bangladesh":
                    return eCountry.Bangladesh;
                case "belgium":
                    return eCountry.Belgium;
                case "burkina faso":
                case "burkinafaso":
                case "burkina_faso":
                    return eCountry.Burkina_Faso;
                case "bulgaria":
                    return eCountry.Bulgaria;
                case "bahrain":
                    return eCountry.Bahrain;
                case "burundi":
                    return eCountry.Burundi;
                case "benin":
                    return eCountry.Benin;
                case "saint barthélemy":
                case "saintbarthélemy":
                case "saint_barthélemy":
                case "saint barthelemy":
                case "saintbarthelemy":
                case "saint_barthelemy":
                    return eCountry.Saint_Barthelemy;
                case "bermuda":
                    return eCountry.Bermuda;
                case "brunei":
                    return eCountry.Brunei;
                case "bolivia":
                    return eCountry.Bolivia;
                case "bonaire, sint eustatius, and saba":
                case "bonaire sint eustatius and saba":
                case "bonairesinteustatiusandsaba":
                case "bonaire,sinteustatius,andsaba":
                case "bonaire, sint eustatius, saba":
                case "bonairesinteustatiussaba":
                case "bonaire sint eustatius saba":
                case "bonaire_sint_eustatius_and_saba":
                case "bonaire_sint_eustatius_saba":
                    return eCountry.Bonaire_Sint_Eustatius_and_Saba;
                case "brazil":
                    return eCountry.Brazil;
                case "bahamas":
                    return eCountry.Bahamas;
                case "bhutan":
                    return eCountry.Bhutan;
                case "bouvet island":
                case "bouvetisland":
                case "bouvet_island":
                    return eCountry.Bouvet_Island;
                case "botswana":
                    return eCountry.Botswana;
                case "belarus":
                    return eCountry.Belarus;
                case "belize":
                    return eCountry.Belize;
                case "canada":
                    return eCountry.Canada;
                case "cocos [keeling] islands":
                case "cocos islands":
                case "cocos (keeling) islands":
                case "cocos[keeling]islands":
                case "cocosislands":
                case "cocos(keeling)islands":
                case "cocos keeling islands":
                case "cocoskeelingislands":
                case "cocos_[keeling]_islands":
                case "cocos_(keeling)_islands":
                case "cocos_keeling_islands":
                case "cocos_islands":
                    return eCountry.Cocos_Keeling_Islands;
                case "dr congo":
                case "drcongo":
                case "dr_congo":
                    return eCountry.DR_Congo;
                case "central african republic":
                case "centralafricanrepublic":
                case "central_african_republic":
                    return eCountry.Central_African_Republic;
                case "congo republic":
                case "congorepublic":
                case "congo_republic":
                    return eCountry.Congo_Republic;
                case "switzerland":
                    return eCountry.Switzerland;
                case "ivory coast":
                case "ivorycoast":
                case "ivory_coast":
                    return eCountry.Ivory_Coast;
                case "cook islands":
                case "cookislands":
                case "cook_islands":
                    return eCountry.Cook_Islands;
                case "chile":
                    return eCountry.Chile;
                case "cameroon":
                    return eCountry.Cameroon;
                case "china":
                    return eCountry.China;
                case "colombia":
                    return eCountry.Colombia;
                case "costa rica":
                case "costa_rica":
                case "costarica":
                    return eCountry.Costa_Rica;
                case "serbia and montenegro":
                case "serbiaandmontenegro":
                case "serbia_and_montenegro":
                case "serbia montenegro":
                case "serbiamontenegro":
                case "serbia_montenegro":
                    return eCountry.Serbia_and_Montenegro;
                case "cuba":
                    return eCountry.Cuba;
                case "cabo verde":
                case "caboverde":
                case "cabo_verde":
                    return eCountry.Cabo_Verde;
                case "curaçao":
                case "curacao":
                    return eCountry.Curacao;
                case "christmas island":
                case "christmasisland":
                case "christmas_island":
                    return eCountry.Christmas_Island;
                case "cyprus":
                    return eCountry.Cyprus;
                case "czechia":
                    return eCountry.Czechia;
                case "germany":
                    return eCountry.Germany;
                case "djibouti":
                    return eCountry.Djibouti;
                case "denmark":
                    return eCountry.Denmark;
                case "dominica":
                    return eCountry.Dominica;
                case "dominican republic":
                case "dominicanrepublic":
                case "dominican_republic":
                    return eCountry.Dominican_Republic;
                case "algeria":
                    return eCountry.Algeria;
                case "ecuador":
                    return eCountry.Ecuador;
                case "estonia":
                    return eCountry.Estonia;
                case "egypt":
                    return eCountry.Egypt;
                case "western sahara":
                case "westernsahara":
                case "western_sahara":
                    return eCountry.Western_Sahara;
                case "eritrea":
                    return eCountry.Eritrea;
                case "spain":
                    return eCountry.Spain;
                case "ethiopia":
                    return eCountry.Ethiopia;
                case "finland":
                    return eCountry.Finland;
                case "fiji":
                    return eCountry.Fiji;
                case "falkland islands":
                case "falklandislands":
                case "falkland_islands":
                    return eCountry.Falkland_Islands;
                case "micronesia":
                    return eCountry.Micronesia;
                case "faroe islands":
                case "faroeislands":
                case "faroe_islands":
                    return eCountry.Faroe_Islands;
                case "france":
                    return eCountry.France;
                case "gabon":
                    return eCountry.Gabon;
                case "united kingdom":
                case "unitedkingdom":
                case "united_kingdom":
                    return eCountry.United_Kingdom;
                case "grenada":
                    return eCountry.Grenada;
                case "georgia":
                    return eCountry.Georgia;
                case "french guiana":
                case "frenchguiana":
                case "french_guiana":
                    return eCountry.French_Guiana;
                case "guernsey":
                    return eCountry.Guernsey;
                case "ghana":
                    return eCountry.Ghana;
                case "gibraltar":
                    return eCountry.Gibraltar;
                case "greenland":
                    return eCountry.Greenland;
                case "gambia":
                    return eCountry.Gambia;
                case "guinea":
                    return eCountry.Guinea;
                case "guadeloupe":
                    return eCountry.Guadeloupe;
                case "equatorial guinea":
                case "equatorialguinea":
                case "equatorial_guinea":
                    return eCountry.Equatorial_Guinea;
                case "greece":
                    return eCountry.Greece;
                case "south georgia and south sandwich islands":
                case "southgeorgiaandsouthsandwichislands":
                case "south_georgia_and_south_sandwich_islands":
                case "south georgia south sandwich islands":
                case "southgeorgiasouthsandwichislands":
                case "south_georgia_south_sandwich_islands":
                case "south georgia":
                case "southgeorgia":
                case "south_georgia":
                case "south sandwich islands":
                case "southsandwichislands":
                case "south_sandwich_islands":
                    return eCountry.South_Georgia_and_South_Sandwich_Islands;
                case "guatemala":
                    return eCountry.Guatemala;
                case "guam":
                    return eCountry.Guam;
                case "guinea-bissau":
                case "guinea bissau":
                case "guineabissau":
                case "guinea_bissau":
                    return eCountry.Guinea_Bissau;
                case "guyana":
                    return eCountry.Guyana;
                case "hong kong":
                case "hongkong":
                case "hong_kong":
                    return eCountry.Hong_Kong;
                case "heard island and mcdonald islands":
                case "heardislandandmcdonaldislands":
                case "heard_island_and_mcdonald_islands":
                case "heard island mcdonald islands":
                case "heardislandmcdonaldislands":
                case "heard_island_mcdonald_islands":
                case "heard island":
                case "heardisland":
                case "heard_island":
                case "mcdonald islands":
                case "mcdonaldislands":
                case "mcdonald_islands":
                    return eCountry.Heard_Island_and_McDonald_Islands;
                case "honduras":
                    return eCountry.Honduras;
                case "croatia":
                    return eCountry.Croatia;
                case "haiti":
                    return eCountry.Haiti;
                case "hungary":
                    return eCountry.Hungary;
                case "indonesia":
                    return eCountry.Indonesia;
                case "ireland":
                    return eCountry.Ireland;
                case "israel":
                    return eCountry.Israel;
                case "isle of man":
                case "isleofman":
                case "isle_of_man":
                    return eCountry.Isle_of_Man;
                case "india":
                    return eCountry.India;
                case "british indian ocean territory":
                case "britishindianoceanterritory":
                case "british_indian_ocean_territory":
                    return eCountry.British_Indian_Ocean_Territory;
                case "iraq":
                    return eCountry.Iraq;
                case "iran":
                    return eCountry.Iran;
                case "iceland":
                    return eCountry.Iceland;
                case "italy":
                    return eCountry.Italy;
                case "jersey":
                    return eCountry.Jersey;
                case "jamaica":
                    return eCountry.Jamaica;
                case "jordan":
                    return eCountry.Jordan;
                case "japan":
                    return eCountry.Japan;
                case "kenya":
                    return eCountry.Kenya;
                case "kyrgyzstan":
                    return eCountry.Kyrgyzstan;
                case "cambodia":
                    return eCountry.Cambodia;
                case "kiribati":
                    return eCountry.Kiribati;
                case "comoros":
                    return eCountry.Comoros;
                case "st kitts and nevis":
                case "stkittsandnevis":
                case "st_kitts_and_nevis":
                case "st kitts":
                case "stkitts":
                case "st_kitts":
                case "nevis":
                    return eCountry.St_Kitts_and_Nevis;
                case "north korea":
                case "northkorea":
                case "north_korea":
                    return eCountry.North_Korea;
                case "south korea":
                case "southkorea":
                case "south_korea":
                    return eCountry.South_Korea;
                case "kuwait":
                    return eCountry.Kuwait;
                case "cayman islands":
                case "caymanislands":
                case "cayman_islands":
                    return eCountry.Cayman_Islands;
                case "kazakhstan":
                    return eCountry.Kazakhstan;
                case "laos":
                    return eCountry.Laos;
                case "lebanon":
                    return eCountry.Lebanon;
                case "saint lucia":
                case "saintlucia":
                case "saint_lucia":
                    return eCountry.Saint_Lucia;
                case "liechtenstein":
                    return eCountry.Liechtenstein;
                case "sri lanka":
                case "srilanka":
                case "sri_lanka":
                    return eCountry.Sri_Lanka;
                case "liberia":
                    return eCountry.Liberia;
                case "lesotho":
                    return eCountry.Lesotho;
                case "lithuania":
                    return eCountry.Lithuania;
                case "luxembourg":
                    return eCountry.Luxembourg;
                case "latvia":
                    return eCountry.Latvia;
                case "libya":
                    return eCountry.Libya;
                case "morocco":
                    return eCountry.Morocco;
                case "monaco":
                    return eCountry.Monaco;
                case "moldova":
                    return eCountry.Moldova;
                case "montenegro":
                    return eCountry.Montenegro;
                case "saint martin":
                case "saintmartin":
                case "saint_martin":
                    return eCountry.Saint_Martin;
                case "madagascar":
                    return eCountry.Madagascar;
                case "marshall islands":
                case "marshallislands":
                case "marshall_islands":
                    return eCountry.Marshall_Islands;
                case "north macedonia":
                case "northmacedonia":
                case "north_macedonia":
                    return eCountry.North_Macedonia;
                case "mali":
                    return eCountry.Mali;
                case "myanmar":
                    return eCountry.Myanmar;
                case "mongolia":
                    return eCountry.Mongolia;
                case "macao":
                    return eCountry.Macao;
                case "northern mariana islands":
                case "northernmarianaislands":
                case "northern_mariana_islands":
                    return eCountry.Northern_Mariana_Islands;
                case "martinique":
                    return eCountry.Martinique;
                case "mauritania":
                    return eCountry.Mauritania;
                case "montserrat":
                    return eCountry.Montserrat;
                case "malta":
                    return eCountry.Malta;
                case "mauritius":
                    return eCountry.Mauritius;
                case "maldives":
                    return eCountry.Maldives;
                case "malawi":
                    return eCountry.Malawi;
                case "mexico":
                    return eCountry.Mexico;
                case "malaysia":
                    return eCountry.Malaysia;
                case "mozambique":
                    return eCountry.Mozambique;
                case "namibia":
                    return eCountry.Namibia;
                case "new caledonia":
                case "newcaledonia":
                case "new_caledonia":
                    return eCountry.New_Caledonia;
                case "niger":
                    return eCountry.Niger;
                case "norfolk island":
                case "norfolkisland":
                case "norfolk_island":
                    return eCountry.Norfolk_Island;
                case "nigeria":
                    return eCountry.Nigeria;
                case "nicaragua":
                    return eCountry.Nicaragua;
                case "netherlands":
                    return eCountry.Netherlands;
                case "norway":
                    return eCountry.Norway;
                case "nepal":
                    return eCountry.Nepal;
                case "nauru":
                    return eCountry.Nauru;
                case "niue":
                    return eCountry.Niue;
                case "new zealand":
                case "newzealand":
                case "new_zealand":
                    return eCountry.New_Zealand;
                case "oman":
                    return eCountry.Oman;
                case "panama":
                    return eCountry.Panama;
                case "peru":
                    return eCountry.Peru;
                case "french polynesia":
                case "frenchpolynesia":
                case "french_polynesia":
                    return eCountry.French_Polynesia;
                case "papua new guinea":
                case "papuanewguinea":
                case "papua_new_guinea":
                    return eCountry.Papua_New_Guinea;
                case "philippines":
                    return eCountry.Philippines;
                case "pakistan":
                    return eCountry.Pakistan;
                case "poland":
                    return eCountry.Poland;
                case "saint pierre and miquelon":
                case "saintpierreandmiquelon":
                case "saint_pierre_and_miquelon":
                case "saint pierre":
                case "saintpierre":
                case "saint_pierre":
                case "miquelon":
                    return eCountry.Saint_Pierre_and_Miquelon;
                case "pitcairn islands":
                case "pitcairnislands":
                case "pitcairn_islands":
                    return eCountry.Pitcairn_Islands;
                case "puerto rico":
                case "puertorico":
                case "puerto_rico":
                    return eCountry.Puerto_Rico;
                case "palestine":
                    return eCountry.Palestine;
                case "portugal":
                    return eCountry.Portugal;
                case "palau":
                    return eCountry.Palau;
                case "paraguay":
                    return eCountry.Paraguay;
                case "qatar":
                    return eCountry.Qatar;
                case "réunion":
                case "reunion":
                    return eCountry.Reunion;
                case "romania":
                    return eCountry.Romania;
                case "serbia":
                    return eCountry.Serbia;
                case "russia":
                    return eCountry.Russia;
                case "rwanda":
                    return eCountry.Rwanda;
                case "saudi arabia":
                case "saudiarabia":
                case "saudi_arabia":
                    return eCountry.Saudi_Arabia;
                case "solomon islands":
                case "solomonislands":
                case "solomon_islands":
                    return eCountry.Solomon_Islands;
                case "seychelles":
                    return eCountry.Seychelles;
                case "sudan":
                    return eCountry.Sudan;
                case "sweden":
                    return eCountry.Sweden;
                case "singapore":
                    return eCountry.Singapore;
                case "saint helena":
                case "sainthelena":
                case "saint_helena":
                    return eCountry.Saint_Helena;
                case "slovenia":
                    return eCountry.Slovenia;
                case "svalbard and jan mayen":
                case "svalbardandjanmayen":
                case "svalbard_and_jan_mayen":
                case "svalbard":
                case "jan mayen":
                case "janmayen":
                case "jan_mayen":
                    return eCountry.Svalbard_and_Jan_Mayen;
                case "slovakia":
                    return eCountry.Slovakia;
                case "sierra leone":
                case "sierraleone":
                case "sierra_leone":
                    return eCountry.Sierra_Leone;
                case "san marino":
                case "sanmarino":
                case "san_marino":
                    return eCountry.San_Marino;
                case "senegal":
                    return eCountry.Senegal;
                case "somalia":
                    return eCountry.Somalia;
                case "suriname":
                    return eCountry.Suriname;
                case "south sudan":
                case "southsudan":
                case "south_sudan":
                    return eCountry.South_Sudan;
                case "são yomé and príncipe":
                case "sãotoméandpríncipe":
                case "são_tomé_and_príncipe":
                case "são tomé":
                case "sãotomé":
                case "são_tomé":
                case "príncipe":
                case "sao tome and principe":
                case "saotomeandprincipe":
                case "sao_tome_and_principe":
                case "sao tome":
                case "saotome":
                case "sao_tome":
                case "principe":
                    return eCountry.Sao_Tome_and_Principe;
                case "el salvador":
                case "elsalvador":
                case "el_salvador":
                    return eCountry.El_Salvador;
                case "sint maarten":
                case "sintmaarten":
                case "sint_maarten":
                    return eCountry.Sint_Maarten;
                case "syria":
                    return eCountry.Syria;
                case "eswatini":
                    return eCountry.Eswatini;
                case "turks and caicos islands":
                case "turksandcaicosislands":
                case "turks_and_caicos_islands":
                case "turks":
                case "caicos islands":
                case "caicos_islands":
                case "caicosislands":
                    return eCountry.Turks_and_Caicos_Islands;
                case "chad":
                    return eCountry.Chad;
                case "french southern territories":
                case "frenchsouthernterritories":
                case "french_southern_territories":
                    return eCountry.French_Southern_Territories;
                case "togo":
                    return eCountry.Togo;
                case "thailand":
                    return eCountry.Thailand;
                case "tajikistan":
                    return eCountry.Tajikistan;
                case "tokelau":
                    return eCountry.Tokelau;
                case "timor-leste":
                case "timor leste":
                case "timorleste":
                case "timor_leste":
                    return eCountry.Timor_Leste;
                case "turkmenistan":
                    return eCountry.Turkmenistan;
                case "tunisia":
                    return eCountry.Tunisia;
                case "tonga":
                    return eCountry.Tonga;
                case "turkey":
                    return eCountry.Turkey;
                case "trinidad and tobago":
                case "trinidadandtobago":
                case "trinidad_and_tobago":
                case "trinidad":
                case "tobago":
                    return eCountry.Trinidad_and_Tobago;
                case "tuvalu":
                    return eCountry.Tuvalu;
                case "taiwan":
                    return eCountry.Taiwan;
                case "tanzania":
                    return eCountry.Tanzania;
                case "ukraine":
                    return eCountry.Ukraine;
                case "uganda":
                    return eCountry.Uganda;
                case "u.s. minor outlying islands":
                case "u.s.minoroutlyingislands":
                case "u.s._minor_outlying_islands":
                case "u s minor outlying islands":
                case "us minor outlying islands":
                case "usminoroutlyingislands":
                case "us_minor_outlying_islands":
                case "u_s_minor_outlying_islands":
                    return eCountry.US_Minor_Outlying_Islands;
                case "united states":
                case "unitedstates":
                case "united_states":
                    return eCountry.United_States;
                case "uruguay":
                    return eCountry.Uruguay;
                case "uzbekistan":
                    return eCountry.Uzbekistan;
                case "vatican city":
                case "vaticancity":
                case "vatican_city":
                    return eCountry.Vatican_City;
                case "st vincent and grenadines":
                case "stvincentandgrenadines":
                case "st_vincent_and_grenadines":
                case "grenadines":
                case "st vincent":
                case "stvincent":
                case "st_vincent":
                case "st vincent grenadines":
                case "stvincentgrenadines":
                case "st_vincent_grenadines":
                    return eCountry.St_Vincent_and_Grenadines;
                case "venezuela":
                    return eCountry.Venezuela;
                case "british virgin islands":
                case "britishvirginislands":
                case "british_virgin_islands":
                    return eCountry.British_Virgin_Islands;
                case "u.s. virgin islands":
                case "u.s.virginislands":
                case "u.s._virgin_islands":
                case "u s virgin islands":
                case "us virgin islands":
                case "usvirginislands":
                case "us_virgin_islands":
                case "u_s_virgin_islands":
                    return eCountry.US_Virgin_Islands;
                case "vietnam":
                    return eCountry.Vietnam;
                case "vanuatu":
                    return eCountry.Vanuatu;
                case "wallis and futuna":
                case "wallisandfutuna":
                case "wallis_and_futuna":
                case "wallis":
                case "futuna":
                    return eCountry.Wallis_and_Futuna;
                case "samoa":
                    return eCountry.Samoa;
                case "kosovo":
                    return eCountry.Kosovo;
                case "yemen":
                    return eCountry.Yemen;
                case "mayotte":
                    return eCountry.Mayotte;
                case "south africa":
                case "southafrica":
                case "south_africa":
                    return eCountry.South_Africa;
                case "zambia":
                    return eCountry.Zambia;
                case "zimbabwe":
                    return eCountry.Zimbabwe;
                default:
                    return eCountry.NotACountry;
            }
        }

        #endregion

        #endregion

        #region Enum To String


        /// <summary>
        ///     Converts a Country enum to a string
        /// </summary>
        /// <param name="value">
        ///     The Country enum to convert
        /// </param>
        /// <param name="language">
        ///     The Language for the conversion
        /// </param>
        /// <remarks>
        ///     If no language is provided, then the order of languages to convert to, if there is no 
        ///     representation of the enum in the previous language, are as follows
        ///    1) English
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static string ToCountryName(this eCountry value, Language language = Language.Unknown)
        {
            switch (language)
            {
                case Language.English:
                    return value.ToCountryName_English();
                default:
                    string stringValue = string.Empty;
                    if (string.IsNullOrEmpty(stringValue))
                    {
                        stringValue = value.ToCountryName_English();
                    }
                    return stringValue;
            }
        }

        /// <summary>
        ///     Converts a Country name to Country code
        /// </summary>
        /// <param name="value">
        ///     The string to convert
        /// </param>
        /// <returns>
        ///     string
        /// </returns>
        public static string ToCountryCodeFromName(this string value)
        {
            return value.ToCountryEnum().ToCountryCode();
        }

        /// <summary>
        ///     Converts a Country code to Country name
        /// </summary>
        /// <param name="value">
        ///     The string to convert
        /// </param>
        /// <returns>
        ///     string
        /// </returns>
        public static string ToCountryNameFromCode(this string value)
        {
            return value.ToCountryEnum().ToCountryName();
        }

        /// <summary>
        ///     Converts a Country enum to a two character string conforming to ISO 3166
        /// </summary>
        /// <param name="value">
        ///     The string to convert
        /// </param>
        /// <returns>
        ///     string
        /// </returns>
        public static string ToCountryCode(this eCountry value)
        {
            switch (value)
            {
                case eCountry.Andorra:
                    return "AD";
                case eCountry.United_Arab_Emirates:
                    return "AE";
                case eCountry.Afghanistan:
                    return "AF";
                case eCountry.Antigua_And_Barbuda:
                    return "AG";
                case eCountry.Anguilla:
                    return "AI";
                case eCountry.Albania:
                    return "AL";
                case eCountry.Armenia:
                    return "AM";
                case eCountry.Netherlands_Antilles:
                    return "AN";
                case eCountry.Angola:
                    return "AO";
                case eCountry.Antarctica:
                    return "AQ";
                case eCountry.Argentina:
                    return "AR";
                case eCountry.American_Samoa:
                    return "AS";
                case eCountry.Austria:
                    return "AT";
                case eCountry.Australia:
                    return "AU";
                case eCountry.Aruba:
                    return "AW";
                case eCountry.Aland:
                    return "AX";
                case eCountry.Azerbaijan:
                    return "AZ";
                case eCountry.Bosnia_and_Herzegovina:
                    return "BA";
                case eCountry.Barbados:
                    return "BB";
                case eCountry.Bangladesh:
                    return "BD";
                case eCountry.Belgium:
                    return "BE";
                case eCountry.Burkina_Faso:
                    return "BF";
                case eCountry.Bulgaria:
                    return "BG";
                case eCountry.Bahrain:
                    return "BH";
                case eCountry.Burundi:
                    return "BI";
                case eCountry.Benin:
                    return "BJ";
                case eCountry.Saint_Barthelemy:
                    return "BL";
                case eCountry.Bermuda:
                    return "BM";
                case eCountry.Brunei:
                    return "BN";
                case eCountry.Bolivia:
                    return "BO";
                case eCountry.Bonaire_Sint_Eustatius_and_Saba:
                    return "BQ";
                case eCountry.Brazil:
                    return "BR";
                case eCountry.Bahamas:
                    return "BS";
                case eCountry.Bhutan:
                    return "BT";
                case eCountry.Bouvet_Island:
                    return "BV";
                case eCountry.Botswana:
                    return "BW";
                case eCountry.Belarus:
                    return "BY";
                case eCountry.Belize:
                    return "BZ";
                case eCountry.Canada:
                    return "CA";
                case eCountry.Cocos_Keeling_Islands:
                    return "CC";
                case eCountry.DR_Congo:
                    return "CD";
                case eCountry.Central_African_Republic:
                    return "CF";
                case eCountry.Congo_Republic:
                    return "CG";
                case eCountry.Switzerland:
                    return "CH";
                case eCountry.Ivory_Coast:
                    return "CI";
                case eCountry.Cook_Islands:
                    return "CK";
                case eCountry.Chile:
                    return "CL";
                case eCountry.Cameroon:
                    return "CM";
                case eCountry.China:
                    return "CN";
                case eCountry.Colombia:
                    return "CO";
                case eCountry.Costa_Rica:
                    return "CR";
                case eCountry.Serbia_and_Montenegro:
                    return "CS";
                case eCountry.Cuba:
                    return "CU";
                case eCountry.Cabo_Verde:
                    return "CV";
                case eCountry.Curacao:
                    return "CW";
                case eCountry.Christmas_Island:
                    return "CX";
                case eCountry.Cyprus:
                    return "CY";
                case eCountry.Czechia:
                    return "CZ";
                case eCountry.Germany:
                    return "DE";
                case eCountry.Djibouti:
                    return "DJ";
                case eCountry.Denmark:
                    return "DK";
                case eCountry.Dominica:
                    return "DM";
                case eCountry.Dominican_Republic:
                    return "DO";
                case eCountry.Algeria:
                    return "DZ";
                case eCountry.Ecuador:
                    return "EC";
                case eCountry.Estonia:
                    return "EE";
                case eCountry.Egypt:
                    return "EG";
                case eCountry.Western_Sahara:
                    return "EH";
                case eCountry.Eritrea:
                    return "ER";
                case eCountry.Spain:
                    return "ES";
                case eCountry.Ethiopia:
                    return "ET";
                case eCountry.Finland:
                    return "FI";
                case eCountry.Fiji:
                    return "FJ";
                case eCountry.Falkland_Islands:
                    return "FK";
                case eCountry.Micronesia:
                    return "FM";
                case eCountry.Faroe_Islands:
                    return "FO";
                case eCountry.France:
                    return "FR";
                case eCountry.Gabon:
                    return "GA";
                case eCountry.United_Kingdom:
                    return "GB";
                case eCountry.Grenada:
                    return "GD";
                case eCountry.Georgia:
                    return "GE";
                case eCountry.French_Guiana:
                    return "GF";
                case eCountry.Guernsey:
                    return "GG";
                case eCountry.Ghana:
                    return "GH";
                case eCountry.Gibraltar:
                    return "GI";
                case eCountry.Greenland:
                    return "GL";
                case eCountry.Gambia:
                    return "GM";
                case eCountry.Guinea:
                    return "GN";
                case eCountry.Guadeloupe:
                    return "GP";
                case eCountry.Equatorial_Guinea:
                    return "GQ";
                case eCountry.Greece:
                    return "GR";
                case eCountry.South_Georgia_and_South_Sandwich_Islands:
                    return "GS";
                case eCountry.Guatemala:
                    return "GT";
                case eCountry.Guam:
                    return "GU";
                case eCountry.Guinea_Bissau:
                    return "GW";
                case eCountry.Guyana:
                    return "GY";
                case eCountry.Hong_Kong:
                    return "HK";
                case eCountry.Heard_Island_and_McDonald_Islands:
                    return "HM";
                case eCountry.Honduras:
                    return "HN";
                case eCountry.Croatia:
                    return "HR";
                case eCountry.Haiti:
                    return "HT";
                case eCountry.Hungary:
                    return "HU";
                case eCountry.Indonesia:
                    return "ID";
                case eCountry.Ireland:
                    return "IE";
                case eCountry.Israel:
                    return "IL";
                case eCountry.Isle_of_Man:
                    return "IM";
                case eCountry.India:
                    return "IN";
                case eCountry.British_Indian_Ocean_Territory:
                    return "IO";
                case eCountry.Iraq:
                    return "IQ";
                case eCountry.Iran:
                    return "IR";
                case eCountry.Iceland:
                    return "IS";
                case eCountry.Italy:
                    return "IT";
                case eCountry.Jersey:
                    return "JE";
                case eCountry.Jamaica:
                    return "JM";
                case eCountry.Jordan:
                    return "JO";
                case eCountry.Japan:
                    return "JP";
                case eCountry.Kenya:
                    return "KE";
                case eCountry.Kyrgyzstan:
                    return "KG";
                case eCountry.Cambodia:
                    return "KH";
                case eCountry.Kiribati:
                    return "KI";
                case eCountry.Comoros:
                    return "KM";
                case eCountry.St_Kitts_and_Nevis:
                    return "KN";
                case eCountry.North_Korea:
                    return "KP";
                case eCountry.South_Korea:
                    return "KR";
                case eCountry.Kuwait:
                    return "KW";
                case eCountry.Cayman_Islands:
                    return "KY";
                case eCountry.Kazakhstan:
                    return "KZ";
                case eCountry.Laos:
                    return "LA";
                case eCountry.Lebanon:
                    return "LB";
                case eCountry.Saint_Lucia:
                    return "LC";
                case eCountry.Liechtenstein:
                    return "LI";
                case eCountry.Sri_Lanka:
                    return "LK";
                case eCountry.Liberia:
                    return "LR";
                case eCountry.Lesotho:
                    return "LS";
                case eCountry.Lithuania:
                    return "LT";
                case eCountry.Luxembourg:
                    return "LU";
                case eCountry.Latvia:
                    return "LV";
                case eCountry.Libya:
                    return "LY";
                case eCountry.Morocco:
                    return "MO";
                case eCountry.Monaco:
                    return "MC";
                case eCountry.Moldova:
                    return "MD";
                case eCountry.Montenegro:
                    return "ME";
                case eCountry.Saint_Martin:
                    return "MF";
                case eCountry.Madagascar:
                    return "MG";
                case eCountry.Marshall_Islands:
                    return "MH";
                case eCountry.North_Macedonia:
                    return "MK";
                case eCountry.Mali:
                    return "ML";
                case eCountry.Myanmar:
                    return "MM";
                case eCountry.Mongolia:
                    return "MN";
                case eCountry.Macao:
                    return "MO";
                case eCountry.Northern_Mariana_Islands:
                    return "MP";
                case eCountry.Martinique:
                    return "MQ";
                case eCountry.Mauritania:
                    return "MR";
                case eCountry.Montserrat:
                    return "MS";
                case eCountry.Malta:
                    return "MT";
                case eCountry.Mauritius:
                    return "MU";
                case eCountry.Maldives:
                    return "MV";
                case eCountry.Malawi:
                    return "MW";
                case eCountry.Mexico:
                    return "MX";
                case eCountry.Malaysia:
                    return "MY";
                case eCountry.Mozambique:
                    return "MZ";
                case eCountry.Namibia:
                    return "NA";
                case eCountry.New_Caledonia:
                    return "NC";
                case eCountry.Niger:
                    return "NE";
                case eCountry.Norfolk_Island:
                    return "NF";
                case eCountry.Nigeria:
                    return "NG";
                case eCountry.Nicaragua:
                    return "NI";
                case eCountry.Netherlands:
                    return "NL";
                case eCountry.Norway:
                    return "NO";
                case eCountry.Nepal:
                    return "NP";
                case eCountry.Nauru:
                    return "NR";
                case eCountry.Niue:
                    return "NU";
                case eCountry.New_Zealand:
                    return "NZ";
                case eCountry.Oman:
                    return "OM";
                case eCountry.Panama:
                    return "PA";
                case eCountry.Peru:
                    return "PE";
                case eCountry.French_Polynesia:
                    return "PF";
                case eCountry.Papua_New_Guinea:
                    return "PG";
                case eCountry.Philippines:
                    return "PH";
                case eCountry.Pakistan:
                    return "PK";
                case eCountry.Poland:
                    return "PL";
                case eCountry.Saint_Pierre_and_Miquelon:
                    return "PM";
                case eCountry.Pitcairn_Islands:
                    return "PN";
                case eCountry.Puerto_Rico:
                    return "PR";
                case eCountry.Palestine:
                    return "PS";
                case eCountry.Portugal:
                    return "PT";
                case eCountry.Palau:
                    return "PW";
                case eCountry.Paraguay:
                    return "PY";
                case eCountry.Qatar:
                    return "QA";
                case eCountry.Reunion:
                    return "RE";
                case eCountry.Romania:
                    return "RO";
                case eCountry.Serbia:
                    return "RS";
                case eCountry.Russia:
                    return "RU";
                case eCountry.Rwanda:
                    return "RW";
                case eCountry.Saudi_Arabia:
                    return "SA";
                case eCountry.Solomon_Islands:
                    return "SB";
                case eCountry.Seychelles:
                    return "SC";
                case eCountry.Sudan:
                    return "SD";
                case eCountry.Sweden:
                    return "SE";
                case eCountry.Singapore:
                    return "SG";
                case eCountry.Saint_Helena:
                    return "SH";
                case eCountry.Slovenia:
                    return "SI";
                case eCountry.Svalbard_and_Jan_Mayen:
                    return "SJ";
                case eCountry.Slovakia:
                    return "SK";
                case eCountry.Sierra_Leone:
                    return "SL";
                case eCountry.San_Marino:
                    return "SM";
                case eCountry.Senegal:
                    return "SN";
                case eCountry.Somalia:
                    return "SO";
                case eCountry.Suriname:
                    return "SR";
                case eCountry.South_Sudan:
                    return "SS";
                case eCountry.Sao_Tome_and_Principe:
                    return "ST";
                case eCountry.El_Salvador:
                    return "SV";
                case eCountry.Sint_Maarten:
                    return "SX";
                case eCountry.Syria:
                    return "SY";
                case eCountry.Eswatini:
                    return "SZ";
                case eCountry.Turks_and_Caicos_Islands:
                    return "TC";
                case eCountry.Chad:
                    return "TD";
                case eCountry.French_Southern_Territories:
                    return "TF";
                case eCountry.Togo:
                    return "TG";
                case eCountry.Thailand:
                    return "TH";
                case eCountry.Tajikistan:
                    return "TJ";
                case eCountry.Tokelau:
                    return "TK";
                case eCountry.Timor_Leste:
                    return "TL";
                case eCountry.Turkmenistan:
                    return "TM";
                case eCountry.Tunisia:
                    return "TN";
                case eCountry.Tonga:
                    return "TO";
                case eCountry.Turkey:
                    return "TR";
                case eCountry.Trinidad_and_Tobago:
                    return "TT";
                case eCountry.Tuvalu:
                    return "TV";
                case eCountry.Taiwan:
                    return "TW";
                case eCountry.Tanzania:
                    return "TZ";
                case eCountry.Ukraine:
                    return "UA";
                case eCountry.Uganda:
                    return "UG";
                case eCountry.US_Minor_Outlying_Islands:
                    return "UM";
                case eCountry.United_States:
                    return "US";
                case eCountry.Uruguay:
                    return "UY";
                case eCountry.Uzbekistan:
                    return "UZ";
                case eCountry.Vatican_City:
                    return "VA";
                case eCountry.St_Vincent_and_Grenadines:
                    return "VC";
                case eCountry.Venezuela:
                    return "VE";
                case eCountry.British_Virgin_Islands:
                    return "VG";
                case eCountry.US_Virgin_Islands:
                    return "VI";
                case eCountry.Vietnam:
                    return "VN";
                case eCountry.Vanuatu:
                    return "VU";
                case eCountry.Wallis_and_Futuna:
                    return "WF";
                case eCountry.Samoa:
                    return "WS";
                case eCountry.Kosovo:
                    return "XK";
                case eCountry.Yemen:
                    return "YE";
                case eCountry.Mayotte:
                    return "YT";
                case eCountry.South_Africa:
                    return "ZA";
                case eCountry.Zambia:
                    return "ZM";
                case eCountry.Zimbabwe:
                    return "ZW";
                default:
                    return string.Empty;
            }
        }

        #region Languages

        /// <summary>
        ///     Converts a Country enum to a English langauge string
        /// </summary>
        /// <param name="value">
        ///     The string to convert
        /// </param>
        /// <remarks>
        ///     Assumes English language is used for Value
        /// </remarks>
        /// <returns>
        ///     string
        /// </returns>
        public static string ToCountryName_English(this eCountry value)
        {
            switch (value)
            {
                case eCountry.Andorra:
                    return "Andorra";
                case eCountry.United_Arab_Emirates:
                    return "United Arab Emirates";
                case eCountry.Afghanistan:
                    return "Afghanistan";
                case eCountry.Antigua_And_Barbuda:
                    return "Antigua and Barbuda";
                case eCountry.Anguilla:
                    return "Anguilla";
                case eCountry.Albania:
                    return "Albania";
                case eCountry.Armenia:
                    return "Armenia";
                case eCountry.Netherlands_Antilles:
                    return "Netherlands Antilles";
                case eCountry.Angola:
                    return "Angola";
                case eCountry.Antarctica:
                    return "Antarctica";
                case eCountry.Argentina:
                    return "Argentina";
                case eCountry.American_Samoa:
                    return "American Samoa";
                case eCountry.Austria:
                    return "Austria";
                case eCountry.Australia:
                    return "Australia";
                case eCountry.Aruba:
                    return "Aruba";
                case eCountry.Aland:
                    return "Åland";
                case eCountry.Azerbaijan:
                    return "Azerbaijan";
                case eCountry.Bosnia_and_Herzegovina:
                    return "Bosnia and Herzegovina";
                case eCountry.Barbados:
                    return "Barbados";
                case eCountry.Bangladesh:
                    return "Bangladesh";
                case eCountry.Belgium:
                    return "Belgium";
                case eCountry.Burkina_Faso:
                    return "Burkina Faso";
                case eCountry.Bulgaria:
                    return "Bulgaria";
                case eCountry.Bahrain:
                    return "Bahrain";
                case eCountry.Burundi:
                    return "Burundi";
                case eCountry.Benin:
                    return "Benin";
                case eCountry.Saint_Barthelemy:
                    return "Saint Barthélemy";
                case eCountry.Bermuda:
                    return "Bermuda";
                case eCountry.Brunei:
                    return "Brunei";
                case eCountry.Bolivia:
                    return "Bolivia";
                case eCountry.Bonaire_Sint_Eustatius_and_Saba:
                    return "Bonaire, Sint Eustatius, and Saba";
                case eCountry.Brazil:
                    return "Brazil";
                case eCountry.Bahamas:
                    return "Bahamas";
                case eCountry.Bhutan:
                    return "Bhutan";
                case eCountry.Bouvet_Island:
                    return "Bouvet Island";
                case eCountry.Botswana:
                    return "Botswana";
                case eCountry.Belarus:
                    return "Belarus";
                case eCountry.Belize:
                    return "Belize";
                case eCountry.Canada:
                    return "Canada";
                case eCountry.Cocos_Keeling_Islands:
                    return "Cocos [Keeling] Islands";
                case eCountry.DR_Congo:
                    return "DR Congo";
                case eCountry.Central_African_Republic:
                    return "Central African Republic";
                case eCountry.Congo_Republic:
                    return "Congo Republic";
                case eCountry.Switzerland:
                    return "Switzerland";
                case eCountry.Ivory_Coast:
                    return "Ivory Coast";
                case eCountry.Cook_Islands:
                    return "Cook Islands";
                case eCountry.Chile:
                    return "Chile";
                case eCountry.Cameroon:
                    return "Cameroon";
                case eCountry.China:
                    return "China";
                case eCountry.Colombia:
                    return "Colombia";
                case eCountry.Costa_Rica:
                    return "Costa Rica";
                case eCountry.Serbia_and_Montenegro:
                    return "Serbia and Montenegro";
                case eCountry.Cuba:
                    return "Cuba";
                case eCountry.Cabo_Verde:
                    return "Cabo Verde";
                case eCountry.Curacao:
                    return "Curaçao";
                case eCountry.Christmas_Island:
                    return "Christmas Island";
                case eCountry.Cyprus:
                    return "Cyprus";
                case eCountry.Czechia:
                    return "Czechia";
                case eCountry.Germany:
                    return "Germany";
                case eCountry.Djibouti:
                    return "Djibouti";
                case eCountry.Denmark:
                    return "Denmark";
                case eCountry.Dominica:
                    return "Dominica";
                case eCountry.Dominican_Republic:
                    return "Dominican Republic";
                case eCountry.Algeria:
                    return "Algeria";
                case eCountry.Ecuador:
                    return "Ecuador";
                case eCountry.Estonia:
                    return "Estonia";
                case eCountry.Egypt:
                    return "Egypt";
                case eCountry.Western_Sahara:
                    return "Western Sahara";
                case eCountry.Eritrea:
                    return "Eritrea";
                case eCountry.Spain:
                    return "Spain";
                case eCountry.Ethiopia:
                    return "Ethiopia";
                case eCountry.Finland:
                    return "Finland";
                case eCountry.Fiji:
                    return "Fiji";
                case eCountry.Falkland_Islands:
                    return "Falkland Islands";
                case eCountry.Micronesia:
                    return "Micronesia";
                case eCountry.Faroe_Islands:
                    return "Faroe Islands";
                case eCountry.France:
                    return "France";
                case eCountry.Gabon:
                    return "Gabon";
                case eCountry.United_Kingdom:
                    return "United Kingdom";
                case eCountry.Grenada:
                    return "Grenada";
                case eCountry.Georgia:
                    return "Georgia";
                case eCountry.French_Guiana:
                    return "French Guiana";
                case eCountry.Guernsey:
                    return "Guernsey";
                case eCountry.Ghana:
                    return "Ghana";
                case eCountry.Gibraltar:
                    return "Gibraltar";
                case eCountry.Greenland:
                    return "Greenland";
                case eCountry.Gambia:
                    return "Gambia";
                case eCountry.Guinea:
                    return "Guinea";
                case eCountry.Guadeloupe:
                    return "Guadeloupe";
                case eCountry.Equatorial_Guinea:
                    return "Equatorial Guinea";
                case eCountry.Greece:
                    return "Greece";
                case eCountry.South_Georgia_and_South_Sandwich_Islands:
                    return "South Georgia and South Sandwich Islands";
                case eCountry.Guatemala:
                    return "Guatemala";
                case eCountry.Guam:
                    return "Guam";
                case eCountry.Guinea_Bissau:
                    return "Guinea-Bissau";
                case eCountry.Guyana:
                    return "Guyana";
                case eCountry.Hong_Kong:
                    return "Hong Kong";
                case eCountry.Heard_Island_and_McDonald_Islands:
                    return "Heard Island and McDonald Islands";
                case eCountry.Honduras:
                    return "Honduras";
                case eCountry.Croatia:
                    return "Croatia";
                case eCountry.Haiti:
                    return "Haiti";
                case eCountry.Hungary:
                    return "Hungary";
                case eCountry.Indonesia:
                    return "Indonesia";
                case eCountry.Ireland:
                    return "Ireland";
                case eCountry.Israel:
                    return "Israel";
                case eCountry.Isle_of_Man:
                    return "Isle of Man";
                case eCountry.India:
                    return "India";
                case eCountry.British_Indian_Ocean_Territory:
                    return "British Indian Ocean Territory";
                case eCountry.Iraq:
                    return "Iraq";
                case eCountry.Iran:
                    return "Iran";
                case eCountry.Iceland:
                    return "Iceland";
                case eCountry.Italy:
                    return "Italy";
                case eCountry.Jersey:
                    return "Jersey";
                case eCountry.Jamaica:
                    return "Jamaica";
                case eCountry.Jordan:
                    return "Jordan";
                case eCountry.Japan:
                    return "Japan";
                case eCountry.Kenya:
                    return "Kenya";
                case eCountry.Kyrgyzstan:
                    return "Kyrgyzstan";
                case eCountry.Cambodia:
                    return "Cambodia";
                case eCountry.Kiribati:
                    return "Kiribati";
                case eCountry.Comoros:
                    return "Comoros";
                case eCountry.St_Kitts_and_Nevis:
                    return "St Kitts and Nevis";
                case eCountry.North_Korea:
                    return "North Korea";
                case eCountry.South_Korea:
                    return "South Korea";
                case eCountry.Kuwait:
                    return "Kuwait";
                case eCountry.Cayman_Islands:
                    return "Cayman Islands";
                case eCountry.Kazakhstan:
                    return "Kazakhstan";
                case eCountry.Laos:
                    return "Laos";
                case eCountry.Lebanon:
                    return "Lebanon";
                case eCountry.Saint_Lucia:
                    return "Saint Lucia";
                case eCountry.Liechtenstein:
                    return "Liechtenstein";
                case eCountry.Sri_Lanka:
                    return "Sri Lanka";
                case eCountry.Liberia:
                    return "Liberia";
                case eCountry.Lesotho:
                    return "Lesotho";
                case eCountry.Lithuania:
                    return "Lithuania";
                case eCountry.Luxembourg:
                    return "Luxembourg";
                case eCountry.Latvia:
                    return "Latvia";
                case eCountry.Libya:
                    return "Libya";
                case eCountry.Morocco:
                    return "Morocco";
                case eCountry.Monaco:
                    return "Monaco";
                case eCountry.Moldova:
                    return "Moldova";
                case eCountry.Montenegro:
                    return "Montenegro";
                case eCountry.Saint_Martin:
                    return "Saint Martin";
                case eCountry.Madagascar:
                    return "Madagascar";
                case eCountry.Marshall_Islands:
                    return "Marshall Islands";
                case eCountry.North_Macedonia:
                    return "North Macedonia";
                case eCountry.Mali:
                    return "Mali";
                case eCountry.Myanmar:
                    return "Myanmar";
                case eCountry.Mongolia:
                    return "Mongolia";
                case eCountry.Macao:
                    return "Macao";
                case eCountry.Northern_Mariana_Islands:
                    return "Northern Mariana Islands";
                case eCountry.Martinique:
                    return "Martinique";
                case eCountry.Mauritania:
                    return "Mauritania";
                case eCountry.Montserrat:
                    return "Montserrat";
                case eCountry.Malta:
                    return "Malta";
                case eCountry.Mauritius:
                    return "Mauritius";
                case eCountry.Maldives:
                    return "Maldives";
                case eCountry.Malawi:
                    return "Malawi";
                case eCountry.Mexico:
                    return "Mexico";
                case eCountry.Malaysia:
                    return "Malaysia";
                case eCountry.Mozambique:
                    return "Mozambique";
                case eCountry.Namibia:
                    return "Namibia";
                case eCountry.New_Caledonia:
                    return "New Caledonia";
                case eCountry.Niger:
                    return "Niger";
                case eCountry.Norfolk_Island:
                    return "Norfolk Island";
                case eCountry.Nigeria:
                    return "Nigeria";
                case eCountry.Nicaragua:
                    return "Nicaragua";
                case eCountry.Netherlands:
                    return "Netherlands";
                case eCountry.Norway:
                    return "Norway";
                case eCountry.Nepal:
                    return "Nepal";
                case eCountry.Nauru:
                    return "Nauru";
                case eCountry.Niue:
                    return "Niue";
                case eCountry.New_Zealand:
                    return "New Zealand";
                case eCountry.Oman:
                    return "Oman";
                case eCountry.Panama:
                    return "Panama";
                case eCountry.Peru:
                    return "Peru";
                case eCountry.French_Polynesia:
                    return "French Polynesia";
                case eCountry.Papua_New_Guinea:
                    return "Papua New Guinea";
                case eCountry.Philippines:
                    return "Philippines";
                case eCountry.Pakistan:
                    return "Pakistan";
                case eCountry.Poland:
                    return "Poland";
                case eCountry.Saint_Pierre_and_Miquelon:
                    return "Saint Pierre and Miquelon";
                case eCountry.Pitcairn_Islands:
                    return "Pitcairn Islands";
                case eCountry.Puerto_Rico:
                    return "Puerto Rico";
                case eCountry.Palestine:
                    return "Palestine";
                case eCountry.Portugal:
                    return "Portugal";
                case eCountry.Palau:
                    return "Palau";
                case eCountry.Paraguay:
                    return "Paraguay";
                case eCountry.Qatar:
                    return "Qatar";
                case eCountry.Reunion:
                    return "Réunion";
                case eCountry.Romania:
                    return "Romania";
                case eCountry.Serbia:
                    return "Serbia";
                case eCountry.Russia:
                    return "Russia";
                case eCountry.Rwanda:
                    return "Rwanda";
                case eCountry.Saudi_Arabia:
                    return "Saudi Arabia";
                case eCountry.Solomon_Islands:
                    return "Solomon Islands";
                case eCountry.Seychelles:
                    return "Seychelles";
                case eCountry.Sudan:
                    return "Sudan";
                case eCountry.Sweden:
                    return "Sweden";
                case eCountry.Singapore:
                    return "Singapore";
                case eCountry.Saint_Helena:
                    return "Saint Helena";
                case eCountry.Slovenia:
                    return "Slovenia";
                case eCountry.Svalbard_and_Jan_Mayen:
                    return "Svalbard and Jan Mayen";
                case eCountry.Slovakia:
                    return "Slovakia";
                case eCountry.Sierra_Leone:
                    return "Sierra Leone";
                case eCountry.San_Marino:
                    return "San Marino";
                case eCountry.Senegal:
                    return "Senegal";
                case eCountry.Somalia:
                    return "Somalia";
                case eCountry.Suriname:
                    return "Suriname";
                case eCountry.South_Sudan:
                    return "South Sudan";
                case eCountry.Sao_Tome_and_Principe:
                    return "São Tomé and Príncipe";
                case eCountry.El_Salvador:
                    return "El Salvador";
                case eCountry.Sint_Maarten:
                    return "Sint Maarten";
                case eCountry.Syria:
                    return "Syria";
                case eCountry.Eswatini:
                    return "Eswatini";
                case eCountry.Turks_and_Caicos_Islands:
                    return "Turks and Caicos Islands";
                case eCountry.Chad:
                    return "Chad";
                case eCountry.French_Southern_Territories:
                    return "French Southern Territories";
                case eCountry.Togo:
                    return "Togo";
                case eCountry.Thailand:
                    return "Thailand";
                case eCountry.Tajikistan:
                    return "Tajikistan";
                case eCountry.Tokelau:
                    return "Tokelau";
                case eCountry.Timor_Leste:
                    return "Timor-Leste";
                case eCountry.Turkmenistan:
                    return "Turkmenistan";
                case eCountry.Tunisia:
                    return "Tunisia";
                case eCountry.Tonga:
                    return "Tonga";
                case eCountry.Turkey:
                    return "Turkey";
                case eCountry.Trinidad_and_Tobago:
                    return "Trinidad and Tobago";
                case eCountry.Tuvalu:
                    return "Tuvalu";
                case eCountry.Taiwan:
                    return "Taiwan";
                case eCountry.Tanzania:
                    return "Tanzania";
                case eCountry.Ukraine:
                    return "Ukraine";
                case eCountry.Uganda:
                    return "Uganda";
                case eCountry.US_Minor_Outlying_Islands:
                    return "U.S. Minor Outlying Islands";
                case eCountry.United_States:
                    return "United States";
                case eCountry.Uruguay:
                    return "Uruguay";
                case eCountry.Uzbekistan:
                    return "Uzbekistan";
                case eCountry.Vatican_City:
                    return "Vatican City";
                case eCountry.St_Vincent_and_Grenadines:
                    return "St Vincent and Grenadines";
                case eCountry.Venezuela:
                    return "Venezuela";
                case eCountry.British_Virgin_Islands:
                    return "British Virgin Islands";
                case eCountry.US_Virgin_Islands:
                    return "U.S. Virgin Islands";
                case eCountry.Vietnam:
                    return "Vietnam";
                case eCountry.Vanuatu:
                    return "Vanuatu";
                case eCountry.Wallis_and_Futuna:
                    return "Wallis and Futuna";
                case eCountry.Samoa:
                    return "Samoa";
                case eCountry.Kosovo:
                    return "Kosovo";
                case eCountry.Yemen:
                    return "Yemen";
                case eCountry.Mayotte:
                    return "Mayotte";
                case eCountry.South_Africa:
                    return "South Africa";
                case eCountry.Zambia:
                    return "Zambia";
                case eCountry.Zimbabwe:
                    return "Zimbabwe";
                case eCountry.OpenSource:
                    return "Open Source";
                case eCountry.Unidentified:
                    return "Unidentified";
                default:
                    return string.Empty;
            }
        }

        #endregion

        #endregion
    }

}
