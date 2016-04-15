using System;
using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_04_15
{
    public class ValidateID
    {
        public int AddOddPositionNumbers(string idnumber)
        {
            var oddpositionnumbers = GetNumbersByPosition(idnumber, 0);

            return oddpositionnumbers.Sum(Convert.ToInt32);
        }

        private List<string> GetNumbersByPosition(string idnumber, int startposition)
        {
            var oddpositionnumbers = new List<string>();
            for (int i = startposition; i < idnumber.Length - 1; i += 2)
                oddpositionnumbers.Add(idnumber[i].ToString());
            return oddpositionnumbers;
        }

        public int GetEvenPositionNumbersThenMultpilyBy2(string idnumber)
        {
            var evenpositionnumbers = string.Join("", GetNumbersByPosition(idnumber, 1).ToArray());
            return Convert.ToInt32(evenpositionnumbers) * 2;
        }

        public int AddEvenPositionNumbersThatAreMultipliedBy2(string idnumber)
        {
            var evenpositonnumbers = GetEvenPositionNumbersThenMultpilyBy2(idnumber);
            return evenpositonnumbers.ToString().Sum(x => Convert.ToInt32(x.ToString()));
        }

        public bool CheckControlDigit(string idnumber)
        {
            var oddpositionnumbersum = AddOddPositionNumbers(idnumber);
            var evenpositionnumbersum = AddEvenPositionNumbersThatAreMultipliedBy2(idnumber);
            var tally = 10 - Convert.ToInt32((oddpositionnumbersum + evenpositionnumbersum).ToString().Last().ToString());
            return Equals(tally.ToString(),idnumber.Last().ToString());
        }
    }
}