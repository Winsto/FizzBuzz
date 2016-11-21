namespace FizzBuzzTypes
{
    public class NonEmptyFizz : Fizz, FizzBuzzOrNumber
    {
        public FizzBuzzOrNumber Append(NonEmptyBuzz buzz)
        {
            return new FizzBuzz();
        }

        public FizzBuzzOrNumber Append(Number number)
        {
            return this;
        }

        public FizzBuzzOrNumber Append(EmptyBuzz buzz)
        {
            return this;
        }
    }
}