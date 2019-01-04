using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        // high level components should not directly access low level components
        // but through some way of abstraction

        static void Main(string[] args)
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Mary" };
            var child2 = new Person { Name = "Jane" };

            var relashionships = new Relationships();
            relashionships.AddParendAndChild(parent, child1);
            relashionships.AddParendAndChild(parent, child2);

            new Research(relashionships);

            new BetterResearch(relashionships);
        }
    }
}
