using System;
namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        List<String> employees = new List<String>() { "Max", "Sally", "John" };
        for (int i = 0; i < employees.Count; i++) 
        {
            Console.WriteLine(employees[i]);
        }
      Console.WriteLine("Hello, World!");
    }
  }
}