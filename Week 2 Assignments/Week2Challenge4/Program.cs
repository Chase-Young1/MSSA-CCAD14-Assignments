namespace Week2Challenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type any letter of the alphabet.");
            char letterInput = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the desired width.");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = width; i > 0; i--)
            {
                Console.WriteLine(new String(letterInput, i));
            }

        }
    }
}