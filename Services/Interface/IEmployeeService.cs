using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services.Interface
{
    public interface IEmployeeService
    {
        public  Task<Employee> AddEmployee(Employee employee);
        public Task<Employee>GetEmployeeById(int id);
        public Task<List<Employee>> GetAllEmployees();
        public Task<Employee> UpdateEmployee(Employee employee);
        public Task<Employee> DeleteEmployee(int employee);
    }
}
