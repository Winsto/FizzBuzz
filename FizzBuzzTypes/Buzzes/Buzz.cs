namespace FizzBuzzTypes
{
    public sealed class Buzz : UnionOfTwo<EmptyBuzz, NonEmptyBuzz>
    {
        public Buzz(EmptyBuzz item) : base(item)
        {
        }

        public Buzz(NonEmptyBuzz item) : base(item)
        {
        }
    }
}
