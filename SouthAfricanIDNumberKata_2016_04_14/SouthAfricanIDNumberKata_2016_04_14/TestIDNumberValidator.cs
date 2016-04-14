using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_14
{
    [TestFixture]
    public class TestIDNumberValidator
    {
        [Test]
        public void ExtractIDParts_GivenIDNumber_ShouldReturnParts()
        {
            //---------------Set up test pack-------------------
            var expected = "01-01-1980, Male SA";
            var idnumber = "8001015009087";
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
            var expected = "01-01-1980";
            var idnumber = "8001015009087";
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
            var expected = "Male";
            var idnumber = "8001015009087";
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
            var expected = "SA";
            var idnumber = "8001015009087";
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.ExtractCitizenship(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ValidateID_GivenIDNumber_ShouldPass()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------

            //---------------Test Result -----------------------
            Assert.IsTrue(idnumbervalidator.ValidateID(idnumber));
        }

        [Test]
        public void AddOddPostionNumbers_GivenIDNumber_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = 13;
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.AddOddPostionNumbers(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        

        [Test]
        public void GetEvenPostionNumbersX2_GivenIDNumber_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = 22196;
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.GetEvenPostionNumbersX2(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddEvenPostionNumbersX2_GivenIDNumber_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = 20;
            var idnumbervalidator = new IDNumberValidator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idnumbervalidator.AddEvenPostionNumbersX2(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
    }
}
