namespace Builder3
{
    // facade for other builders
    public class PersonBuilder
    {
        // reference to object thats being built up
        // same single reference is passed to all subbuilders
        protected Person _person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(_person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(_person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb._person;
        }
    }
}