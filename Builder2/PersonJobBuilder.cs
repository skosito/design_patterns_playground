namespace Builder2
{
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>>
        where SELF: PersonJobBuilder<SELF>
    {
        public SELF WorksAsA(string position)
        {
            _person.Position = position;
            return (SELF) this;
        }
    }
}