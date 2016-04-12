using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKata_2016_04_12
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            return GetNumberListSum(numbers);
        }

        private int GetNumberListSum(string numbers)
        {
            var delimiList = GetDelimitersFromNumberString(ref numbers);

            int[] numberlist = GetIntegerNumberList(numbers, delimiList).Where(x => x <= 1000).ToArray();
            NegativeNumberCheck(numberlist);

            return numberlist.Sum();
        }

        private IEnumerable<int> GetIntegerNumberList(string numbers, List<char> delimiList)
        {
            return numbers.Split(delimiList.ToArray()).Select(ConvertStringToNumber);
        }

        private void NegativeNumberCheck(int[] numberlist)
        {
            int[] negativelist = numberlist.Where(x => x < 0).ToArray();
            if (negativelist.Any())
            {
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativelist.ToArray()));
            }
        }

        private List<char> GetDelimitersFromNumberString(ref string numbers)
        {
            List<char> delimiList = new List<char>() { ',', '\n' };

            if (numbers.Contains("//"))
            {
                delimiList.AddRange(GetMultipleDeilimtersFromString(numbers));
            }
            return delimiList;
        }

        private char[] GetMultipleDeilimtersFromString(string numbers)
        {
            return numbers.Substring(2).ToArray().TakeWhile((x, y) => !ConvertableToInteger(x.ToString(), out y)).Select(x => Convert.ToChar(x)).ToArray();
        }

        private int ConvertStringToNumber(string x)
        {
            int y;
            return ConvertableToInteger(x, out y) ? y : 0;
        }

        private bool ConvertableToInteger(string x, out int y)
        {
            return int.TryParse(x, out y);
        }
    }
}
