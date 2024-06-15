namespace Assignment6._4
{
    internal class Program
    {
        static int n = 3;
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 },
                              { 4, 5, 6 }, 
                              { 6, 7, 8 } };

            RotateClockwise(matrix);
            PrintMatrix(matrix);
        }
        static void RotateClockwise(int[,] matrix)
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i + 1;  j < (n - 1) - i; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[n - 1 - j, i];
                    matrix[n - 1 - j, i] = matrix[n - 1 - i, n - 1 - j];
                    matrix[n - 1 - i, n - 1 - j] = matrix[j, n - 1 - i];
                    matrix[j, n - 1 - i] = temp;
                }
            }
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i  < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
