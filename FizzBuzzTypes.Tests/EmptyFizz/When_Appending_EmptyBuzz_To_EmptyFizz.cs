namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;

    [Subject(typeof(EmptyFizz), "EmptyFizz")]
    public class When_Appending_EmptyBuzz_To_EmptyFizz
    {
        Establish context = () =>
        {
            Subject = new EmptyFizz();
        };

        Because of = () =>
        {
            Result =
                Subject
                    .Append(new EmptyBuzz());
        };

        It result_is_nonemptybuzz = () => Result.ShouldBeOfExactType<EmptyBuzz>();


        static EmptyFizz Subject;
        static object Result;
    }
}