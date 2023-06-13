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
        IJobTitleService _jobTitleService;
        IDepartmentService _departmentService;
        IOfficeService _officeService;
        IUnitOfWork _unitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository , IMapper mapper, IDepartmentService departmentService, IJobTitleService jobTitleService, IOfficeService officeService, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            _departmentService = departmentService;
            _jobTitleService = jobTitleService;
            _officeService = officeService;
            _unitOfWork = unitOfWork;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid().ToString();

            var dbEmployee = _mapper.Map<DBEmployee>(employee);
            dbEmployee = await _employeeRepository.Add(dbEmployee);
            
            await _departmentService.UpdateDepartmentCount(employee.Department.ToString());
            await _officeService.UpdateOfficeCount(employee.Office.ToString());
            await _jobTitleService.UpdateJobTitleCount(employee.JobTitle.ToString());
            await _unitOfWork.SaveChanges();

            employee = _mapper.Map<Employee>(dbEmployee);
            return employee;
        }
        
        public async Task<Employee> DeleteEmployee(string employeeId)
        {
            var employee = await GetEmployeeById(employeeId);

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
            var employee = await this._employeeRepository.GetById(employeeChanges.Id);
            if (employee != null)
            {
                try
                {
                    await this._departmentService.UpdateDepartmentCount(employeeChanges.Department.ToString(), employee.Department.ToString());
                    await this._jobTitleService.UpdateJobTitleCount(employeeChanges.JobTitle.ToString(), employee.JobTitle.ToString());
                    await this._officeService.UpdateOfficeCount(employeeChanges.Office.ToString(), employee.Office.ToString());

                    //var dbEmployee = _mapper.Map<DBEmployee>(employeeChanges);
                    employee.EmailAddress = employeeChanges.EmailAddress;
                    employee.PreferredName = employeeChanges.PreferredName;
                    employee.PhoneNumber = employeeChanges.PhoneNumber;
                    employee.LastName = employeeChanges.LastName;
                    employee.FirstName = employeeChanges.FirstName;
                    employee.Department = employeeChanges.Department;
                    employee.Office = employeeChanges.Office;
                    employee.JobTitle= employeeChanges.JobTitle;

                    var dbEmployee = await _employeeRepository.Update(employee);
                    await this._unitOfWork.SaveChanges();

                    employeeChanges = _mapper.Map<Employee>(dbEmployee);
                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            return employeeChanges;
        }
        public async Task<Employee> GetEmployeeById(string id)
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
