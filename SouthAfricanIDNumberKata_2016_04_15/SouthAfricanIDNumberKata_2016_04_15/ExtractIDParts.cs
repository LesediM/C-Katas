using System;

namespace SouthAfricanIDNumberKata_2016_04_15
{
    public class ExtractIDParts
    {
        public string GetDateOfBirth(string idnumber)
        {
            var yy = idnumber.Substring(0, 2);
            var yyyy = Convert.ToInt32(yy) < 20 ? "20" + yy : "19" + yy;
            var mm = idnumber.Substring(2, 2);
            var dd = idnumber.Substring(4, 2);
            return $"{dd}-{mm}-{yyyy}";
        }

        public string GetGender(string idnumber)
        {
            var genderpart = idnumber.Substring(6, 1);
            return Convert.ToInt32(genderpart) < 5 ? "Female" : "Male";
        }

        public string GetCitizenship(string idnumber)
        {
            var citizenshippart = idnumber.Substring(10, 1);
            return Convert.ToInt32(citizenshippart) < 1 ? "SA" : "Other";
        }
    }
}