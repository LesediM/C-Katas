using System;
using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_12
{
    [TestFixture]
    public class TestIDNumber
    {
        [Test]
        public void ExtractIDParts_GivenYY80_ShouldReturnDateOfBirthGenderAndCitizenship()
        {
            //---------------Set up test pack-------------------
            var idNumber = CreateIDNumber();
            var expected = "01-01-1980, Male SA";
            var idnumber = "8001015009087";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = idNumber.ExtractIDParts(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void ExtractIDParts_GivenYY01_ShouldReturnDateOfBirthGenderAndCitizenship()
        {
            var idNumber = CreateIDNumber();
            var expected = "01-01-2001, Male SA";
            var idnumber = "0101015009087";

            var results = idNumber.ExtractIDParts(idnumber);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddOddPositionNumbers_GivenIDNumber_ShouldReturnSum()
        {
            var idnumber = "8001015009087";
            var expected = 13;

            var results = CreateIDNumber().AddOddPositionNumbers(idnumber);

            Assert.AreEqual(expected, results);

        }

        [Test]
        public void GetEvenPositionNumbersThenMultiplyBy2_GivenIDNumber_ShouldReturnTotal()
        {
            var idnumber = "8001015009087";
            var expected = 22196;

            var results = CreateIDNumber().GetEvenPositionNumbersThenMultipyBy2(idnumber);

            Assert.AreEqual(expected, results);

        }

        [Test]
        public void AddEvenPositionNumbers_GivenIDNumber_ShouldReturnSum()
        {
            var idnumber = "8001015009087";
            var expected = 20;

            var results = CreateIDNumber().AddEvenPositionNumbers(idnumber);

            Assert.AreEqual(expected, results);

        }

        [Test]
        public void ValidateID_Given_ShouldReturnTrue()
        {
            var idnumber = "8001015009087";
            var results = CreateIDNumber().ValidateID(idnumber);

            Assert.IsTrue(results);
        }

        private IDNumber CreateIDNumber()
        {
            return new IDNumber();
        }
    }
}
