namespace Builder2
{
    public abstract class PersonBuilder
    {
        protected Person _person = new Person();

        public Person Build()
        {
            return _person;
        }
    }
}