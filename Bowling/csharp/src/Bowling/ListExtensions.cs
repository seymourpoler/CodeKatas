using System.Collections.Generic;

namespace Bowling
{
    public static class ListExtensions
    {
        public static bool IsEmpty<T>(this IList<T> list) where T : class
        {
            return list.Count == 0;
        }
    }
}