namespace Assignment3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] my2DArray = { { 2, 3, 4 }, { 1, 4, 6 } };

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}