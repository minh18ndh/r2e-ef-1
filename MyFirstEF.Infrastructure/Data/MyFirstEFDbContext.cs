using Microsoft.EntityFrameworkCore;
using MyFirstEF.Domain.Entities;
using System.Reflection;

namespace MyFirstEF.Infrastructure.Data;

public class MyFirstEFDbContext : DbContext
{
    public MyFirstEFDbContext(DbContextOptions<MyFirstEFDbContext> options) : base(options) {}

    public DbSet<Department> Departments { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<ProjectEmployee> ProjectEmployees { get; set; }
    public DbSet<Salary> Salaries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Apply all IEntityTypeConfiguration<T>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}