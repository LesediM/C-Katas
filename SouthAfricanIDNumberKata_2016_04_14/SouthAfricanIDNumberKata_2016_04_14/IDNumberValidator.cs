using System;
using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_04_14
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
            var datepart = idnumber.Substring(0, 6);
            var yy = datepart.Substring(0, 2);
            var yyyy = Convert.ToInt32(yy) < 20 ? "20" + yy : "19" + yy;
            var mm = datepart.Substring(2, 2);
            var dd = datepart.Substring(4, 2);
            return $"{dd}-{mm}-{yyyy}";
        }

        public string ExtractGender(string idnumber)
        {
            var genderpart = idnumber.Substring(6, 1);
            var gender = Convert.ToInt32(genderpart) < 5 ? "Female" : "Male";
            return gender;
        }

        public string ExtractCitizenship(string idnumber)
        {
            var citizenpart = idnumber.Substring(10, 1);
            var citizenship = Convert.ToInt32(citizenpart) < 1 ? "SA" : "Other";
            return citizenship;
        }

        public bool ValidateID(string idnumber)
        {
            var oddpositionnumbertotal = AddOddPostionNumbers(idnumber);
            var evenpositionnumbertotal = AddEvenPostionNumbersX2(idnumber);
            var total = (oddpositionnumbertotal + evenpositionnumbertotal).ToString();
            var tallynumber = 10 - Convert.ToInt32(total.Substring(total.Length - 1, 1));
            var idnumberlastchar = idnumber.Substring(idnumber.Length - 1, 1);
            return Equals(tallynumber.ToString(), idnumberlastchar);
        }

        public int AddOddPostionNumbers(string idnumber)
        {
            var numberlist = GetNumberlist(idnumber, 0);
            return numberlist.Sum();
        }

        private List<int> GetNumberlist(string idnumber, int startindex)
        {
            var numberlist = new List<int>();
            for (var i = startindex; i < idnumber.Length - 1; i += 2)
            {
                numberlist.Add(Convert.ToInt32(idnumber[i].ToString()));
            }
            return numberlist;
        }

        public int GetEvenPostionNumbersX2(string idnumber)
        {
            return Convert.ToInt32(string.Concat(GetNumberlist(idnumber, 1))) * 2;
        }

        public int AddEvenPostionNumbersX2(string idnumber)
        {
            var evennumberlist = GetEvenPostionNumbersX2(idnumber).ToString();
            return evennumberlist.Select(x => Convert.ToInt32(x.ToString())).Sum();
        }
    }
}