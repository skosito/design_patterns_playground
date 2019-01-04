using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        // class should be open for extension, closed for modification
        // in this case, it should be possible to add new product filter
        // and not to go and edit code which is already there

        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Red, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            var products = new Product[] { apple, tree, house };

            var badProductFilter = new BadProductFilter();
            Console.WriteLine("Green products (old):");
            foreach(var product in badProductFilter.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {product.Name} is green.");
            }

            var betterProductFilter = new BetterProductFilter();
            Console.WriteLine("Green products (new):");
            foreach(var product in betterProductFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {product.Name} is green.");
            }

            Console.WriteLine("Large blue products (new):");
            foreach(var product in betterProductFilter.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {product.Name} is large and blue.");
            }
        }
    }
}
