using NUnit.Framework;

namespace StringKata
{
    [TestFixture]
    public class TestCalculator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var input = "";
            var expected = 0;
            var calculator = new Calculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var actual = calculator.Add(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_GivenSingleNumber_ShouldReturnSingleNumber()
        {
            //---------------Set up test pack-------------------
            var input = "2";
            var expected = 2;
            var calculator = new Calculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var actual = calculator.Add(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Add_GivenLargeSingleNumber_ShouldReturnLargeSingleNumber()
        {
            //---------------Set up test pack-------------------
            var input = "120";
            var expected = 120;
            var calculator = new Calculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var actual = calculator.Add(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_GivenTwoNumbers_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var input = "1,2";
            var expected = 3;
            var calculator = new Calculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var actual = calculator.Add(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, actual);
        }
    }

    public class Calculator 
    {
        public int Add(string input)
        {
            if(string.IsNullOrEmpty(input))
                return 0;

            if (input.Contains(","))
            {
                var numbers = input.Split(',');
                return int.Parse(numbers[0]) + int.Parse(numbers[1]);
            }
            return int.Parse(input);
        }
    }
}