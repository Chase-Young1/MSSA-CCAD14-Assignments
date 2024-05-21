namespace Assignment3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = { { 1, 2 }, { 3, 4 } };
            int[,] secondMatrix = { { 5, 6, }, { 7, 8 } };

            Console.WriteLine("The first matrix:");
            Console.WriteLine();
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    Console.Write(firstMatrix[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("The second matrix:");
            Console.WriteLine();
            for (int i = 0; i < secondMatrix.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0;j < secondMatrix.GetLength(1); j++)
                {
                    Console.Write(secondMatrix[i, j] + "|");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The addition of the two matrices is:");
            Console.WriteLine();
            for (int i = 0; i < firstMatrix.GetLength(0); i++ )
            {
                Console.Write("|");
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    Console.Write(firstMatrix[i, j] + secondMatrix[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
