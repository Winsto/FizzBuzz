namespace FizzBuzzTypes
{
    public class NonEmptyFizz : BuzzAppender, NumberAppender
    {
        public override string ToString()
        {
            return "Fizz";
        }

        public NumberAppender Append(NonEmptyBuzz buzz)
        {
            return new FizzBuzz();
        }

        public object Append(Number number)
        {
            return this;
        }

        public NumberAppender Append(EmptyBuzz buzz)
        {
            return this;
        }
    }
}