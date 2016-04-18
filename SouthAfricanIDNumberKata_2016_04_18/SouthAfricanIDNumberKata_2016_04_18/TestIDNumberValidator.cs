using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_18
{
    [TestFixture]
    public class TestIDNumberValidator
    {
        [Test]
        public void ExtractIDParts_GivenIDNumber_ShouldReturnIDParts()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = "01-01-1980, Male SA";
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.ExtractIDParts(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ExtractDateOfBirth_GivenIDNumber_ShouldReturnDateOfBirth()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = "01-01-1980";
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.ExtractDateOfBirth(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ExtractGender_GivenIDNumber_ShouldReturnGender()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = "Male";
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.ExtractGender(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ExtractCitizenship_GivenIDNumber_ShouldReturnCitizenship()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = "SA";
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.ExtractCitizenship(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void SumOddPositionNumbers_GivenIDNumber_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = 13;
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.SumOddPositionNumbers(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetEvenPositionNumbers_GivenIDNumber_ShouldReturnSumX2()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = 22196;
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.GetEvenPositionNumbersSumX2(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void SumEvenPositionResults_GivenIDNumber_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = 20;
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.SumEvenPositionResults(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ValidateIDNumber_GivenIDNumber_ShouldReturnTrue()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.ValidateID(idnumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(results);
        }

        [Test]
        public void ValidateIDNumber_Given8013155009082_ShouldReturnTrue()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8013155009082";
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.ValidateID(idnumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(results);
        }
    }
}
