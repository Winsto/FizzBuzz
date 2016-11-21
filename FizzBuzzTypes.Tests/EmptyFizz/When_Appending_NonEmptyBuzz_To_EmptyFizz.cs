namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;
    using EmptyFizz = FizzBuzzTypes.EmptyFizz;

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


        static EmptyFizz Subject;
        static FizzBuzzOrNumber Result;
    }
}
