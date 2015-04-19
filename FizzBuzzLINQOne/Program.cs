namespace FizzBuzzLINQOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Enumerable.Range(1, 100);

            var outputCollection =
                inputNumbers.Select(inputNumber =>
                    {
                        var candidateString =
                            DivisorStringMaps().First(mapEntry => inputNumber % mapEntry.Item1 == 0).Item2;

                        return String.Format(@"{0} -> {1}",
                                             inputNumber,
                                             candidateString.Length == 0 ? inputNumber.ToString() : candidateString);
                    });

            foreach (var output in outputCollection) { Console.WriteLine(output); }
        }

        static IEnumerable<Tuple<int, string>> DivisorStringMaps()
        {
            yield return Tuple.Create(15, "FizzBuzz");
            yield return Tuple.Create(5, "Buzz");
            yield return Tuple.Create(3, "Fizz");
            yield return Tuple.Create(1, "");
        }
    }
}
