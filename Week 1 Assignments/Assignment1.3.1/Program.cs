namespace Assignment1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string readResult;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Please type in your choice from the menu.");
                Console.WriteLine("Type T to find the area of a triangle.");
                Console.WriteLine("Type S to find the area of a square.");
                Console.WriteLine("Type R to find the area of a rectangle.");
                Console.WriteLine("Type X to exit.");

                Console.WriteLine("");
                readResult = Console.ReadLine();

                switch (readResult)
                {
                    case "T":
                    case "t":
                        Console.WriteLine("");
                        Console.WriteLine("Please enter a value for the base.");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Please enter a value for the height.");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("The area of the triangle is " + AreaOfTriangle(width, height) + ".");
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("");
                        Console.WriteLine("Please enter a value for one of the sides.");
                        double side = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("The area of the square is " + AreaOfSquare(side) + ".");
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("");
                        Console.WriteLine("Please enter a value for the base.");
                        width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Please enter a value for the height.");
                        height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("The area of the rectangle is " + AreaOfRectangle(width, height) + ".");
                        break;
                    case "X":
                    case "x":
                        Console.WriteLine("");
                        Console.WriteLine("You have successfully exited.");
                        break;
                    default:
                        Console.WriteLine("You have entered an invalid response");
                        break;
                }
            }
            while (readResult != "X" && readResult != "x");
        }

        static double AreaOfTriangle(double width, double height)
        {
            return (width * height) / 2;
        }

        static double AreaOfSquare(double side)
        {
            return side * side;
        }

        static double AreaOfRectangle(double width, double height)
        {
            return width * height;
        }
    }
}