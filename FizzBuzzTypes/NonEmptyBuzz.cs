namespace FizzBuzzTypes
{
    public class NonEmptyBuzz : Buzz, FizzBuzzOrNumber
    {
        public override string ToString()
        {
            return "Buzz";
        }

        public FizzBuzzOrNumber Append(Number number)
        {
            return this;
        }
    }
}