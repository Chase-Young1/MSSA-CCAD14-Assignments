namespace Assignment2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            string choice;

            do
            {
                Console.WriteLine("Choose a shape from the menu to calculate the area.");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Exit");
                choice = Console.ReadLine();



                switch (choice)
                {
                    case "1":
                        Circle circle = new Circle();
                        Console.WriteLine("Enter the radius of a circle.");
                        circle.radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The area of the circle is: " + circle.CalculateAreaOfShape());
                        break;
                    case "2":
                        Square square = new Square();
                        Console.WriteLine("Enter the length of one side.");
                        square.LengthOfSide = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The area of the square is " + square.CalculateAreaOfShape());
                        break;
                    case "3":
                        Console.WriteLine("");
                        Console.WriteLine("You have successfully exited.");
                        break;
                    default:
                        Console.WriteLine("You have entered an invalid response. Please choose a valid option from the menu.");
                        break;
                }
            }
            while (choice != "3");
        }
    }
    public enum ColorValues { Red, Green, Blue }
    public abstract class Shape
    {
        public int ShapeId { get; set; }
        public string ShapeName { get; set; }
        public string ShapeDescription { get; set; }
        public ColorValues ShapeColor { get; set; }
        public abstract double CalculateAreaOfShape();
    }
    public class Circle : Shape
    {
        public double radius { get; set; }
        public override double CalculateAreaOfShape()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    public class Square : Shape
    {
        public double LengthOfSide { get; set; }
        public override double CalculateAreaOfShape()
        {
            return Math.Pow(LengthOfSide, 2);
        }
    }
}