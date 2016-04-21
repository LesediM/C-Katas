using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_21
{
    [TestFixture]
    public class TestSAIdNumberExtractor
    {
        [Test]
        public void ExractDateOfBirth_GivenIDNumber_ShouldReturnDateOfBirthInDDMMYYYY()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = "01-01-1980";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberExtractor.ExtractDateOfBirth(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ExractGender_GivenIDNumber_ShouldReturnGender()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = "Male";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberExtractor.ExtractGender(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExractCitizenship_GivenIDNumber_ShouldReturnCitizenship()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = "SA";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberExtractor.ExtractCitizenship(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExractIDParts_GivenIDNumber_ShouldReturnDateOfBirthGenderCitizenship()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = "01-01-1980, Male SA";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberExtractor.ExtractIDParts(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private SAIdNumberExtractor CreateSaIdNumberExtractor()
        {
            return new SAIdNumberExtractor();
        }
    }
}
