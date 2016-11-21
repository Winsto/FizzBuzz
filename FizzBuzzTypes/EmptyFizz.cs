namespace FizzBuzzTypes
{
    public class EmptyFizz : Fizz
    {
        public FizzBuzzOrNumber Append(NonEmptyBuzz buzz)
        {
            return buzz;
        }

        public FizzBuzzOrNumber Append(Number number)
        {
            return number;
        }
    }
}