using System;
using System.Collections.Generic;

namespace Factories
{
    // abstract factory
    public interface IColdDrink
    {
        void Consume();
    }

    internal class Beer : IColdDrink
    {
        public void Consume()
        {
            System.Console.WriteLine("Mmmm... beer");
        }
    }

    internal class Whiskey : IColdDrink
    {
        public void Consume()
        {
            System.Console.WriteLine("Mmmm... whiskey");
        }
    }

    public interface IColdDrinkFactory
    {
        IColdDrink Prepare(int amount);
    }

    internal class BeerFactory : IColdDrinkFactory
    {
        public IColdDrink Prepare(int amount)
        {
            System.Console.WriteLine($"Get {amount} beers from freezer.");
            return new Beer();
        }
    }

    internal class WhiskeyFactory : IColdDrinkFactory
    {
        public IColdDrink Prepare(int amount)
        {
            System.Console.WriteLine($"Get {amount} whiskeys from radiator (prohibition era).");
            return new Whiskey();
        }
    }

    public class ColdDrinkMachine
    {
        public enum AvailableDrink { Beer, Whiskey }; // violates open-closed principle

        private Dictionary<AvailableDrink, IColdDrinkFactory> _factories = new Dictionary<AvailableDrink, IColdDrinkFactory>(); 

        public ColdDrinkMachine()
        {
            foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                var factory = (IColdDrinkFactory) Activator.CreateInstance(
                    Type.GetType("Factories." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory"));
                
                _factories.Add(drink, factory);
            }
        }

        public IColdDrink MakeDrink(AvailableDrink drink, int amount)
        {
            return _factories[drink].Prepare(amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var machine = new ColdDrinkMachine();
            var drink = machine.MakeDrink(ColdDrinkMachine.AvailableDrink.Beer, 2);
            drink.Consume();
        }
    }
}
