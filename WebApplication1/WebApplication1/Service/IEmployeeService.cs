using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Service;

public interface IEmployeeService
{
    public Task<IEnumerable<Models.Employee>> GetEmployees(CancellationToken cancellationToken);
    public Task<string> PostEmployee(EmployeeDTO employeeDto, CancellationToken cancellationToken);
}