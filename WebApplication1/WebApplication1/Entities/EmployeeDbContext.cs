using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Entities;

public class EmployeeDbContext: DbContext
{
    public virtual DbSet<Employee> Employees { get; set; }

    protected EmployeeDbContext()
    {
    }

    public EmployeeDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Employee).Assembly);
    }
}