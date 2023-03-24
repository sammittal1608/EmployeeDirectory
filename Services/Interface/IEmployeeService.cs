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
        public Employee AddEmployee(Employee employee);
        public Employee GetEmployeeById(int id);
        public List<Employee> GetAllEmployees();
        public Employee UpdateEmployee(Employee employee);
        public Employee DeleteEmployee(int employee);
    }
}
