namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;
    using EmptyFizz = FizzBuzzTypes.EmptyFizz;

    [Subject(typeof(EmptyFizz), "EmptyFizz")]
    public class When_Appending_Number_To_EmptyFizz
    {
        Establish context = () =>
        {
            Subject = new EmptyFizz();
        };

        Because of = () =>
        {
            Result =
                Subject
                    .Append(new Number(int.MaxValue));
        };

        It result_is_number = () => Result.ShouldBeOfExactType<Number>();


        static EmptyFizz Subject;
        static FizzBuzzOrNumber Result;
    }
}