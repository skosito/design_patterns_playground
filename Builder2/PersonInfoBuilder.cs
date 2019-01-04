namespace Builder2
{
    public class PersonInfoBuilder<SELF> : PersonBuilder where SELF: PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            _person.Name = name;
            return (SELF) this;
        }
    }
}