namespace Week4Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FrequencyOfElements();
        }
        private static void FrequencyOfElements()
        {
            int[] elementArray = { 25, 12, 43, 12, 15, 25 };

            Dictionary<int, int> elementDictionary = new Dictionary<int, int>();

            foreach (int element in elementArray)
            {
                if (elementDictionary.ContainsKey(element))
                {
                    elementDictionary[element]++;
                }
                else
                {
                    elementDictionary[element] = 1;
                }
            }
            foreach (KeyValuePair<int, int> pair in elementDictionary)
            {
                Console.WriteLine(format: "{0} occurs {1} times.", pair.Key, pair.Value);
            }
        }
    }
}