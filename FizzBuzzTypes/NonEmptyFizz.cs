namespace FizzBuzzTypes
{
    public class NonEmptyFizz : Fizz, FizzBuzzOrNumber
    {
        public override string ToString()
        {
            return "Fizz";
        }

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