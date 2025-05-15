using System.ComponentModel.DataAnnotations;
using EmployeesApp.Web.Models.Validation;

namespace EmployeesApp.Web.Models

{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [HardCodedTeachers(["Pontus", "Håkan", "Jonathan"])]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter an e-mail")]
        public string Email { get; set; } = null!;
    }
}
