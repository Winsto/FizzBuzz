namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;
    using NonEmptyFizz = FizzBuzzTypes.NonEmptyFizz;

    [Subject(typeof(NonEmptyFizz), "NonEmptyFizz")]
    public class When_Appending_Number_To_NonEmptyFizz
    {
        Establish context = () =>
        {
            Subject = new NonEmptyFizz();
        };

        Because of = () =>
        {
            Result =
                Subject
                    .Append(new Number(int.MinValue));
        };

        It result_is_nonemptyfizz = () => Result.ShouldBeOfExactType<NonEmptyFizz>();


        static NonEmptyFizz Subject;
        static FizzBuzzOrNumber Result;
    }
}