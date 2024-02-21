// Employee.cs
using System;

// Define the Employee class
public class Employee
{
    // Properties of the Employee class
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the '==' operator to compare two Employee objects based on their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both references are null or both are the same instance, they are equal
        if (ReferenceEquals(emp1, emp2))
        {
            return true;
        }

        // If one is null, but not both, they are not equal
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
        {
            return false;
        }

        // Return true if the IDs are equal
        return emp1.Id == emp2.Id;
    }

    // Overload the '!=' operator to compare two Employee objects based on their Id
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Use the '==' operator to determine if they are not equal
        return !(emp1 == emp2);
    }

    // Override the Equals method to ensure consistency with the overloaded operators
    public override bool Equals(object obj)
    {
        var employee = obj as Employee;
        if (employee == null)
            return false;

        return this.Id == employee.Id;
    }

    // Override the GetHashCode method
    public override int GetHashCode()
    {
        // Use the ID field to calculate the hash code for the employee
        return this.Id.GetHashCode();
    }
}
