namespace Zip_a_Dee_Doo_Dah
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> sinkAction)
        {
            foreach (var item in source)
            {
                sinkAction(item);
            }
        }
    }
}