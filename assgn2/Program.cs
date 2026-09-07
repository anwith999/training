public class Program
{
    public static void Main(string[ ] args)
    {
        Employee employee1 = new Employee(12, "Charan Reddy", 24, 13000m, "IT");
        Employee employee2 = new Employee(45, "Venkata K", 25, 12350.45m, "DE");

        Console.WriteLine(employee1.GetSalary());
        employee1.SetSalary(15000m);
        Console.WriteLine(employee1.GetSalary());
        employee2.SetSalary(-5000m);
        Console.WriteLine(employee2.GetSalary());

        Console.WriteLine();
        employee1.DisplayEmployee();
        employee2.DisplayEmployee();

        Developer developer1 = new Developer(201,"Maya",27,82000m,"Engineering","C#");
        developer1.WriteCode();

        Manager manager1 = new Manager(301,"Sarah",35,95000m,"Management",10);
        manager1.ConductMeeting();

        Employee employee3 = new Developer(
    201,
    "Maya",
    27,
    82000m,
    "Engineering",
    "C#"
);

Employee employee4 = new Manager(
    301,
    "Sarah",
    35,
    95000m,
    "Management",
    10
);

employee3.Work();
employee4.Work();
    }
    
}