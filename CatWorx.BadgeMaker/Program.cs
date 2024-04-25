using System;
namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        List<String> employees = GetEmployees();
        PrintEmployees(employees);
    }

    static List<String> GetEmployees()
    {
        List<String> employees = new List<String>();
        while (true)
        {
            Console.WriteLine("Please enter an employee name: ");
            string input = Console.ReadLine() ?? "";
            if (input == "")
            {
                break;
            }
            employees.Add(input);
        }
        return employees;
    }

    static void PrintEmployees(List<String> employees)
    {
        Console.WriteLine("------------");
        Console.WriteLine("Employees: ");
        for (int i = 0; i < employees.Count; i++) 
        {
            Console.WriteLine(employees[i]);
        }
    }
  }
}