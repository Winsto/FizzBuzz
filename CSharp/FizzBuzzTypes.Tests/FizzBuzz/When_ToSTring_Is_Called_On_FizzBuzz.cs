namespace FizzBuzzTypes.Tests
{
    using System;
    using Machine.Specifications;
    using FizzBuzz = FizzBuzzTypes.FizzBuzz;

    [Subject(typeof (FizzBuzz), "NonEmptyBuzz")]
    public class When_ToSTring_Is_Called_On_FizzBuzz
    {
        private Establish context = () =>
        {
            Subject = new FizzBuzz();
        };

        Because of = () =>
        {
            Result =
                Subject
                    .ToString();
        };

        private It result_is_fizzbuzz = () => 
            Result
                .Equals("FizzBuzz", StringComparison.OrdinalIgnoreCase)
                .ShouldBeTrue();

        private static FizzBuzz Subject;
        private static string Result;
    }
}