/* Create any user defined class of your choice like Student, Customer etc. Add 3 properties in it (of your choice). 
 * Serialize and deserialize the object of this class by Binary, XML, JSON format. */

using System.Text.Json;

namespace Assignment10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Gender = "Male"
            };

            string jsonString = JsonSerializer.Serialize(person);
            Console.WriteLine($"JSON Serialized: " + jsonString);
        }
    }
}
