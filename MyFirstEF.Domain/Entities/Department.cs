namespace MyFirstEF.Domain.Entities;

public class Department
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }

    // Navigation
    public ICollection<Employee>? Employees { get; set; }
}