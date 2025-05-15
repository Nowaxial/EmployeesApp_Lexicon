using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeesApp.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private static EmployeeService employeeService = new EmployeeService();

        [HttpGet("")]
        public IActionResult Index() => View(employeeService.GetAllEmployees());


        [HttpGet("/create")]

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("/create")]
        public IActionResult Create(Employee employee)
        {
            if (employee.Name == "Håkan" || employee.Name == "Pontus" || employee.Name == "Jonathan")
            {
                ModelState.AddModelError(nameof(employee.Name),
                "Ni får inte vara med...");
            }


            if (!ModelState.IsValid) return View();
            employeeService.AddEmployee(employee);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id) => View(employeeService.GetEmployeeById(id));


    }
}

