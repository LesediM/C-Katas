using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_19
{
    [TestFixture]
    public class TestSAIDNumberExtractor
    {
        [Test]
        public void ExtractIDPartds_GivenIDNumber_ShouldReturnDateOfBirthGenderCitizenship()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8013155009082";
            var expected = "15-13-1980, Male SA";
            var saIdNumberValidator = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ExtractIDParts(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ExtractDateOfBirth_GivenIDNumber_ShouldReturnDateOfBirth()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8013155009082";
            var expected = "15-13-1980";
            var saIdNumberValidator = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ExtractDateOfBirth(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ExtractGender_GivenIDNumber_ShouldReturnGender()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8013155009082";
            var expected = "Male";
            var saIdNumberValidator = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ExtractGender(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ExtractCitizenship_GivenIDNumber_ShouldReturnCitizenship()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8013155009082";
            var expected = "SA";
            var saIdNumberValidator = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberValidator.ExtractCitizenship(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private SAIDNumberExtractor CreateSaIdNumberExtractor()
        {
            return new SAIDNumberExtractor();
        }
        }
}
