using System;

namespace Factories
{
    public class Point
    {
        private double _x, _y;

        private Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public static Point Origin = new Point(0, 0);

        public override string ToString()
        {
            return $"x: {_x}, y: {_y}";
        }

        // inner class so we can keep constructor of Point private
        public static class Factory
        {
            // factory method (moved from Point class here)
            // advantages over contructor: overload with same argument types,
            // descriptive names not tied to class name
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }
    }
}