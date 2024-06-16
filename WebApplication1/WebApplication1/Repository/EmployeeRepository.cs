using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;
using WebApplication1.Models;
using Employee = WebApplication1.Entities.Employee;

namespace WebApplication1.Repository;

public class EmployeeRepository: IEmployeeRepository
{
    private readonly EmployeeDbContext _context;

    public EmployeeRepository(EmployeeDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Employee>> GetEmployees(CancellationToken cancellationToken)
    {
        return await _context.Employees.Select(
            e => new Employee()
            {
                IdEmp = e.IdEmp,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Address = e.Address,
                Email = e.Email
            }).ToListAsync(cancellationToken);
    }

    public async Task<string> PostEmployee(EmployeeDTO employeeDto, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(employeeDto.FirstName) || string.IsNullOrWhiteSpace(employeeDto.LastName) || string.IsNullOrWhiteSpace(employeeDto.Address) || string.IsNullOrWhiteSpace(employeeDto.Email))
        {
            return "Error occured while adding new Employee.";
        }

        await _context.Employees.AddAsync(new Employee()
        {
            FirstName = employeeDto.FirstName,
            LastName = employeeDto.LastName,
            Address = employeeDto.Address,
            Email = employeeDto.Email
        }, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return "Successfully added new employee.";
    }
}