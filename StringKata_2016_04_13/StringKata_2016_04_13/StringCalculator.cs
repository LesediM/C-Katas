using System;
using System.Collections.Generic;
using System.Linq;

namespace StringKata_2016_04_13
{
    public class StringCalculator
    {
        public int AddNumbers(string numberstring)
        {
            if (string.IsNullOrEmpty(numberstring))
                return 0;

            var numberlist = GetNumbersFromString(numberstring);
            GetNegativeException(numberlist);
            return numberlist.Sum(x => Convert.ToInt32(x) <= 1000 ? Convert.ToInt32(x) : 0);
        }

        private void GetNegativeException(string[] numberlist)
        {
            var negativenumberlist = numberlist.Where(x => Convert.ToInt32(x) < 0);
            if (negativenumberlist.Any())
                throw new ArgumentException("negatives not allowed: " + String.Join(",", negativenumberlist.ToArray()));
        }

        private string[] GetNumbersFromString(string numberstring)
        {
            var delimiterlist = new List<char>() { ',', '\n' };
            if (!numberstring.Contains("//"))
                return numberstring.Split(delimiterlist.ToArray()).Where(x => !string.IsNullOrEmpty(x)).ToArray();

            delimiterlist.AddRange(numberstring.Substring(2)
                .ToCharArray()
                .Select(x => Convert.ToString(x))
                .Where((x, y) => !int.TryParse(x, out y))
                .Select(Convert.ToChar));
            numberstring = numberstring.Substring(2);
            return numberstring.Split(delimiterlist.ToArray()).Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }
    }
}