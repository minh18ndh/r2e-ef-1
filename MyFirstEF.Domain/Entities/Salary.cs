namespace MyFirstEF.Domain.Entities;

public class Salary
{
    public Guid Id { get; set; }
    public Guid EmployeeId { get; set; }
    public decimal Amount { get; set; }

    public required Employee Employee { get; set; }
}