namespace FizzBuzz_2016_04_20
{
    public class FizzBuzzFactory
    {
        public string GetFizzBuzz(int inputNumber)
        {
            var fizzBuzzString = GetFizzBuzzString(inputNumber);
            return fizzBuzzString.Length == 0 ? inputNumber.ToString() : fizzBuzzString;
        }

        private string GetFizzBuzzString(int inputNumber)
        {
            var fizzBuzzString = "";
            if (CheckIfInputIsDivisible(inputNumber, 3))
                fizzBuzzString += "Fizz";
            if (CheckIfInputIsDivisible(inputNumber, 5))
                fizzBuzzString += "Buzz";
            return fizzBuzzString;
        }

        private bool CheckIfInputIsDivisible(int inputNumber, int divideByNumber)
        {
            return inputNumber % divideByNumber == 0;
        }
    }
}