using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_15
{
    [TestFixture]
    public class TestValidateID
    {
        [Test]
        public void AddOddPositionNumbers_GivenIDNumber_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = 13;
            var validateid = new ValidateID();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = validateid.AddOddPositionNumbers(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetEvenPositionNumbersThenMultpilyBy2_GivenIDNumber_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = 22196;
            var validateid = new ValidateID();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = validateid.GetEvenPositionNumbersThenMultpilyBy2(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddEvenPositionNumbersThatAreMultipliedBy2_GivenIDNumber_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var expected = 20;
            var validateid = new ValidateID();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = validateid.AddEvenPositionNumbersThatAreMultipliedBy2(idnumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void CheckControlDigit_GivenIDNumber_ShouldReturnTrue()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8001015009087";
            var validateid = new ValidateID();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = validateid.CheckControlDigit(idnumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(results);
        }

        [Test]
        public void CheckControlDigit_GivenIDNumber8013155009082_ShouldReturnValidity()
        {
            //---------------Set up test pack-------------------
            var idnumber = "8013155009082";
            var validateid = new ValidateID();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = validateid.CheckControlDigit(idnumber);
            //---------------Test Result -----------------------
            Assert.IsTrue(results);
        }
    }
}