using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_21
{
    [TestFixture]
    public class TestSAIdNumberValidator
    {
        [Test]
        public void SumOddPositionDigits_GivenIDNumber_ShouldReturnSumOfOddPositionIDNumberDigits()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 13;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.SumOddPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void DoubleConcatedEvenPositionDigits_GivenIDNumber_ShouldReturnDoubledEvenPositionIDNumberDigitsConcated()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 22196;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.DoubleConcatedEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void SumEvenPositionDigits_GivenIDNumber_ShouldReturnSumOfDoubledEvenPositionIDNumberDigitsConcated()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 20;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.SumEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void SumOddAndEvenPositionDigits_GivenIDNumber_ShouldReturnSumOfDoubledEvenPositionIDNumberDigitsConcatedAndOddPosition()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 33;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.SumOddAndEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetTallyToken_GivenIDNumber_ShouldReturnSubtractionOfLastDigitOfOddAndEvenPositionSumFromTen()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 7;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.GetTallyToken(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ValidateID_GivenIDNumber_ShouldReturnTrueIfIDNumberIsValid()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ValidateId(idNumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(results);
        }
        [Test]
        public void ValidateID_GivenIDNumber8013155009082_ShouldReturnTrueIfIDNumberIsValid()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8013155009082";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ValidateId(idNumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(results);
        }

        private SAIdNumberValidator CreateSaIdNumberValidator()
        {
            return new SAIdNumberValidator();
        }
    }
}