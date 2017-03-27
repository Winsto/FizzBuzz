namespace RxConsole
{
    using FizzBuzzTypes;
    public class FizzOrEmptyFizz : Either<NonEmptyFizz, EmptyFizz>
    {
        public FizzOrEmptyFizz(NonEmptyFizz item) : base(item)
        {
        }

        public FizzOrEmptyFizz(EmptyFizz item) : base(item)
        {
        }
    }
}