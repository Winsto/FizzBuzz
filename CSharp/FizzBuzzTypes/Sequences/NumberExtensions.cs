namespace FizzBuzzTypes.Sequences
{
    public static class NumberExtensions
    {
        public static Number ToNumber(this int input)
        {
            return new Number(input);
        }
    }
}