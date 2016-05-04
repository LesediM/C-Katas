using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_05_03
{
    [TestFixture]
    public class TestSaIdNumberValidator
    {
        [Test]
        public void AddOddPositionDigits_GivenIdNumber_ShouldSumOddPositionDigitsExceptLastPosition()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 13;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddOddPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetEvenPositionDigits_GivenIdNumber_ShouldGetEvenPositionDigitsConcatThenDoubleResults()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 22196;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.GetEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void AddEvenPositionDigits_GivenIdNumber_ShouldSumEvenPositionDigitsResolved()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 20;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void AddResolvedPositionDigits_GivenIdNumber_ShouldSumOddAndEvenPositionDigitsResolved()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 33;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddResolvedPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveTallyToken_GivenIdNumber_ShouldReturnAddResolvedPositionDigitsResultsSubtractedFromTen()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = 7;
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ResolveTallyToken(idNumber);
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