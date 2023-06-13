using Models;

namespace Services.Interface
{
    public interface IEmployeeService
    {
        public Task<Employee> AddEmployee(Employee employee);
        public Task<Employee> GetEmployeeById(string id);
        public Task<List<Employee>> GetAllEmployees();
        public Task<Employee> UpdateEmployee(Employee employee);
        public Task<Employee> DeleteEmployee(string employee);
    }
}
