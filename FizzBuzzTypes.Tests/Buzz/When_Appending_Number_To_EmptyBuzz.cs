namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;
    using FizzBuzzTypes;

    [Subject(typeof(EmptyBuzz),"EmptyBuzz")]
    public class When_Appending_Number_To_EmptyBuzz
    {
        private Establish context = () =>
        {
            Subject = new EmptyBuzz();
        };

        private Because of = () =>
        {
            Result =
                Subject
                    .Append(new Number(int.MaxValue));
        };

        private It result_is_number = () => Result.ShouldBeOfExactType<Number>();



        private static EmptyBuzz Subject;
        private static object Result;
    }
}