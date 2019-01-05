using System;
using System.Collections.Generic;
using System.IO;
using MoreLinq;

namespace Singleton
{
    public interface IDatabase
    {
        int GetPopulation(string name);
    }

    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();

        private SingletonDatabase()
        {
            System.Console.WriteLine("Initializing db...");

            // probably better way to do this, but i'm tired and don't care that much
            var text = File.ReadAllLines("capitals.txt");

            foreach(var line in text)
            {
                var s = line.Split(" ");
                _capitals.Add(s[0], int.Parse(s[1]));
            }
        }

        private static Lazy<SingletonDatabase> instance => new Lazy<SingletonDatabase>(() => new SingletonDatabase());

        public static SingletonDatabase Instance => instance.Value;

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }
}