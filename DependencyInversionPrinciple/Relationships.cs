using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public enum Relationship
    {
        Parent,
        Child
    }

    // low-level (storage)
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();

        public void AddParendAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Parent, child));
            _relations.Add((child, Relationship.Child, parent));
        }

        // bad way: expose relations
        public List<(Person, Relationship, Person)> Relations => _relations;

        // this way we can change the way we store data etc
        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return _relations
                .Where(r => r.Item1.Name == name && r.Item2 == Relationship.Parent)
                .Select(r => r.Item3);
        }
    }
}