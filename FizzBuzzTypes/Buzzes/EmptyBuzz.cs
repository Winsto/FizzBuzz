namespace FizzBuzzTypes
{
    public class EmptyBuzz : NumberAppender
    {
        public object Append(Number number)
        {
            return number;
        }
    }
}