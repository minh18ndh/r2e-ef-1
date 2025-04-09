namespace MyFirstEF.Domain.Entities;

public class Project
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }

    public ICollection<ProjectEmployee>? ProjectEmployees { get; set; }
}