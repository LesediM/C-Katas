using NUnit.Framework;

namespace RomanCalculator_2016_07_28
{
    [TestFixture]
    public class TestRomanCalculator
    {
        [Test]
        public void Add_GivenTwoSingleNumerals1Plus1_ShouldReturnNumeral2()
        {
            //---------------Set up test pack-------------------
            var expected = "II";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("I");
            calculator.Enter("I");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenTwoSingleNumerals1Plus2_ShouldReturnNumeral3()
        {
            //---------------Set up test pack-------------------
            var expected = "III";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("I");
            calculator.Enter("II");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenTwoSingleNumerals2Plus2_ShouldReturnNumeral4()
        {
            //---------------Set up test pack-------------------
            var expected = "IV";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("II");
            calculator.Enter("II");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenTwoSingleNumerals10Plus10_ShouldReturnNumeral20()
        {
            //---------------Set up test pack-------------------
            var expected = "XL";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("XX");
            calculator.Enter("XX");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenTwoSingleNumerals200Plus200_ShouldReturnNumeral400()
        {
            //---------------Set up test pack-------------------
            var expected = "CD";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("CC");
            calculator.Enter("CC");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenTwoSingleNumerals5Plus5_ShouldReturnNumeral10()
        {
            //---------------Set up test pack-------------------
            var expected = "X";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("V");
            calculator.Enter("V");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenTwoSingleNumerals50Plus50_ShouldReturnNumeral100()
        {
            //---------------Set up test pack-------------------
            var expected = "C";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("L");
            calculator.Enter("L");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenTwoSingleNumerals500Plus500_ShouldReturnNumeral1000()
        {
            //---------------Set up test pack-------------------
            var expected = "M";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("D");
            calculator.Enter("D");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [TestCase("I","V","VI")]
        [TestCase("I","X","XI")]
        [TestCase("X","L","LX")]
        [TestCase("X","L","LX")]
        [TestCase("X","C","CX")]
        [TestCase("C","D","DC")]
        [TestCase("C","M","MC")]
        public void Add_GivenSingleNumerals_ShouldReturnLargerNumeralBeforeLowerNumeral(string firstNumeral, string secondNumeral, string expected)
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter(firstNumeral);
            calculator.Enter(secondNumeral);
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [TestCase("II","V","VII")]
        [TestCase("II", "X", "XII")]
        [TestCase("XX", "L", "LXX")]
        [TestCase("XX", "L", "LXX")]
        [TestCase("XX", "C", "CXX")]
        [TestCase("CC", "D", "DCC")]
        [TestCase("CC", "M", "MCC")]
        public void Add_ShouldReturnLargerNumeralBeforeLowerNumeral(string firstNumeral, string secondNumeral, string expected)
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter(firstNumeral);
            calculator.Enter(secondNumeral);
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [TestCase("XX", "II", "XXII")]
        [TestCase("XIV", "LX", "LXXIV")]
        [TestCase("VIII", "VIII", "XVI")]
        public void Add_GivenTestData_ShouldReturnAccurateNumeralResults(string firstNumeral, string secondNumeral, string expected)
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter(firstNumeral);
            calculator.Enter(secondNumeral);
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }


        private static RomanCalculator CreateCalculator()
        {
            return new RomanCalculator();
        }
    }
}
