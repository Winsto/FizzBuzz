namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;

    [Subject(typeof(NonEmptyFizz), "NonEmptyFizz")]
    public class When_Appending_EmptyBuzz_To_NonEmptyFizz
    {
        Establish context = () =>
        {
            Subject = new NonEmptyFizz();
        };

        Because of = () =>
        {
            Result =
                Subject
                    .Append(new EmptyBuzz());
        };

        It result_is_fizzbuzz = () => Result.ShouldBeOfExactType<NonEmptyFizz>();

        It result_is_numberappender = () => Result.ShouldBeAssignableTo<NumberAppender>();


        static NonEmptyFizz Subject;
        static object Result;
    }
}