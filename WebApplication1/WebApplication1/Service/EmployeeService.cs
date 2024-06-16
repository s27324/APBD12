using WebApplication1.Entities;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Service;

public class EmployeeService: IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<IEnumerable<Models.Employee>> GetEmployees(CancellationToken cancellationToken)
    {
        var emps = await _employeeRepository.GetEmployees(cancellationToken);
        List<Models.Employee> result = new List<Models.Employee>();
        foreach (var emp in emps)
        {
            result.Add(new Models.Employee()
            {
                IdEmp = emp.IdEmp,
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                Address = emp.Address,
                Email = emp.Email
            });
        }

        return result;
    }

    public async Task<string> PostEmployee(EmployeeDTO employeeDto, CancellationToken cancellationToken)
    {
        return await _employeeRepository.PostEmployee(employeeDto, cancellationToken);
    }
}