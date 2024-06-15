/*Implement a single linked list with each node representing a house. You may add data in it like house number, brief address, type of house ( like Ranch, Colonial).
Each house (node) will be linked to next .Give facility to the user to search a house by its number and then display the details. ( Windows / Console)
*/

namespace Assignment6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList houses = new SingleLinkedList();

            houses.AddNewHouse(1, "229 E. Johnson St", "Ranch");
            houses.AddNewHouse(2, "987 W. Main St", "Colonial");

            Console.WriteLine("Please enter a house number you would like to search for.");
            int houseNumber = int.Parse(Console.ReadLine());

            houses.SearchForHouse(houseNumber);
        }
    }
    public class House
    {
        public int HouseNumber {  get; set; }
        public string Address { get; set; }
        public string HouseType { get; set; }
        public House Next { get; set; }

        public House(int houseNumber, string address, string houseType)
        {
            HouseNumber = houseNumber;
            Address = address;
            HouseType = houseType;
            Next = null;
        }
    }
    public class SingleLinkedList
    {
        private House head;

        public void AddNewHouse(int houseNumber, string address, string houseType)
        {
            House newHouse = new House(houseNumber, address, houseType);
            if (head == null)
            {
                head = newHouse;
            }
            else
            {
                House temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newHouse;
            }
        }
        public void SearchForHouse(int houseNumber)
        {
            House temp = head;
            while (temp != null)
            {
                if (temp.HouseNumber == houseNumber)
                {
                    Console.WriteLine($"House number: {temp.HouseNumber}, Address: {temp.Address}, House type: {temp.HouseType}.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("The house you searched for could not be found.");
        }
    }
}
