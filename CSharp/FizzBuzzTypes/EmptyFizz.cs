namespace FizzBuzzTypes
{
    public class EmptyFizz : BuzzAppender
    {
        public NumberAppender Append(NonEmptyBuzz buzz)
        {
            return buzz;
        }

        public NumberAppender Append(EmptyBuzz buzz)
        {
            return buzz;
        }
    }
}