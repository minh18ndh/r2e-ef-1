namespace MyFirstEF.Domain.Entities;

public class Salary
{
    public required Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public required decimal Amount { get; set; }

    public Employee? Employee { get; set; }
}