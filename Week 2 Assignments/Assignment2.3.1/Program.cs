namespace Assignment2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteToFile();
            ReadTextFile();
        }

        //CODE TO CREATE/WRITE TO A TEXT FILE
        static void WriteToFile()
        {
            Console.WriteLine("Please enter your name.");
            string myName = Console.ReadLine();
            Console.WriteLine("Please enter your age.");
            string myAge = Console.ReadLine();
            Console.WriteLine("Please enter the State you live in.");
            string myState = Console.ReadLine();
            try
            {
                //Passing the filepath and filename to the StreamWriter constructor
                using (StreamWriter writer = new StreamWriter("C:\\Read-Write\\Notepad.txt"))
                {
                    //Write a line of text to a file
                    writer.WriteLine($"Hello, my name is {myName}. I am {myAge} years old, and currently live in {myState}.");
                    //Write as many more lines as you want to the same file
                }
                Console.WriteLine();
                Console.WriteLine("Press enter to save the file.");
                Console.ReadLine(); //Causes the program to pause and wait for user input, so it doesn't close automatically
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("File saved.");
                Console.WriteLine();
                Console.WriteLine("Press enter to view the file contents.");
                Console.ReadLine();
            }
        }

        //CODE TO READ A SPECIFIED TEXT FILE
        static void ReadTextFile()
        {
            String line;
            try
            {
                //Passing the file name to the StreamReader constructor
                using (StreamReader reader = new StreamReader("C:\\Read-Write\\Notepad.txt"))
                {
                    //Read the first line of text from the file
                    line = reader.ReadLine();
                    //Continues to read until it reaches the end of the specified file
                    do
                    {
                        //Writes the text line to the console window
                        Console.WriteLine(line);
                        //Reads the next line of text from the specified file'
                        line = reader.ReadLine();
                    }
                    while (line != null);
                }
                Console.WriteLine();
                Console.WriteLine("Press enter to close the file.");
                Console.ReadLine(); //Causes the program to pause and wait for user input, so it doesn't close automatically
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("File closed.");
            }
        }
    }
}