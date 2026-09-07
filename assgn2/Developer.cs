public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(
        int employeeId,
        string name,
        int age,
        decimal salary,
        string department,
        string programmingLanguage
    ) : base(employeeId, name, age, salary, department)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public void WriteCode()
    {
        Console.WriteLine($"{Name} is writing {ProgrammingLanguage} code.");
    }
    public override void Work()
{
    Console.WriteLine($"{Name} is writing software.");
}
}