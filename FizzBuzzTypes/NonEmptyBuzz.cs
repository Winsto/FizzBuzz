namespace FizzBuzzTypes
{
    public class NonEmptyBuzz : Buzz, FizzBuzzOrNumber
    {
        public FizzBuzzOrNumber Append(Number number)
        {
            return this;
        }
    }
}