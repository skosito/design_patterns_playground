using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();
        
        private static int _count = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
            return _count; // memento patern
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }

        // adding methods for saving to file, load from file, load from uri would violate
        // single responsibility principle, it is better to create new class for it
    }
}