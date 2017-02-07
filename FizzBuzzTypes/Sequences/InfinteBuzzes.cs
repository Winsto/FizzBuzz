namespace FizzBuzzTypes.Sequences
{
    using System.Collections.Generic;

    public class InfinteBuzzes
    {
        public IEnumerable<Buzz> Buzzes()
        {
            while (true)
            {
                yield return new Buzz(  new EmptyBuzz() );
                yield return new Buzz(  new EmptyBuzz() );
                yield return new Buzz(  new EmptyBuzz() );
                yield return new Buzz(  new EmptyBuzz() );
                yield return new Buzz(  new NonEmptyBuzz() );
                
            }
        }
    }
}