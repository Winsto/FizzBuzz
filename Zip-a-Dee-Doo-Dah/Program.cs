namespace Zip_a_Dee_Doo_Dah
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            fizzes()
                .Zip(
                    buzzes()
                    ,
                    (f, b)
                        =>
                        String.Concat(f, b))
                .Zip
                (
                    Enumerable.Range(1, 100)
                        .Select(n => n.ToString())
                    ,
                    (fb, ns)
                        =>
                        String.IsNullOrWhiteSpace(fb) ? ns : fb)
                        .ForEach(
                            item
                            =>
                            Console.WriteLine(item));
        }
        public static IEnumerable<String> fizzes()
        {
            while (true)
            {
                yield return "";
                yield return "";
                yield return "FIZZ";
            }
        }

        public static IEnumerable<String> buzzes()
        {
            while (true)
            {
                yield return "";
                yield return "";
                yield return "";
                yield return "";
                yield return "BUZZ";
            }
        }
    }
}
