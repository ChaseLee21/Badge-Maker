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
            Console.WriteLine("Please enter an employee name: ");
            string input = Console.ReadLine() ?? "";
            if (input == "")
            {
                break;
            }
            Employee currentEmployee = new Employee(input, "Smith");
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
        }
    }
  }
}