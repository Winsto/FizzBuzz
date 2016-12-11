namespace FizzBuzzTypes
{
    public class NonEmptyBuzz : NumberAppender
    {
        public override string ToString()
        {
            return "Buzz";
        }

        public object Append(Number number)
        {
            return this;
        }
    }
}