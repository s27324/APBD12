using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configs;

public class EmployeeEfConfiguration: IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder
            .HasKey(x => x.IdEmp)
            .HasName("Employee_pk");

        builder
            .Property(x => x.IdEmp)
            .UseIdentityColumn();
        builder
            .Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(100);
        builder
            .Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(100);
        builder
            .Property(x => x.Address)
            .IsRequired()
            .HasMaxLength(100);
        builder
            .Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.ToTable(nameof(Employee));

        Employee[] employees =
        {
            new Employee()
            {
                IdEmp = 1, FirstName = "Kacper", LastName = "Alot", Address = "adres1", Email = "alot@gmail.com"
            },
            new Employee()
            {
                IdEmp = 2, FirstName = "Dariusz", LastName = "Andrzejewski", Address = "adres2",
                Email = "andrzejdariuszowski@gmail.com"
            }
        };

        builder.HasData(employees);
    }
}