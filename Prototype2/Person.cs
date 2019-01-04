using System;

namespace Prototype2
{
    // serialization solution
    [Serializable]
    public class Person
    {
        public readonly string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"Names: {string.Join(' ', Names)}, Address: {Address}";
        }
    }
}