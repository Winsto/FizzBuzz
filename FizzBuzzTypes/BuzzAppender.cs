namespace FizzBuzzTypes
{
    public interface BuzzAppender
    {
        NumberAppender Append(NonEmptyBuzz buzz);
    }
}