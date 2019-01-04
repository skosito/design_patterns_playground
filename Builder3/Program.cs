using System;

namespace Builder3
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb.Works.At("Zuhlke").AsA("Software Engineer").Earning(10000)
            .Lives.At("Petra Kocica").WithPostalCode("17000").In("Vranje");

            Console.WriteLine(person);
        }
    }
}
