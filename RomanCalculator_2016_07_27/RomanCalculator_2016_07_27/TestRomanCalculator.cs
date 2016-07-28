using NUnit.Framework;

namespace RomanCalculator_2016_07_27
{
    [TestFixture]
    public class TestRomanCalculator
    {
        [Test]
        public void Add_GivenTwoSingleNumeralsAreEntered_ShouldReturnNumeralConcated()
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
        public void Add_GivenTwoNumeralsAreEntered_ShouldReturnLargerNumeral()
        {
            //---------------Set up test pack-------------------
            var expected = "XXII";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("XX");
            calculator.Enter("II");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [TestCase("II","II","IV")]
        [TestCase("XX","XX","XL")]
        [TestCase("CC","CC","CD")]
        [TestCase("V","V","X")]
        [TestCase("L","L","C")]
        [TestCase("D","D","M")]
        public void Add_ShouldNotReturnLargerNumeralWithRepeationViolation(string firstNumeral, string secondNumeral, string expected)
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
