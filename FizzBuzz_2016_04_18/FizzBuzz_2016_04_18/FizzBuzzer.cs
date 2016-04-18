using System.Text;

namespace FizzBuzz_2016_04_18
{
    public class FizzBuzzer
    {
        public string FizzBuzzMe(int number)
        {
            StringBuilder sb = new StringBuilder();
            if (number % 3 == 0)
                sb.Append("Fizz");
            if (number % 5 == 0)
                sb.Append("Buzz");
            return sb.Length == 0 ? number.ToString() : sb.ToString();
        }
    }
}