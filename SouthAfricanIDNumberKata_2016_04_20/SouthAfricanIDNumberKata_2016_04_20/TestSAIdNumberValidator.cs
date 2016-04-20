using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_20
{
    [TestFixture]
    public class TestSAIdNumberValidator
    {
        [Test]
        public void AddOddPositionIDNumberDigits_GivenIDNumber_ShouldReturnSumExcludingLastDigit()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 13;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.AddOddPositionIDNumberDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetEvenPositionIDNumberDigits_GivenIDNumber_ShouldReturnDigitsMultipliedBy2()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 22196;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.GetEvenPositionIDNumberDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddEvenPositionIDNumberDigits_GivenIDNumber_ShouldReturnSumOfDigits()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 20;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.AddEvenPositionIDNumberDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SumDigitTotals_GivenIDNumber_ShouldReturnSumOfOddPositionAndMultipliedEvenPostion()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 33;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.SumDigitTotals(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetTallyToken_GivenIDNumber_ShouldReturnLastDigitOfSumDigitsMethodSubstractedFromTen()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 7;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.GetTallyToken(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidateID_GivenIDNumber_ShouldReturnIDNumberValidity()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.ValidateID(idNumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(result);
        }

        private SAIdNumberValidator CreateSaIdNumberValidator()
        {
            return new SAIdNumberValidator();
        }
    }
}