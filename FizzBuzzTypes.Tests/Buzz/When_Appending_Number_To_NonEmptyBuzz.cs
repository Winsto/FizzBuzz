namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;

    [Subject(typeof(NonEmptyBuzz),"NonEmptyBuzz")]
    public class When_Appending_Number_To_NonEmptyBuzz
    {
        private Establish context = () =>
        {
            Subject = new NonEmptyBuzz();
        };

        private Because of = () =>
        {
            Result =
                Subject
                    .Append(new Number());
        };

        private It result_is_nonemptyBuzz = () => Result.ShouldBeOfExactType<NonEmptyBuzz>();



        private static NonEmptyBuzz Subject;
        private static FizzBuzzOrNumber Result;
    }
}