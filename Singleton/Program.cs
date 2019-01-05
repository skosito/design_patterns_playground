using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SingletonDatabase.Instance;

            System.Console.WriteLine(db.GetPopulation("Tokyo"));

            var ceo = new CEO();
            ceo.Name = "John Doe";
            ceo.Age = 55;

            var ceo2 = new CEO();
            System.Console.WriteLine(ceo2.Name + " " + ceo2.Age); // John Doe 55
        }
    }
}
