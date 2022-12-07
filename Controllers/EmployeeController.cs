using CrudOperations.Common;
using Microsoft.AspNetCore.Mvc;

namespace CrudOperations.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeController()
        {

        }

        [HttpGet("GetAllEmployees")]
        public Employee GetEmployees()
        {
            Employee employee = new Employee()
            {
                EmpID = 1,
                EmpName = "Test",
                EmpSalary = 12000
            };
            return employee;
        }

        [HttpPost("CreateEmployee")]
        public string CreateEmployee(Employee employee)
        {
            return "employee created successfully";
        }

        [HttpPut("UpdateEmployee")]
        public string UpdateEmployee(Employee employee)
        {
            return "emoloyee info updated successfully ";
        }

        [HttpDelete("DeleteEmployee")]
        public bool DeleteEmployee(int employeeId)
        {
            return true;
        }
    }
}
