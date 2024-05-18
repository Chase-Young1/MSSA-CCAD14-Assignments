namespace Week2Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            temperatureGauge();
        }
        static void temperatureGauge()
        {
            Console.WriteLine("Type in the current temperature.");
            int temperature = Convert.ToInt32(Console.ReadLine());

            switch (temperature)
            {
                case <= 10:
                    Console.WriteLine("Freezing weather.");
                    break;
                case >= 11 and <= 20:
                    Console.WriteLine("Very Cold weather.");
                    break;
                case >= 21 and <= 35:
                    Console.WriteLine("Cold weather.");
                    break;
                case >= 36 and <= 50:
                    Console.WriteLine("Normal weather.");
                    break;
                case >= 51 and <= 65:
                    Console.WriteLine("It's hot.");
                    break;
                case >= 66 and <= 80:
                    Console.WriteLine("It's very hot.");
                    break;
            }
        }
    }
}