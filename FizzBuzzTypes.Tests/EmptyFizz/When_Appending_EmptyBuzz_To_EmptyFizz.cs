namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;
    using EmptyFizz = FizzBuzzTypes.EmptyFizz;

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

        It result_is_emptyfizz = () => Result.ShouldBeOfExactType<EmptyFizz>();


        static EmptyFizz Subject;
        static FizzBuzzOrNumber Result;
    }
}