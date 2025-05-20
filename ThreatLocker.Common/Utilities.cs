using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using ThreatLockerCommon.Enums;
using ThreatLockerCommon.Models;

namespace ThreatLockerCommon
{
    public static class Utilities
    {
        public static bool IsEmptyGuid(this string guid)
        {
            Guid.TryParse(guid, out Guid testVal);

            return testVal == Guid.Empty;
        }

        public static bool IsNullOrEmpty(this Guid guid)
        {
            return guid == null || guid.Equals(Guid.Empty);
        }

        public static bool IsNullOrEmpty(this Guid? guid)
        {
            return !guid.HasValue || guid.Value.Equals(Guid.Empty);
        }

        public static bool IsEmptyGuid(this Guid guid)
        {
            return guid.Equals(Guid.Empty);
        }

        public static List<AppliesToHierarchy> AddHierarchy(this List<AppliesToHierarchy> hierarchyList, Guid appliesToId, HierarchyLevel level)
        {
            if (hierarchyList == null 
                || appliesToId.IsEmptyGuid()
                || hierarchyList.Any(x => x.AppliesToId == appliesToId))
            {
                return hierarchyList;
            }

            hierarchyList.Add(new AppliesToHierarchy
            {
                AppliesToId = appliesToId,
                HierarchyLevel = level
            });

            return hierarchyList;
        }

        public static bool IsEmptyGuid(this Guid? guid)
        {
            return !guid.HasValue || guid.Value.Equals(Guid.Empty);
        }

        public static bool IsGuidEmptyOrNew(string guid)
        {
            if (string.IsNullOrWhiteSpace(guid))
            {
                return true;
            }

            Guid testVal;

            Guid.TryParse(guid, out testVal);

            return testVal == Guid.Empty;
        }

        public static bool IsEmptyHash(this string hash) => string.IsNullOrWhiteSpace(hash) || hash == "00000000000000000000000000000000";
        
        public static bool IsEmptySha256(this string sha256) => string.IsNullOrWhiteSpace(sha256) || sha256 == "0000000000000000000000000000000000000000000000000000000000000000";

        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> source) => source != null && source.Any();

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source is null || !source.Any();

        public static List<string> GetTextBetweenTwoCharacters(string value, char characterBeginning, char characterEnd, bool throwOnError = false)
        {
            var retVal = new List<string>();

            if (!string.IsNullOrWhiteSpace(value))
            {
                if (throwOnError)
                {
                    throw new ArgumentNullException("The string must be filled in!");
                }

                return retVal;
            }

            if (value.Contains(characterBeginning))
            {
                var leftSplit = value.Split(characterBeginning).ToList();

                if (leftSplit.IsNotNullOrEmpty())
                {
                    foreach (var firstSplit in leftSplit.Where(x => !string.IsNullOrWhiteSpace(x)))
                    {
                        if (firstSplit.Contains(characterEnd))
                        {
                            var rightSplit = firstSplit.Trim().Split(characterEnd).ToList();

                            if (rightSplit.IsNotNullOrEmpty())
                            {
                                retVal.AddRange(rightSplit.Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()));
                            }
                        }
                    }
                }
                else
                {
                    if (throwOnError)
                    {
                        throw new ArgumentOutOfRangeException("There are no text after the first character");
                    }
                }
            }
            else
            {
                if (throwOnError)
                {
                    throw new ArgumentOutOfRangeException("Could not locate the beginning character!");
                }
            }

