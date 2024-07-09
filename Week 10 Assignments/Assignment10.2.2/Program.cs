/* Write a program to create a list of employees. Consider a hard coded list. 
Display all employees who have salary more than $5000 and age < 30. */

namespace Assignment10._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee() { EmployeeID = 1, FirstName = "John", LastName = "Doe", Salary = 7000, Age = 27 },
                new Employee() { EmployeeID = 2, FirstName = "Jane", LastName = "Doe", Salary = 8000, Age = 29 },
                new Employee() { EmployeeID = 3, FirstName = "Jake", LastName = "Smith", Salary = 10000, Age = 31 },
            };
            var EmployeesQuery = Employees.Where(e => e.Salary > 5000 && e.Age < 30);

            foreach (var employee in EmployeesQuery)
            {
                Console.WriteLine($"Name: {employee.LastName}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
        }
    }
}