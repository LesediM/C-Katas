using System.Text;

namespace SouthAfricanIDNumberKata_2016_04_22
{
    public class SAIdNumberExtractor
    {
        public string ExtractDateOfBirth(string idNumber)
        {
            var yy = int.Parse(idNumber.Substring(0, 2));
            var yyyy = string.Concat(yy < 20 ? "20" : "19", yy);
            var mm = idNumber.Substring(2, 2);
            var dd = idNumber.Substring(4, 2);
            return $"{dd}-{mm}-{yyyy}";
        }

        public string ExtractGender(string idNumber)
        {
            var g = int.Parse(idNumber.Substring(6, 1));
            var gender = g < 5 ? "Female" : "Male";
            return gender;
        }

        public string ExtractCitizenshipStatus(string idNumber)
        {
            var c = int.Parse(idNumber.Substring(10, 1));
            var citizenship = c < 1 ? "SA" : "Other";
            return citizenship;
        }

        public string ExtractIDParts(string idNumber)
        {
            var idNumberParts = new StringBuilder();
            idNumberParts.AppendFormat("{0}, ", ExtractDateOfBirth(idNumber));
            idNumberParts.AppendFormat("{0} ", ExtractGender(idNumber));
            idNumberParts.AppendFormat(ExtractCitizenshipStatus(idNumber));
            return idNumberParts.ToString();
        }
    }
}