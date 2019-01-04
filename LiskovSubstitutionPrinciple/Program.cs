using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        // you should be able to substitute base type for a subtype

        static public int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(2, 3);
            Console.WriteLine($"{rectangle} and area: {Area(rectangle)}"); // 6

            BadSquare badSquare = new BadSquare();
            badSquare.Width = 4;
            Console.WriteLine($"{badSquare} and area: {Area(badSquare)}"); // 16

            Rectangle badSquare2 = new BadSquare();
            badSquare2.Width = 4;
            Console.WriteLine($"{badSquare2} and area: {Area(badSquare2)}"); // 0

            Rectangle betterSquare = new BetterSquare();
            betterSquare.Width = 4;
            Console.WriteLine($"{betterSquare} and area: {Area(betterSquare)}"); // 16
        }
    }
}
