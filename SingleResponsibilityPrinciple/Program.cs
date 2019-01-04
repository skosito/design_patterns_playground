using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        // every class should be responsible for one thing and should have one reason to change
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I drank beer.");
            journal.AddEntry("I drank vinjak.");
            journal.AddEntry("It was a good day.");

            Console.WriteLine(journal);
        }
    }
}
