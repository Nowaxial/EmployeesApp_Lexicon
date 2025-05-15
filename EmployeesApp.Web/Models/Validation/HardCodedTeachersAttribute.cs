using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models.Validation
{

    class HardCodedTeachersAttribute(string[] correctValue) : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return !correctValue.Contains(value);
        }
    }
}
