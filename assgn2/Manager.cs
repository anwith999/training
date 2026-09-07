public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(
        int employeeId,
        string name,
        int age,
        decimal salary,
        string department,
        int teamSize
    ) : base(employeeId, name, age, salary, department)
    {
        TeamSize = teamSize;
    }

    public void ConductMeeting()
    {
        Console.WriteLine($"{Name} is conducting a meeting with {TeamSize} employees.");
    }
    public override void Work()
{
    Console.WriteLine($"{Name} is managing the team.");
}
}