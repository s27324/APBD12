using WebApplication1.Models;
using Employee = WebApplication1.Entities.Employee;

namespace WebApplication1.Repository;

public interface IEmployeeRepository
{
    public Task<IEnumerable<Employee>> GetEmployees(CancellationToken cancellationToken);
    public Task<string> PostEmployee(EmployeeDTO employeeDto, CancellationToken cancellationToken);
}