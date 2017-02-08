namespace Zip_a_Dee_Types
{
    using System;
    using System.Linq;
    using FizzBuzzTypes.Sequences;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzes
                =
                new InfinteFizzes()
                    .Fizzes();

            var buzzes
                =
                new InfinteBuzzes()
                    .Buzzes();

            var numbers
                =
                Enumerable.Range(1, 100)
                    .Select(i => i.ToNumber());

            var numberAppenders
                =
                fizzes
                    .Zip(
                        buzzes,
                        (f, b)
                            =>
                                b.Match(
                                    emptyBuzz => f.Append(emptyBuzz)
                                    , nonEmptyBuzz => f.Append(nonEmptyBuzz))
                    );

            var fizzbuzznumbers =
                fizzes
                    .Zip(
                        buzzes,
                        (f, b)
                            =>
                                b.Match(
                                    emptyBuzz => f.Append(emptyBuzz)
                                    , nonEmptyBuzz => f.Append(nonEmptyBuzz))
                    )
                    .Zip(
                        numbers,
                        (fb, n)
                            =>
                                fb.Append(n));

            foreach (var fizzbuzznumber in fizzbuzznumbers)
                Console.WriteLine(fizzbuzznumber);
        }
    }
}
