namespace FizzBuzzTypes.Tests.NonEmptyFizz
{
    using Machine.Specifications;
    using NonEmptyFizz = FizzBuzzTypes.NonEmptyFizz;

    [Subject(typeof(NonEmptyFizz), "NonEmptyFizz")]
    public class When_Appending_NonEmptyBuzz_To_NonEmptyFizz
    {
        Establish context = () =>
        {
            Subject = new NonEmptyFizz();
        };

        Because of = () =>
        {
            Result =
                Subject
                    .Append(new NonEmptyBuzz());
        };

        It result_is_fizzbuzz = () => Result.ShouldBeOfExactType<FizzBuzz>();


        static NonEmptyFizz Subject;
        static FizzBuzzOrNumber Result;
    }
}