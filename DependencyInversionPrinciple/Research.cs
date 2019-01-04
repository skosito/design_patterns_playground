using System;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public class Research
    {
        public Research(Relationships relationships) // access to low level directly
        {
            var relations = relationships.Relations;

            foreach(var r in relations.Where(x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent))
            {
                Console.WriteLine($"John has a child called: {r.Item3.Name}");
            }
        }
    }
}