using CrudOperations.Common;

namespace CrudOperations.DataAccess.Interfaces
{
    public interface IStudentRepository
    {
        public string CreateEmployee(Employee employee);
        public Student GetEmployees();
        public string UpdateEmployee(Employee employee);
        public string DeleteEmployee(int employeeId);



    }
}
