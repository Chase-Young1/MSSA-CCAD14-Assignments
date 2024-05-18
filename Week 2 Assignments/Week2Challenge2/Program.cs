namespace Week2Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteToFile();
            ReadFromFile();
            CopyAndWriteToFile();
        }
        static void WriteToFile()
        {
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What state do you currently live in?");
            string myState = Console.ReadLine();

            try
            {
                using (StreamWriter writer = new StreamWriter("C:\\Read-Write\\Challenge2.txt"))
                {
                    writer.WriteLine($"Hello, my name is {myName}. I am {myAge} years old, and currently live in {myState}.");
                }
                Console.WriteLine();
                Console.WriteLine("Press enter to save this file.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("File saved successfully.");
                Console.WriteLine();
                Console.WriteLine("Press enter to view the file contents.");
                Console.ReadLine();
            }
        }
        static void ReadFromFile()
        {

            try
            {
                using (StreamReader reader = new StreamReader("C:\\Read-Write\\Challenge2.txt"))
                {
                    string line = reader.ReadLine();

                    do
                    {
                        Console.WriteLine(line);

                        line = reader.ReadLine();
                    }
                    while (line != null);
                }
                Console.WriteLine();
                Console.WriteLine("Press enter to close the file.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Successfully closed file.");
            }
        }
        static void CopyAndWriteToFile()
        {
            string sourcePath = "C:\\Read-Write\\Challenge2.txt";
            string destinationPath = "C:\\Read-Write\\UpdatedChallenge2.txt";
            string contentToCopy;

            try
            {

                //Reads the content from the source file
                using (StreamReader reader = new StreamReader(sourcePath))
                {
                    contentToCopy = reader.ReadLine();
                }

                //Writes the content to the destination file
                using (StreamWriter writer = new StreamWriter(destinationPath))
                {
                    writer.WriteLine(contentToCopy);
                }

                Console.WriteLine($"File successfully copied from {sourcePath} to {destinationPath}.");
                Console.WriteLine();
                Console.WriteLine("Press enter to view the contents of the new file.");
                Console.ReadLine();

                //Displays the content from the destination file
                using (StreamReader reader = new StreamReader(destinationPath))
                {
                    string line = reader.ReadLine();

                    do
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine();
                    }
                    while (line != null);
                }
                Console.WriteLine();
                Console.WriteLine("Press enter to close the new file.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Successfully closed the new file.");
            }
        }
    }
}