namespace Assignment5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(DuplicateNumber(nums));

        }
        static bool DuplicateNumber(int[] nums)
        {
            Dictionary<int, int> number = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (number.ContainsKey(num))
                {
                    return true;
                }
                number.Add(num, 1);
            }
            return false;
        }
    }
}
