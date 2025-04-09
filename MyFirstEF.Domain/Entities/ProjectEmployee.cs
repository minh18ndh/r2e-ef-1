namespace MyFirstEF.Domain.Entities;

public class ProjectEmployee
{
    public Guid ProjectId { get; set; }
    public Guid EmployeeId { get; set; }
    public bool Enable { get; set; }

    public required Project Project { get; set; }
    public required Employee Employee { get; set; }
}