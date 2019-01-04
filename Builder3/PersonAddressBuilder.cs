namespace Builder3
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            _person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            _person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressBuilder WithPostalCode(string postalCode)
        {
            _person.PostalCode = postalCode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            _person.City = city;
            return this;
        }
    }
}