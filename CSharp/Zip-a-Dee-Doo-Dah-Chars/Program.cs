namespace Zip_a_Dee_Doo_Dah_Chars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            fizzes()
                .Zip(
                buzzes(),
                (f, b) =>
                f
                .ToCharArray()
                .Zip(
                    b
                    .ToCharArray()
                    , (fc, bc)
                    => (char)Math.Max(fc, bc)))
                .Zip(
                                    Enumerable.Range(1, 100)
                        .Select(n => n.ToString("D8"))
                        ,
                (fb,ns)    
                =>
                fb
                .Zip(
                    ns.ToCharArray(),
                    (fbc, nsc)
                    =>
                    (char)Math.Max(fbc, nsc)))
                    .Select(
                carr 
                => 
                carr
                .Aggregate(
                    new StringBuilder()
                    , 
                    (builder, ch)
                    =>
                    builder.Append(ch)))
                    .ForEach(item => Console.WriteLine(item));
        }

        public static IEnumerable<String> fizzes()
        {
            while (true)
            {
                yield return "        ";
                yield return "        ";
                yield return "    FIZZ";
            }
        }

        public static IEnumerable<String> buzzes()
        {
            while (true)
            {
                yield return "        ";
                yield return "        ";
                yield return "        ";
                yield return "        ";
                yield return "    BUZZ";
            }
        }
    }
}
