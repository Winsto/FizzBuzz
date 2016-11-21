namespace FizzBuzzTypes.Tests
{
    using System;
    using Machine.Specifications;
    using Machine.Specifications.Model;

    [Subject(typeof(NonEmptyFizz), "NonEmptyFizz")]
    public class When_Calling_ToString_On_NonEmptyFizz
    {
        private Establish context = () =>
        {
            Subject = new NonEmptyFizz();
        };

        private Because of = () =>
        {
            Result =
                Subject
                    .ToString();
        };

        private It result_is_fizz = () => 
            Result
                .Equals("Fizz", StringComparison.OrdinalIgnoreCase)
                .ShouldBeTrue();

        private static NonEmptyFizz Subject;
        private static string Result;
    }
}