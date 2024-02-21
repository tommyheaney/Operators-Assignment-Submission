// Program.cs
using System;

// The main program
class Program
{
    static void Main(string[] args)
    {
        // Create two employee objects with the same ID
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

        // Compare the two employees
        Console.WriteLine("emp1 == emp2: " + (emp1 == emp2));

        // Wait for input before closing the console window
        Console.ReadLine();
    }
}
