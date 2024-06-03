namespace Week4Challenge1
{
    internal class Program
    {
        static double total;
        static double unitsConsumed;
        static double unitCost;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the total units consumed.");
            unitsConsumed = double.Parse(Console.ReadLine());
            Console.WriteLine($"Total amount due: {total}");
            
            ElectricityBill();
        }
        static double ElectricityBill()
        { 
            switch (total)
            {
                case 1:
                    if (unitsConsumed >= 1 && unitsConsumed <= 199)
                    {
                        unitCost = 1.20;
                        total = unitsConsumed * unitCost;
                    }
                break;
                case 2:
                    if (unitsConsumed >= 200 &&  unitsConsumed <= 399)
                    {
                        unitCost = 1.50;
                        total = unitsConsumed * unitCost;
                    }
                break;
                case 3:
                    if (unitsConsumed >= 400 && unitsConsumed <= 599)
                    {
                        unitCost = 1.80;
                        total = unitsConsumed * unitCost;
                    }
                break;
                case 4:
                    if (unitsConsumed >= 600)
                    {
                        unitCost = 2.00;
                        total = unitsConsumed * unitCost;
                    }
                break;
            }
            return total;
        }
    }
}
