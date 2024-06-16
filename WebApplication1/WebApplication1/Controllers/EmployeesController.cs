using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers;

public class EmployeesController : Controller
{
    private readonly IEmployeeService _employeeService;

    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<IActionResult> Index(CancellationToken cancellationToken)
    {
        var emps = await _employeeService.GetEmployees(cancellationToken);
        return View(emps);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(EmployeeDTO employeeDto, CancellationToken cancellationToken)
    {
        await _employeeService.PostEmployee(employeeDto, cancellationToken);
        return RedirectToAction("Index");
    }
}