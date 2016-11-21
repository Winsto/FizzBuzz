namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;
    using Machine.Specifications.Model;

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

        private It has_nonemptybuzz_result = () => Result.ShouldBeOfExactType<NonEmptyBuzz>();


        static EmptyFizz Subject;
        static FizzBuzzOrNumber Result;
    }
}
