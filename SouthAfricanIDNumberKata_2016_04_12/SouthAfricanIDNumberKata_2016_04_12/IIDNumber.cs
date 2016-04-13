namespace SouthAfricanIDNumberKata_2016_04_12
{
    public interface IIDNumber
    {
        string ExtractIDParts(string IDNumber);
        bool ValidateID(string IDNumber);
    }
}