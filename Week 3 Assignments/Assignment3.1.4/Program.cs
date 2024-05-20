namespace Assignment3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the X coordinate.");
            int xCoordinate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Y coordinate.");
            int yCoordinate = Convert.ToInt32(Console.ReadLine());

            string quadrant = QuadrantIdentifier(xCoordinate, yCoordinate);

            Console.WriteLine($"The coordinate point {xCoordinate},{yCoordinate} is in the {quadrant}");
        }
        static string QuadrantIdentifier(int x, int y)
        {

            switch(x, y)
            {
                case (> 0, > 0):
                    return "First Quadrant.";
                case (< 0, > 0):
                    return "Second Quadrant.";
                case (< 0, < 0):
                    return "Third Quadrant.";
                case (> 0, < 0):
                    return "Fourth Quadrant.";
                default:
                    return "Origin";

            }
        }
    }
}