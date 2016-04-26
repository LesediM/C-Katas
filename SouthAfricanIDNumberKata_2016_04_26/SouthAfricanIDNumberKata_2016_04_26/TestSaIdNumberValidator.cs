using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_26
{
    [TestFixture]
    public class TestSaIdNumberValidator
    {
        const string idNumber = "8001015009087";

        [Test]
        public void AddOddPositionDigits_GivenIDNumber_ShouldSumOddPositionDigitsExceptLastDigit()
        {
            //---------------Set up test pack-------------------
            var expected = 13;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddOddPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ResolveEvenPositionDigits_GivenIDNumber_ShouldExtractEvenPositionDigitsThenDoubleConcatedResult()
        {
            //---------------Set up test pack-------------------
            var expected = 22196;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ResolveEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddEvenPositionDigits_GivenIDNumber_ShouldSumResolvedEvenPositions()
        {
            //---------------Set up test pack-------------------
            var expected = 20;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ResolveAllResults_GivenIDNumber_ShouldSumAddEvenPositionResultsAndAddOddPositionResults()
        {
            //---------------Set up test pack-------------------
            var expected = 33;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ResolveAllResults(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveTallyNumber_GivenIDNumber_ShouldSubtractAllResultsResolvedFromTen()
        {
            //---------------Set up test pack-------------------
            var expected = 7;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ResolveTallyNumber(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ValidateID_GivenIDNumber_ShouldReturnTrueIfIDNumberIsValid()
        {
            //---------------Set up test pack-------------------
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ValidateID(idNumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(results);
        }

        [Test]
        public void ValidateID_GivenIDNumber8013155009082_ShouldReturnTrueIfIDNumberIsValid()
        {
            //---------------Set up test pack-------------------
            var newIdNumber = "8013155009082";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ValidateID(newIdNumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(results);
        }

        private SaIdNumberValidator CreateSaIdNumberValidator()
        {
            return new SaIdNumberValidator();
        }
    }
}