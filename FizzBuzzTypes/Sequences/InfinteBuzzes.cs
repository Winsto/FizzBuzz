namespace FizzBuzzTypes.Sequences
{
    using System.Collections.Generic;

    public class InfinteBuzzes
    {
        public IEnumerable<NumberAppender> Buzzes()
        {
            yield return new EmptyBuzz();
            yield return new EmptyBuzz();
            yield return new EmptyBuzz();
            yield return new EmptyBuzz();
            yield return new NonEmptyBuzz();
        }
    }
}