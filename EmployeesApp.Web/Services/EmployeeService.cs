using EmployeesApp.Web.Models;
namespace EmployeesApp.Web.Services
{
    public class EmployeeService
    {
        List<Employee> employees =
            [
             new Employee { Id = 54, Name = "Olle Jonsson", Email = "olle.jonsson@jonsson.it"},
             new Employee { Id = 100, Name = "Zakk Elfving", Email = "Zakk.Elfving@gmail.com"},
             new Employee { Id = 234, Name = "Caroline Durant", Email = "caro@durant.com"},
            ];

        public void AddEmployee(Employee employee)
        {
            employee.Id = employees.Count == 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }

        public Employee GetEmployeeById(int id) => employees.Single(e => e.Id == id);

        public Employee[] GetAllEmployees() => employees.OrderBy(e => e.Name).ToArray();
    }
}
