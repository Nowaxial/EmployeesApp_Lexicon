using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;

namespace EmployeesApp.Web.Controllers
{
    public class EmployeesController : Controller
    {
       private static EmployeeService employeeService = new EmployeeService();

        [HttpGet("")]
        public IActionResult Index() => View(employeeService.GetAllEmployees());
        
    }
}

