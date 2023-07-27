using IvyMVC.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace IvyMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepo;
        public EmployeeController(IEmployeeRepository employeeRepo)
        { 
            _employeeRepo = employeeRepo;
        }
        public async Task<IActionResult> Index()
        {
            var employees = await _employeeRepo.GetEmployees();
            ViewBag.Employees = employees;
            return View();
        }
    }
}
