namespace Week2Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            accountLogin();
        }

        static void accountLogin()
        {
            const string storedUserName = "Chase";
            const string storedPassword = "password";
            int remainingAttempts = 3;

            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine("Enter your username:");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                if (userName == storedUserName && password == storedPassword)
                {
                    Console.WriteLine();
                    Console.WriteLine("Welcome!");
                    return;
                }
                else
                {
                    remainingAttempts--;
                    Console.WriteLine();
                    Console.WriteLine($"Username or password incorrect.  {remainingAttempts}  attempts remaining.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("You have been locked out.");
        }
    }
}