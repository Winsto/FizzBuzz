namespace FizzBuzzTypes.Tests
{
    using System;
    using Machine.Specifications;

    [Subject(typeof (NonEmptyBuzz), "NonEmptyBuzz")]
    public class When_ToSTring_Is_Called_On_NonEmptyBuzz
    {
        private Establish context = () =>
        {
            Subject = new NonEmptyBuzz();
        };

        Because of = () =>
        {
            Result =
                Subject
                    .ToString();
        };

        private It result_is_buzz = () => 
            Result
                .Equals("Buzz", StringComparison.OrdinalIgnoreCase)
                .ShouldBeTrue();

        private static NonEmptyBuzz Subject;
        private static string Result;
    }
}