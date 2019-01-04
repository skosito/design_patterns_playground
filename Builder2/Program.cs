using System;

namespace Builder2
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = Person.New.Called("Stefan").WorksAsA("Software Engineer").Build();

            System.Console.WriteLine(me);
        }
    }
}
