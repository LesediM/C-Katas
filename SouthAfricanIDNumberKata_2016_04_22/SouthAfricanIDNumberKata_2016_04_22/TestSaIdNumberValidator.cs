using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_22
{
    [TestFixture]
    public class TestSaIdNumberValidator
    {
        [Test]
        public void AddOddPositionDigits_GivenIDnumber_ShouldReturnSumExceptLastDigit()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 13;
            var saIdNumberValidator = new SaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddOddPostionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void DoubleTheConcatedEvenPositionDigits_GivenIDnumber_ShouldReturnDoubledConcatedEvenPositionDigits()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 22196;
            var saIdNumberValidator = new SaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.DoubleTheConcatedEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void AddEvenPositionDigits_GivenIDnumber_ShouldReturnSumOfDoubledConcatedEvenPositionDigits()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 20;
            var saIdNumberValidator = new SaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void AddOddAndEvenPositionTotals_GivenIDnumber_ShouldReturnSumOfOddAndEvenPositionDigits()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 33;
            var saIdNumberValidator = new SaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddOddAndEvenPositionTotals(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetTallyNumber_GivenIDnumber_ShouldReturnSubtractionOfLastDigitOfOddAndEvenTotalFromTen()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 7;
            var saIdNumberValidator = new SaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.GetTallyNumber(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ValidateID_GivenIDnumber_ShouldReturnTrueIfIDNumberIsValid()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var saIdNumberValidator = new SaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ValidateID(idNumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(results);
        }
    }
}