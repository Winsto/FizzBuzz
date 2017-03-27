namespace RxConsole
{
    using FizzBuzzTypes;
    public class BuzzOrEmptyBuzz : Either<NonEmptyBuzz, EmptyBuzz>
    {
        public BuzzOrEmptyBuzz(NonEmptyBuzz item) : base(item)
        {
        }

        public BuzzOrEmptyBuzz(EmptyBuzz item) : base(item)
        {
        }
    }
}