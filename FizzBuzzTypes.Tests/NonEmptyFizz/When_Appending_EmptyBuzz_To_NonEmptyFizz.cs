namespace FizzBuzzTypes.Tests.NonEmptyFizz
{
    using Machine.Specifications;
    using NonEmptyFizz = FizzBuzzTypes.NonEmptyFizz;

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

        It result_is_nonemptyfizz = () => Result.ShouldBeOfExactType<NonEmptyFizz>();


        static NonEmptyFizz Subject;
        static FizzBuzzOrNumber Result;
    }
}