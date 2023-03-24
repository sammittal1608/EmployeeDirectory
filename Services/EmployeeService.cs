using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository.Interface;
using Services.Interface;

namespace Services
{
    public class EmployeeService:IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee AddEmployee(Employee employee)
        {
           // employee.PreferredName = employee.FirstName +" "+ employee.LastName;

           return _employeeRepository.Add(employee);
        }
        
        public Employee DeleteEmployee(int employeeId)
        {
            return _employeeRepository.DeleteById(employeeId);
        }

        public Employee UpdateEmployee(Employee employeeChanges)
        {
          List<Employee> employees= _employeeRepository.GetAll();
           Employee employee= employees.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                _employeeRepository.Update(employeeChanges);
                return employeeChanges;
            }
            return employee;
        }
        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }
    }
}
