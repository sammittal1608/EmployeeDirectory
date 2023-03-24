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
        public async Task<Employee> AddEmployee(Employee employee)
        {
           // employee.PreferredName = employee.FirstName +" "+ employee.LastName;

           return await _employeeRepository.Add(employee);
        }
        
        public async Task<Employee> DeleteEmployee(int employeeId)
        {

            List<Employee> employees = await _employeeRepository.GetAll();
            Employee employee = employees.FirstOrDefault(e => e.Id == employeeId);
            if (employee != null)
            {
                _employeeRepository.Update(employee);
               
            }
            return employee;
        }

        public async Task<Employee> UpdateEmployee(Employee employeeChanges)
        {
          List<Employee> employees= await _employeeRepository.GetAll();
           Employee employee= employees.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                _employeeRepository.Update(employeeChanges);
            }
            return employee;
        }
        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _employeeRepository.GetById(id);
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _employeeRepository.GetAll();
        }
    }
}
