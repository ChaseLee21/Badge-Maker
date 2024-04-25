using System;
namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        List<Employee> employees = GetEmployees();
        PrintEmployees(employees);
    }

    static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>();
        while (true)
        {
            Console.WriteLine("Please enter a first name: ");
            string firstName = Console.ReadLine() ?? "";
            if (firstName == "")
            {
                break;
            }
            Console.WriteLine("Please enter a last name: ");
            string lastName = Console.ReadLine() ?? "";
            Console.WriteLine("Please enter an id: ");
            int id = Int32.Parse(Console.ReadLine() ?? "12345");
            Console.WriteLine("Please enter a photo url: ");
            string photoUrl = Console.ReadLine() ?? "https://placekitten.com/300/300";

            Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
            employees.Add(currentEmployee);
        }
        return employees;
    }

    static void PrintEmployees(List<Employee> employees)
    {
        Console.WriteLine("------------");
        Console.WriteLine("Employees: ");
        for (int i = 0; i < employees.Count; i++) 
        {
            Console.WriteLine(employees[i].GetFullName());
            Console.WriteLine(employees[i].Id);
            Console.WriteLine(employees[i].PhotoUrl);
        }
    }
  }
}