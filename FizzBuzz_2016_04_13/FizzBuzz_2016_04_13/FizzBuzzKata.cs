namespace FizzBuzz_2016_04_13
{
    public class FizzBuzzKata
    {
        public string GetFizzBuzz(int number)
        {
            var fizzbuzzreturnstring = (number % 3 == 0) ? "Fizz" : "";
            fizzbuzzreturnstring += (number % 5 == 0) ? "Buzz" : "";
            return fizzbuzzreturnstring.Length > 0 ? fizzbuzzreturnstring : number.ToString();
        }
    }
}
