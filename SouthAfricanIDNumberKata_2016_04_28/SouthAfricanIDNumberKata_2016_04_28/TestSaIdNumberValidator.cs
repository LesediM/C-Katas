using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_28
{
    [TestFixture]
    public class TestSaIdNumberValidator
    {
        [Test]
        public void AddOddPositionDigits_GivenIDNumber_ShouldSumOddPositionDigitsExceptLast()
        {
            //---------------Set up test pack-------------------
            var expected = 13;
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.AddOddPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetEvenPositionDigits_GivenIDNumber_ShouldReturnConcatedEvenPositionDigitsThenDoubledResult()
        {
            //---------------Set up test pack-------------------
            var expected = 22196;
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.GetEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void AddEvenPositionDigits_GivenIDNumber_ShouldSumEvenPositionDigits()
        {
            //---------------Set up test pack-------------------
            var expected = 20;
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            var results = saIdNumberValidator.AddEvenPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolvePositionDigits_GivenIDNumber_ShouldSumOddAndEvenPositionDigitsResults()
        {
            //---------------Set up test pack-------------------
            var expected = 33;
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            var results = saIdNumberValidator.ResolvePositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveTallyNumber_GivenIDNumber_ShouldSubtract2ndDigitOfResolvePositionDigitsFromTenAndReturnSecondDigitOfResults()
        {
            //---------------Set up test pack-------------------
            var expected = 7;
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            var results = saIdNumberValidator.ResolveTallyNumber(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ValidateID_GivenIDNumber_ShouldReturnTrueIfIdNumberIsValid()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

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