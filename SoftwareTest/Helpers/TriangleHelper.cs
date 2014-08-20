using System.Linq;

namespace SoftwareTest.Helpers
{
    public static class TriangleHelper
    {
        public static TriangleType GetTriangleType(int a, int b, int c)
        {
            if(!IsValidTriangle(a,b,c))
                return TriangleType.Invalid;

            //Convert Sides to Array
            var sides = new[] { a, b, c };

            switch (sides.Distinct().Count())
            {
                case 1:
                    return TriangleType.Equilateral;
                case 2:
                    return TriangleType.Isosceles;
                case 3:
                    return TriangleType.Scalene;
                default:
                    return TriangleType.Invalid;
            }
        }

        private static bool IsValidTriangle(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

    }

    public enum TriangleType
    {
        Invalid,
        Scalene,
        Isosceles,
        Equilateral
    }
}