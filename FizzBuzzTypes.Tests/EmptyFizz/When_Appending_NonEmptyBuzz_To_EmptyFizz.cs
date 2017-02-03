namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;

    [Subject(typeof(EmptyFizz), "EmptyFizz")]
    public class When_Appending_NonEmptyBuzz_To_EmptyFizz
    {
        Establish context = () =>
        {
            Subject = new EmptyFizz();
        };

        Because of = () =>
        {
            Result =
                Subject
                    .Append(new NonEmptyBuzz());
        };

        It result_is_nonemptybuzz = () => Result.ShouldBeOfExactType<NonEmptyBuzz>();

        It result_is_numberappender = () => Result.ShouldBeAssignableTo<NumberAppender>();


        static EmptyFizz Subject;
        static object Result;
    }
}