            return retVal;
        }

        public static bool AllCharactersIsUpper(this string value) =>
            string.IsNullOrWhiteSpace(value) ? true : value.ToCharArray().Where(x => char.IsLetter(x)).All(x => char.IsUpper(x));
        
        public static bool AllCharactersIsLower(this string value) => 
            string.IsNullOrWhiteSpace(value) ? true : value.ToCharArray().Where(x => char.IsLetter(x)).All(x => char.IsLower(x));

        public static byte[] ConvertFileStreamToBytes(this Stream input)
        {
            if (input == null)
            {
                throw new ArgumentException("Input cannot be null");
            }

            byte[] retVal;

            using (var binaryReader = new BinaryReader(input))
            {
                retVal = binaryReader.ReadBytes((int)input.Length);
            }

            return retVal;
        }

        public static string GetBase64(this byte[] attachment) => attachment.IsNotNullOrEmpty() ? Convert.ToBase64String(attachment) : string.Empty;

        public static string ConvertToBase64(this Stream input) => GetBase64(ConvertFileStreamToBytes(input));

        public static bool IsNotNullOrEmptyAny<T>(this IEnumerable<T> source, Func<T, bool> predicate) => source != null && source.Any(predicate);

        private static DescriptionAttribute[] GetDescriptions(Enum value) => (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);

        public static string GetDescription(this Enum value)
        {
            var attributes = GetDescriptions(value);

            return attributes.IsNotNullOrEmpty() ? attributes.First().Description : value.ToString().SeperateCapitalLetters();
        }

        public static IDictionary<int, string> GetDictionaryOfEnumAndDescription(Type enumType, bool excludeZero = false)
        {
            var retVal = new Dictionary<int, string>();

            foreach (var name in Enum.GetNames(enumType))
            {
                var enumNumber = (int)Enum.Parse(enumType, name);

                if (enumNumber == 0 && excludeZero)
                {
                    continue;
                }

                var descriptionAttribute = (DescriptionAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), true);

                retVal.Add(enumNumber, descriptionAttribute.IsNotNullOrEmpty() ? descriptionAttribute.First().Description : name.SeperateCapitalLetters());
            }

            return retVal;
        }

        public static string SeperateCapitalLetters(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            var words = Regex.Split(value.Trim(), @"(?<!^)(?=[A-Z])");

            return words.IsNotNullOrEmpty() ? string.Join(" ", words).Trim() : value;
        }

        public static bool IsIn(this Guid g, params Guid[] args)
        {
            if (args == null)
            {
                return false;
            }

            return args.Any(x => x.Equals(g));
        }

        public static bool IsIn(this string s, params string[] args)
        {
            return s.IsIn(StringComparison.Ordinal, args);
        }

        public static bool IsIn(this string s, StringComparison comparisonType, params string[] args)
        {
            return args.Any<string>(arg => arg.Equals(s, comparisonType));
        }

        public static bool IsIn(this int i, params int[] args)
        {
            return args.Contains(i);
        }

        public static string ToSqlInStatement(this IEnumerable<string> collection)
        {
            throw new NotImplementedException();
        }

        public static Guid ToSafeGuid(this object value) => ToSafeNullableGuid(value).GetValueOrDefault();

        public static Guid? ToSafeNullableGuid(this object value)
        {
            try
            {
                Guid testVal = default(Guid);

                if (Guid.TryParse(value.ToSafeString(), out testVal))
                    return testVal;

                return default(Guid?);
            }
            catch (Exception)
            {
                return default(Guid?);
            }
        }

        public static DateTime ToSafeDateTime(this object value) => ToSafeNullableDateTime(value).GetValueOrDefault();

        public static DateTime? ToSafeNullableDateTime(this object value)
        {
            try
            {
                DateTime testVal = default(DateTime);

                if (DateTime.TryParse(value.ToSafeString(), out testVal))
                    return testVal;

                return default(DateTime?);
            }
            catch (Exception)
            {
                return default(DateTime?);
            }
        }

        public static int ToSafeInt(this object value) => ToSafeNullableInt(value).GetValueOrDefault();

        public static int? ToSafeNullableInt(this object value)
        {
            try
            {
                if (value is Enum)
                {
                    return Convert.ToInt32(value);
                }
                else
                {
                    int testVal = default(int);

                    if (int.TryParse(value.ToSafeString(), out testVal))
                        return testVal;
                }

                return default(int?);
            }
            catch (Exception)
            {
                return default(int?);
            }
        }

        public static bool ToSafeBool(this object value) => ToSafeNullableBool(value).GetValueOrDefault();

        public static bool? ToSafeNullableBool(this object value)
        {
            try
            {
                if(value == null)
                {
                    return default(bool?);
                }
                else if(value.GetType() == typeof(int))
                {
                    return Convert.ToBoolean(value);
                }
                else 
                {
                    if (int.TryParse(value.ToSafeString(), out int _))
                    {
                        return Convert.ToBoolean(value.ToSafeInt());
                    }
                    else
                    {
                        bool testVal = default(bool);

                        if (bool.TryParse(value.ToSafeString(), out testVal))
                        {
                            return testVal;
                        }
                    }
                }

                return default(bool?);
            }
            catch (Exception)
            {
                return default(bool?);
            }
        }

        public static void SafeAddWithValue(this SqlParameterCollection parameters, string parameterName, object value)
        {
            if (value == null)
            {
                parameters.AddWithValue(parameterName, DBNull.Value);
            }
            else if (value is string)
            {
                string val = Convert.ToString(value);

                if (string.IsNullOrWhiteSpace(val))
                {
                    parameters.AddWithValue(parameterName, DBNull.Value);
                }
                else
                {
                    parameters.AddWithValue(parameterName, value);
                }
            }
            else
            {
                parameters.AddWithValue(parameterName, value);
            }
        }

        public static double ToSafeDouble(this object value) => ToSafeNullableDouble(value).GetValueOrDefault();

        public static double? ToSafeNullableDouble(this object value)
        {
            try
            {
                double testVal = default(double);

                if (double.TryParse(value.ToSafeString(), out testVal))
                    return testVal;

                return default(double?);
            }
            catch (Exception)
            {
                return default(double?);
            }
        }

        public static decimal ToSafeDecimal(this object value) => ToSafeNullableDecimal(value).GetValueOrDefault();

        public static decimal? ToSafeNullableDecimal(this object value)
        {
            try
            {
                decimal testVal = default(decimal);

                if (decimal.TryParse(value.ToSafeString(), out testVal))
                    return testVal;

                return default(decimal?);
            }
            catch (Exception)
            {
                return default(decimal?);
            }
        }

        public static string ToSafeDateTimeString(this object value, string format)
        {
            try
            {
                DateTime testVal = default(DateTime);

                if (DateTime.TryParse(value.ToSafeString(), out testVal))
                    return testVal.ToString(format);

                return string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static string ToSafeString(this object value) => Convert.ToString(value) ?? String.Empty;

        public static Byte[] ToSafeByteArray(this object value)
        {
            try
            {
                if (value != null)
                    return (byte[])value;

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string ToSafeNullableString(this object value)
        {
            try
            {
                if(value != null)
                    return Convert.ToString(value);

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool IsGenericList(this object o)
        {
            var oType = o?.GetType();
            return oType != null && oType.IsGenericType && oType.GetGenericTypeDefinition() == typeof(List<>);
        }

        public static List<string> TryMapJsonToStringList(this object value)
        {
            List<string> retVal = new List<string>();

            try
            {
                retVal = JsonConvert.DeserializeObject<List<string>>(value.ToSafeString());
            }
            catch (Exception)
            {
            }

            return retVal;
        }

        public static bool ContainsKeyAndIsNotNullOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> keyValuePairs, TKey key)
        {
            try
            {
                if (keyValuePairs != null && keyValuePairs.ContainsKey(key))
                {
                    Type dataType = typeof(TValue);

                    if (dataType == typeof(string))
                    {
                        return !string.IsNullOrWhiteSpace(Convert.ToString(keyValuePairs[key]));
                    }

                    return Convert.ToString(keyValuePairs[key]) != Convert.ToString(default(TValue));
                }

                return default(bool);
            }
            catch
            {
                return default(bool);
            }
        }

        public static long ToSafeLong(this object value) => ToSafeNullableLong(value).GetValueOrDefault();

        public static long? ToSafeNullableLong(this object value)
        {
            try
            {
                long testVal = default(long);

                if (long.TryParse(value.ToSafeString(), out testVal))
                    return testVal;

                return default(long?);
            }
            catch (Exception)
            {
                return default(long?);
            }
        }

        public static string ToFormattedLapseString(this DateTime value, DateTime compareToDateTime)
        {
            TimeSpan ts = compareToDateTime - value;
            string spanText = string.Empty; ;
            var sb = new StringBuilder();

            if (ts.TotalMinutes < 1)
            {
                spanText = "less than a minute";
            }
            else
            {
                var totalMinutes = ts.Duration().Minutes;
                var totalHours = ts.Duration().Hours;
                var totalDays = ts.Duration().Days;

                if (totalDays > 0)
                {
                    spanText = $"{ts.Duration().Days} {(totalDays < 2 ? "day" : "days")}";
                    sb.Append($"{ts.Duration().Days} {(totalDays < 2 ? "day" : "days")}");
                }

                if (totalHours > 0)
                {
                    if (sb.ToString().Length > 0)
                        sb.Append(", ");

                    spanText += spanText.Length > 0 ? $", {ts.Duration().Hours} {(totalHours < 2 ? "hr" : "hrs")}" : $"{ts.Duration().Hours} {(totalHours < 2 ? "hr" : "hrs")}";
                    sb.Append($"{ts.Duration().Hours} {(totalHours < 2 ? "hr" : "hrs")}");
                }

                if (totalMinutes > 0)
                {
                    if (sb.ToString().Length > 0)
                        sb.Append(", ");

                    spanText += spanText.Length > 0 ? $", {ts.Duration().Minutes} {(totalMinutes < 2 ? "min" : "mins")}" : $"{ts.Duration().Minutes} {(totalMinutes < 2 ? "min" : "mins")}";
                    sb.Append($"{ts.Duration().Minutes} {(totalMinutes < 2 ? "min" : "mins")}");
                }
            }

            var test = sb.ToString();
            return spanText;
        }

        public static DataTable ToDataTable<T>(this List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            
            return dataTable;
        }

        public static string ToEscapeApostropheString(this string value)
        {
            try
            {
                return value.Replace(@"'", @"\'");
            }
            catch (Exception)
            {
                return value;
            }
        }

        public static string Truncate(this string str, int length)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Length must be >= 0");
            }

            if (str == null)
            {
                return null;
            }

            int maxLength = Math.Min(str.Length, length-1);
            return str.Substring(0, maxLength);
        }

        public static void GetAgentVersion(string version, out int versionMajor, out int versionMinor, int osType = 1)
        {
            versionMajor = 0;
            versionMinor = 0;
            string agentVersion = string.Empty;

            if (string.IsNullOrEmpty(version))
            {
                return;
            }

            switch (osType)
            {
                // Windows.
                case 1:
                    agentVersion = version.Contains("/") ? version.Substring(0, version.IndexOf("/")) : version;
                    break;
                // Mac.
                case 2:
                    //[MAC] 2.0.0.323
                    if (version.StartsWith("[MAC] "))
                    {
                        agentVersion = version.Substring(6);
                    }
                    break;
                default:
                    return;
            }

            if (agentVersion.Contains("."))
            {
                versionMajor = agentVersion.Split('.')[0].ToSafeInt();
                versionMinor = agentVersion.Split('.')[1].ToSafeInt();
            }
        }

        public static DataTable CreateTableUniqueIdentifierListType(IEnumerable<Guid> ids)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(Guid));

            foreach (Guid id in ids)
            {
                dt.Rows.Add(id);
            }

            return dt;
        }

        public static DataTable CreateTableStringListType(IList<string> values, int maxLength = int.MaxValue)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(string));

            foreach (string value in values)
            {
                if (value.Length > maxLength)
                {
                    throw new ArgumentException($"String {value} exceeds maximum length of {maxLength}");
                }

                dt.Rows.Add(value);
            }

            return dt;
        }

    }
}