using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_05_06
{
    [TestFixture]
    public class TestSaIdNumberValidator
    {
        [Test]
        public void AddOddPositionIdNumberDigits_GivenIdNumber_ShouldReturnSumExcludingLastDigit()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 13;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddOddPositionIdNumberDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetEvenPositionIdNumberDigits_GivenIdNumber_ShouldReturnEvenPositionDigitsConcatThenDouble()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 22196;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.GetEvenPositionIdNumberDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void AddEvenPositionIdNumberDigits_GivenIdNumber_ShouldReturnSumEvenPositionDigitsThatWereDoubled()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 20;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddEvenPositionIdNumberDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void AddAllResultsOfPositionDigits_GivenIdNumber_ShouldReturnSumOfOddAndEvenPositionDigitsResults()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 33;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddAllResultsOfPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetTallyNumber_GivenIdNumber_ShouldReturnSubtractTotalFromAddAndOddPositionsFromTen()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 7;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.GetTallyNumber(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ValidateID_GivenIdNumber_ShouldReturnTrueIfIdNumberIsValid()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ValidateID(idNumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(results);
        }

        private SaIdNumberValidator CreateSaIdNumberValidator()
        {
            return new SaIdNumberValidator();
        }
    }
}