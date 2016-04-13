using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_12
{
    public class IDNumber : IIDNumber
    {
        public string ExtractIDParts(string IDNumber)
        {
            string dateofbirth = $"{IDNumber.Substring(4, 2)}-{IDNumber.Substring(2, 2)}-{GetYear(IDNumber)}";
            string gender = Convert.ToInt32(IDNumber.Substring(6, 1)) < 5 ? "Female" : "Male";
            string citizenship = Convert.ToInt32(IDNumber.Substring(10, 1)) < 1 ? "SA" : "Other";
            return $"{dateofbirth}, {gender} {citizenship}";
        }

        private string GetYear(string IDNumber)
        {
            return string.Concat(Convert.ToInt32(IDNumber.Substring(0, 2)) < 20 ? 20 : 19, IDNumber.Substring(0, 2));
        }

        public bool ValidateID(string idnumber)
        {
            var oddpositionnumbertotal = AddOddPositionNumbers(idnumber);
            var evenpositionnumberx2total = GetEvenPositionNumbersThenMultipyBy2(idnumber);
            var evenpositionnumbertotal = AddEvenPositionNumbers(idnumber);
            var sumofoddandeven = evenpositionnumbertotal + oddpositionnumbertotal;
            var subtractednumber = 10 - GetLastDigitOfNumber(sumofoddandeven);

            var lastidnumberdigit = idnumber.ToCharArray().Last().ToString();
            return lastidnumberdigit == subtractednumber.ToString();
        }

        private int GetLastDigitOfNumber(int number)
        {
            var numberLength = number.ToString().Length;
            var lastdigit = number.ToString().Substring(numberLength - 1, 1);
            return Convert.ToInt32(lastdigit);
        }

        public int AddOddPositionNumbers(string idnumber)
        {
            var oddpositionnumbers = new List<string>();
            for (int i = 0; i < 12; i += 2)
            {
                oddpositionnumbers.Add(idnumber[i].ToString());
            }
            return oddpositionnumbers.Sum(x => Convert.ToInt32(x.ToString()));
        }

        public int GetEvenPositionNumbersThenMultipyBy2(string idnumber)
        {
            var evenpositionnumbers = GetEvenPositionNumbers(idnumber);
            return Convert.ToInt32(string.Concat(evenpositionnumbers)) * 2;
        }

        private List<string> GetEvenPositionNumbers(string idnumber)
        {
            var evenpositionnumbers = new List<string>();
            for (int i = 1; i < 12; i += 2)
            {
                evenpositionnumbers.Add(idnumber[i].ToString());
            }
            return evenpositionnumbers;
        }

        public int AddEvenPositionNumbers(string idnumber)
        {
            var evenpositionnumbers = GetEvenPositionNumbersThenMultipyBy2(idnumber).ToString().ToCharArray().Select(x => x.ToString());
            return evenpositionnumbers.Sum(x => Convert.ToInt32(x));
        }
    }
}