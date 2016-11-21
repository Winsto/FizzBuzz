namespace FizzBuzzTypes
{
    public class Number : FizzBuzzOrNumber
    {
        private int inputNumber;

        public Number(int inputNumber)
        {
            this.inputNumber = inputNumber;
        }

        public override string ToString()
        {
            return inputNumber.ToString();
        }
    }
}