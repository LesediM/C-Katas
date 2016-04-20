using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_20
{
    [TestFixture]
    public class TestSAIdNumberExtractor
    {
        [Test]
        public void ExtractDateOfBirth_GivenIDNumber_ShouldReturnDateOfBirthFormatted()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8013155009082";
            var expected = "15-13-1980";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberExtractor.ExtractDateOfBirth(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ExtractGender_GivenIDNumber_ShouldReturnGender()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8013155009082";
            var expected = "Male";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberExtractor.ExtractGender(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ExtractCitizenship_GivenIDNumber_ShouldReturnCitizenship()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8013155009082";
            var expected = "SA";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberExtractor.ExtractCitizenship(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ExtractIDParts_GivenIDNumber_ShouldReturnDateOfBirthGenderAndCitizenship()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8013155009082";
            var expected = "15-13-1980, Male SA";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = saIdNumberExtractor.ExtractIDParts(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        private SAIdNumberExtractor CreateSaIdNumberExtractor()
        {
            return new SAIdNumberExtractor();
        }
    }
}
