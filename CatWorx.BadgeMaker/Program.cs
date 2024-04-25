using System;
namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        List<String> employees = new List<String>() { "Max", "Sally", "John" };
        employees.Add("Billy");
        employees.Add("Barbra");
        Console.WriteLine("Please enter an employee name: ");
        string input = Console.ReadLine() ?? "";
        employees.Add(input);
        Console.WriteLine("------------");
        Console.WriteLine("Employees: ");
        for (int i = 0; i < employees.Count; i++) 
        {
            Console.WriteLine(employees[i]);
        }
    }
  }
}