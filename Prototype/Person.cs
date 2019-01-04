namespace Prototype
{
    // using ICloneable is not good idea because it is not clear whether is it deep or shallow copy
    // also it returns object

    // using copy constructors down the hierarchy is better solution but still not that great
    // similar situation if we use our own interface for deep copying
    // both approaches makes us implement copying logic in all types
    
    public interface IPrototype<T>
    {
        T DeepCopy();
    }

    public class Person : IPrototype<Person>
    {
        public readonly string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public Person DeepCopy()
        {
            return new Person(Names, Address.DeepCopy());
        }

        public override string ToString()
        {
            return $"Names: {string.Join(' ', Names)}, Address: {Address}";
        }
    }
}