using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_15
{
    [TestFixture]
    public class TestExtractIdParts
    {
        [Test]
        public void GetDateOfBirth_GivenIDNumber_ShouldReturnDateOfBirthString()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = "01-01-1980";
            var idextractor = new ExtractIDParts();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idextractor.GetDateOfBirth(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetGender_GivenIDNumber_ShouldReturnGender()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = "Male";
            var idextractor = new ExtractIDParts();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idextractor.GetGender(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetCitizenship_GivenIDNumber_ShouldReturnCitizenship()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = "SA";
            var idextractor = new ExtractIDParts();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idextractor.GetCitizenship(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ExtractIDParts_GivenIDNumber_ShouldReturnExtractIDParts()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = "SA";
            var idextractor = new ExtractIDParts();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idextractor.GetCitizenship(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
    }
}
