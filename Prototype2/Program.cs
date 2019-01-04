using System;

namespace Prototype2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragan = new Person(new []{"Dragan"}, new Address("Bla bla", 123));

            System.Console.WriteLine(dragan);

            var komsijaDragan = dragan.DeepCopy<Person>();
            komsijaDragan.Address.HouseNumber = 124;

            System.Console.WriteLine(komsijaDragan);
        }
    }
}
