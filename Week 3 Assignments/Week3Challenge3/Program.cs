namespace Week3Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReturnIndicies();
            
        }
        static int[] ReturnIndicies()
        {
            int[] myArray = { 2, 7, 11, 15 };
            int target = 9;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                    if (myArray[i] + myArray[j] == target)
            }
            return new int[] { };
        }
    }
    }
}
}
