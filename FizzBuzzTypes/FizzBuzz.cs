namespace FizzBuzzTypes
{
    public class FizzBuzz : NumberAppender
    {
        public override string ToString()
        {
            return "FizzBuzz";
        }

        public object Append(Number number)
        {
            return this;
        }
    }
}