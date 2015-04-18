namespace FizzBuzzOneLiner
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n < 101; n++){ Console.WriteLine("{0} -> {1}", n, n % 15 == 0 ? "FizzBuzz" : n % 5 == 0 ? "Buzz" : n % 3 == 0 ? "Fizz" : n.ToString()); }
        }
    }
}
