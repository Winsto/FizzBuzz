namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;
    using FizzBuzzTypes;

    [Subject(typeof(NonEmptyBuzz),"NonEmptyBuzz")]
    public class When_Appending_Number_To_NonEmptyBuzz
    {
        Establish context = () =>
        {
            Subject = new NonEmptyBuzz();
        };

        Because of = () =>
        {
            Result =
                Subject
                    .Append(new Number(int.MinValue));
        };

        It result_is_nonemptyBuzz = () => Result.ShouldBeOfExactType<NonEmptyBuzz>();



        static NonEmptyBuzz Subject;
        static object Result;
    }
}