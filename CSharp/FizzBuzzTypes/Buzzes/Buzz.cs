namespace FizzBuzzTypes
{
    public sealed class Buzz : Either<EmptyBuzz, NonEmptyBuzz>
    {
        public Buzz(EmptyBuzz item) : base(item)
        {
        }

        public Buzz(NonEmptyBuzz item) : base(item)
        {
        }
    }
}
