using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello").AddChild("li", "blorb");
            Console.WriteLine(builder);
        }
    }
}
