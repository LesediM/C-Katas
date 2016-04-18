using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_18
{
    public class IDNumberValidator
    {
        public string ExtractIDParts(string idnumber)
        {
            var dateofbirth = ExtractDateOfBirth(idnumber);
            var gender = ExtractGender(idnumber);
            var citizenship = ExtractCitizenship(idnumber);
            return $"{dateofbirth}, {gender} {citizenship}";
        }

        public string ExtractDateOfBirth(string idnumber)
        {
            var yy = idnumber.Substring(0, 2);
            var yyyy = Convert.ToInt32(yy) < 20 ? "20" + yy : "19" + yy;
            var mm = idnumber.Substring(2, 2);
            var dd = idnumber.Substring(4, 2);

            return $"{dd}-{mm}-{yyyy}";
        }

        public string ExtractGender(string idnumber)
        {
            var g = Convert.ToInt32(idnumber.Substring(6, 1));
            var gender = g < 5 ? "Female" : "Male";
            return gender;
        }

        public string ExtractCitizenship(string idnumber)
        {
            var c = Convert.ToInt32(idnumber.Substring(10, 1));
            var citizenship = c < 1 ? "SA" : "Other";
            return citizenship;
        }

        public int SumOddPositionNumbers(string idnumber)
        {
            var oddpositionnumbers = GetNumbersFromIDNumber(idnumber, 0);

            return oddpositionnumbers.Sum(x => Convert.ToInt32(x.ToString()));
        }

        private List<char> GetNumbersFromIDNumber(string idnumber, int startindex)
        {
            var numbers = new List<char>();
            for (int i = startindex; i < idnumber.Length - 1; i += 2)
                numbers.Add(idnumber[i]);
            return numbers;
        }

        public int GetEvenPositionNumbersSumX2(string idnumber)
        {
            var evenpositionnumbers = GetNumbersFromIDNumber(idnumber, 1);
            return Convert.ToInt32(string.Join("", evenpositionnumbers.Select(x => x.ToString()))) * 2;
        }

        public int SumEvenPositionResults(string idnumber)
        {
            return GetEvenPositionNumbersSumX2(idnumber).ToString().Sum(x => Convert.ToInt32(x.ToString()));
        }

        public bool ValidateID(string idnumber)
        {
            var sumoddpositionnumbers = SumOddPositionNumbers(idnumber);
            var sumevenpositionnumbers = SumEvenPositionResults(idnumber);
            var sumnumbers = sumoddpositionnumbers + sumevenpositionnumbers;
            var tally = (10 - (Convert.ToInt32(sumnumbers.ToString().Last().ToString()))).ToString();
            var controlnumber = idnumber.Last().ToString();

            return Equals(tally, controlnumber);
        }
    }
}