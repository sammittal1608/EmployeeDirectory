using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Models;
using Models.DBModels;

using Repository.Interface;
using Services.Interface;


namespace Services
{
    public class EmployeeService:IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository , IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            employee.PreferredName = employee.FirstName +" "+ employee.LastName;
            var dbEmployee = _mapper.Map<DBEmployee>(employee);

            dbEmployee = await _employeeRepository.Add(dbEmployee);
             employee = _mapper.Map<Employee>(dbEmployee);
            return employee;
        }
        
        public async Task<Employee> DeleteEmployee(int employeeId)
        {

            List<Employee> Employees = await GetAllEmployees();

            Employee employee = Employees.FirstOrDefault(e => e.Id == employeeId);

            if (employee != null)
            {
                DBEmployee dbEmployee = _mapper.Map<DBEmployee>(employee);
              dbEmployee = await _employeeRepository.DeleteById(dbEmployee);
                employee = _mapper.Map<Employee>(dbEmployee);
                return employee;
            }
            return null;
        }

        public async Task<Employee> UpdateEmployee(Employee employeeChanges)
        {
          List<Employee> Employees= await GetAllEmployees();
           Employee employee= Employees.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                var dBEmployee = _mapper.Map<DBEmployee>(employee);
               DBEmployee dbEmployee = await _employeeRepository.Update(dBEmployee);
                employee = _mapper.Map<Employee>(dbEmployee);
            }
            return employee;
        }
        public async Task<Employee> GetEmployeeById(int id)
        {
                 DBEmployee dbEmployee = await _employeeRepository.GetById(id);
            var employee = _mapper.Map<Employee>(dbEmployee);
            return employee;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            List<DBEmployee> dbEmployees = await _employeeRepository.GetAll();
            var employees = dbEmployees.Select(dbEmployee => _mapper.Map<Employee>(dbEmployee)).ToList();
            return employees;
        }

    }
}
