using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_19
{
    [TestFixture]
    public class TestSAIDNumberValidator
    {
        [Test]
        public void ValidateID_GivenIDNumber_ShouldReturnValidityOfIDNumber()
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

        [Test]
        public void AddDigitsInOddPositionsExceptLast_GivenIDNumber_ShouldReturnTheTotal()
        {
            //---------------Set up test pack-------------------
            var expected = 13;
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.AddDigitsInOddPositionsExceptLast(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MoveEvenPositionsIntoField_GivenIDNumber_ShouldReturnEvenPositionsAsString()
        {
            //---------------Set up test pack-------------------
            var expected = "011098";
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.MoveEvenPositionsIntoField(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MultiplyEvenPositionFieldByTwo_GivenIDNumber_ShouldReturnEvenPositionsMultipliedByTwo()
        {
            //---------------Set up test pack-------------------
            var expected = 22196;
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.MultiplyEvenPositionFieldByTwo(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AddDigitsOfMultipliedEvenPositionField_GivenIDNumber_ShouldReturnSumOfDigitsInMultippliedEvenPositions()
        {
            //---------------Set up test pack-------------------
            var expected = 20;
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.AddDigitsOfMultipliedEvenPositionField(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AddSumOfMultipliedEvenPositionDigitsAndSumOfOddPositionDigits_GivenIDNumber_ShouldReturnTheSum()
        {
            //---------------Set up test pack-------------------
            var expected = 33;
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.AddSumOfMultipliedEvenPositionDigitsAndSumOfOddPositionDigits(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TallyIDNumberControlDigit_GivenIDNumber_ShouldReturnValidity()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var saIdNumberValidator = CreateSaIdNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberValidator.TallyIDNumberControlDigit(idNumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(result);
        }

        private SAIDNumberValidator CreateSaIdNumberValidator()
        {
            return new SAIDNumberValidator();
        }
    }
}
