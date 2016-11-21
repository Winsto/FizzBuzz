namespace FizzBuzzTypes
{
    public class EmptyBuzz : Buzz
    {
        public FizzBuzzOrNumber Append(Number number)
        {
            return number;
        }
    }
}