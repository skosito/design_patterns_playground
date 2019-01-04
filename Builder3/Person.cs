namespace Builder3
{
    public class Person
    {
        // address
        public string StreetAddress, PostalCode, City;

        // employment
        public string CompanyName, Position;
        public int AnualIncome;

        public override string ToString()
        {
            return $"Address: {StreetAddress}, {PostalCode}, {City} and employment: {CompanyName}, {Position}, {AnualIncome}";
        }
    }
}