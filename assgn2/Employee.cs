public class Employee
{
    public int EmployeeId{get; set;}
    public string Name {get; set;}
    public int Age {get; set;}
    public string Department {get; set;}
    private decimal salary;
    public Employee(int employeeId, string name, int age, decimal salary, string department)
    {
        this.EmployeeId = employeeId;
        this.Name = name;
        this.Age = age;
        this.Department = department;
        this.salary = salary;
    }
    public decimal GetSalary()
{
    return salary;
}
public void SetSalary(decimal newSalary)
{
    if (newSalary < 0)
    {
        Console.WriteLine("Invalid salary.");
    }
    else
    {
        salary = newSalary;
    }
}

public void DisplayEmployee()
    {
    Console.WriteLine($"Employee ID: {EmployeeId}");
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Age: {Age}");
    Console.WriteLine($"Department: {Department}");
    Console.WriteLine($"Salary: {salary:C}");
    }
public virtual void Work()
{
    Console.WriteLine($"{Name} is working.");
}
}