using System;
using System.Collections.Generic;

namespace Utility
{
    public static class IListExtensions
    {
        public static IEnumerable<T> GetEvenPositions<T>(this IList<T> source)
        {
            for (int i = 0; i < source.Count; i++)
            {
                if (i % 2 != 0)
                    yield return source[i];
            }
        }

        public static IEnumerable<T> GetOddPositions<T>(this IList<T> source)
        {
            for (int i = 0; i < source.Count; i++)
            {
                if (i % 2 == 0)
                    yield return source[i];
            }
        }
    }
}
