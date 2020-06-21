using System;
using System.Collections.Generic;
using System.Text;

namespace VueForm.Core.Extentions
{
    public static class IEnumerableExtensions
    {
        public static bool IsSingle<T>(this IEnumerable<T> enumerable)
        {
            using var enumerator = enumerable.GetEnumerator();
            if (!enumerator.MoveNext())
            {
                return false;
            }
            return !enumerator.MoveNext();
        }
    }
}
