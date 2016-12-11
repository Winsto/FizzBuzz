namespace FizzBuzzTypes.Tests
{
    using FizzBuzzTypes;
    using Machine.Specifications;
    using Machine.Specifications.Model;

    [Subject(typeof(FizzBuzz), "FizzBuzz")]
    public class When_Appending_Number_To_FizzBuzz
    {
        Establish context = () =>
        {
            Subject = new FizzBuzz();
        };

        private Because of = () =>
        {
            Result
                =
                Subject
                    .Append(new Number(int.MinValue));
        };

        private It result_is_fizzbuzz = () =>
        {
            Result.ShouldBeOfExactType<FizzBuzz>();
        };

        private static FizzBuzz Subject;
        private static object Result;
    }
}