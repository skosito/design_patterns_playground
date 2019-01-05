namespace Singleton
{
    // monostate pattern, private fields are static
    // but public properties are not 
    public class CEO
    {
        private static string _name;
        private static int _age;

        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }
    }
}