namespace Assignment2._3._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TipMenu();
        }
        public static void TipMenu()
        {
            string choice;

            Console.WriteLine("Enter the amout of your bill:");
            double originalAmount = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Choose a tip percentage from the menu.");
                Console.WriteLine("1. 10%");
                Console.WriteLine("2. 15%");
                Console.WriteLine("3. 20%");
                Console.WriteLine("4. Enter a percentage of your choice.");
                Console.WriteLine("5. Exit");
                choice = (Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You chose 10%.");
                        double tip = .10;
                        Console.WriteLine($"Your total after tip is: ${(originalAmount * tip) + originalAmount}.");
                        Console.WriteLine("");
                        break;
                    case "2":
                        Console.WriteLine("You chose 15%.");
                        tip = .15;
                        Console.WriteLine($"Your total after tip is: ${(originalAmount * tip) + originalAmount}.");
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("");
                        Console.WriteLine("You chose 20%.");
                        tip = .20;
                        Console.WriteLine($"Your total after tip is: ${(originalAmount * tip) + originalAmount}.");
                        Console.WriteLine("");
                        break;
                    case "4":
                        Console.WriteLine("Please enter the percent that you want to tip.");
                        tip = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("You entered: " + tip + "%.");
                        double customTip = tip / originalAmount;
                        Console.WriteLine($"Your total after tip is: ${(customTip * originalAmount) + originalAmount}.");
                        break;
                    case "5":
                        Console.WriteLine("");
                        Console.WriteLine("You have successfully exited.");
                        break;
                    default:
                        Console.WriteLine("You have entered an invalid response. Please choose a valid option from the menu.");
                        break;
                }
            }
            while (choice != "5");
        }
    }
}