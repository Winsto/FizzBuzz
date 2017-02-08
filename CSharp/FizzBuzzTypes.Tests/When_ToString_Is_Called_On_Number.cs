namespace FizzBuzzTypes.Tests
{
    using Machine.Specifications;

    [Subject(typeof(Number),"Number")]
    public class When_ToString_Is_Called_On_Number
    {
        Establish context = () =>
        {
            Subject = new Number(inputNumber);
        };

        private Because of = () =>
        {
            Result =
                Subject
                    .ToString();
        };

        private It result_is_same_as_inputnumber_tostring = () =>
        {
            Result
                .Equals(
                    inputNumber
                        .ToString())
                .ShouldBeTrue();
        };

        private static Number Subject;
        private static int inputNumber = 25;
        private static string Result;
    }
}