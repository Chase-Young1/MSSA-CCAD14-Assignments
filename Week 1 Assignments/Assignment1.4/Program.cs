namespace Assignment1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            point1.x = 1.8;
            point2.x = 1.5;

            if (point1.x == point2.x)
            {
                Console.WriteLine("The two points are on the same axis.");
            }
            else
            {
                Console.WriteLine("The two points are not on the same axis.");
            }
        }
        public struct Point
        {
            public double x;
            public double y;
        }
    }
}