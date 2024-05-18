namespace Assignment2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public class SimpleMath
        {
            public static int Add(int num1, int num2)
            {
                return num1 + num2;
            }
            public static decimal Add(decimal num1, decimal num2, decimal num3)
            {
                return num1 + num2 + num3;
            }
            public static float Multiply(float num1, float num2)
            {
                return num1 * num2;
            }
            public static float Multiply(float num1, float num2, float num3)
            {
                return num1 * num2 * num3;
            }
        }
        static void Menu()
        {
            string choice;

            do
            {
                Console.WriteLine("Please type your choice from the menu.");
                Console.WriteLine("1. Add two integers");
                Console.WriteLine("2. Add three decimals");
                Console.WriteLine("3. Multiply two floats");
                Console.WriteLine("4. Multiply three floats");
                Console.WriteLine("5. Exit");

                Console.WriteLine("");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("");
                        Console.WriteLine("Enter first number:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Enter second number:");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Result: " + SimpleMath.Add(num1, num2) + ".");
                        break;
                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine("Enter first number:");
                        decimal dec1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Enter second number:");
                        decimal dec2 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Enter third number:");
                        decimal dec3 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Result: " + SimpleMath.Add(dec1, dec2, dec3) + ".");
                        break;
                    case "3":
                        Console.WriteLine("");
                        Console.WriteLine("Enter first number:");
                        float float1 = (float)Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Enter second number:");
                        float float2 = (float)Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Result: " + SimpleMath.Multiply(float1, float2) + ".");
                        break;
                    case "4":
                        Console.WriteLine("");
                        Console.WriteLine("Enter first number:");
                        float float3 = (float)Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Enter second number:");
                        float float4 = (float)Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Enter third number:");
                        float float5 = (float)Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Result: " + SimpleMath.Multiply(float3, float4, float5) + ".");
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