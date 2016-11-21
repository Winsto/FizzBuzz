namespace FizzBuzzTypes
{
    public class EmptyFizz : Fizz
    {
        public FizzBuzzOrNumber Append(NonEmptyBuzz buzz)
        {
            return buzz;
        }
    }
}