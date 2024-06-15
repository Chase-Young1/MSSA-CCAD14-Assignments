namespace Week5Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = { 2, 2, 1, 5, 1 };

            Dictionary<int, int> numbersDictionary = new Dictionary<int, int>();
            int count = 0;
            

            foreach (int number in numbersDictionary.Keys)
            {
                if (!numbersDictionary.ContainsKey(number))
                {
                    numbersDictionary.Add(number, 1);
                }
                else
                {
                    numbersDictionary[count]++;
                }

                foreach (int element in numbersDictionary.Keys)
                {
                    if (numbersDictionary[element] == 1)
                    {
                        Console.WriteLine($"The number that only appears once is: {element}");
                    }
                }
            }
        }
    }
}