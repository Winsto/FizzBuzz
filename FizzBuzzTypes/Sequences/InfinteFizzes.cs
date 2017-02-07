namespace FizzBuzzTypes.Sequences
{
    using System.Collections.Generic;

    public class InfinteFizzes
    {
        public IEnumerable<BuzzAppender> Fizzes()
        {
            while (true)
            {
                yield return new EmptyFizz();
                yield return new EmptyFizz();
                yield return new NonEmptyFizz();
            }
        }
    }
}