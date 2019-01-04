using System;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public class BetterResearch
    {
        public BetterResearch(IRelationshipBrowser browser) // access to low level through abstraction
        {
            foreach(var r in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called: {r.Name}");
            }
        }
    }
}