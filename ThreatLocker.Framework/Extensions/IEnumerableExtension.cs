using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace ThreatLocker.Framework.Extensions
{
    public static class IEnumerableExtension
    {
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> source) => source != null && source.Any();

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source is null || !source.Any();

        public static bool IsNotNullOrEmptyAny<T>(this IEnumerable<T> source, Func<T, bool> predicate) => source != null && source.Any(predicate);

        public static IEnumerable<T> SplitBy<T>(this IEnumerable<T> values, out IEnumerable<T> notMatched, Predicate<T> predicate)
        {
            IEnumerable<T> matched = values.Where(w => predicate(w));
            notMatched = values.Except(matched);

            return matched;
        }

        public static List<T> SplitBy<T>(this List<T> values, out List<T> notMatched, Predicate<T> predicate)
        {
            IEnumerable<T> valuesEnumerable = values.AsEnumerable().SplitBy(out IEnumerable<T> notMatchedEnumerable, predicate);
            notMatched = notMatchedEnumerable.ToList();

            return valuesEnumerable.ToList();
        }

        public static bool ContainsAll<T>(this IEnumerable<T> a, IEnumerable<T> b) => !b.Except(a).Any();
    }
}