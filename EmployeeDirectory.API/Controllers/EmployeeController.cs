using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repository.Interface;
using Services;
using Services.Interface;

namespace EmployeeDirectory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("{EmployeeId}")]
        public ActionResult<Employee> Get(int EmployeeId)
        {
            var employee = _employeeService.GetEmployeeById(EmployeeId);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            var employees = _employeeService.GetAllEmployees();
            return Ok(employees);
        }

        [HttpPost("")]
        public ActionResult<Employee> Add(Employee employee)
        {
           return _employeeService.AddEmployee(employee);
        //    return CreatedAtAction(nameof(Get), new { EmployeeId = employee.Id }, employee);
        }

        [HttpPut("{EmployeeId}")]
        public ActionResult<Employee> Update(Employee employee)
        {
            var existingEmployee = _employeeService.UpdateEmployee(employee);
            if (existingEmployee == null)
            {
                return NotFound();
            }
            return employee;
        }

        [HttpDelete("{EmployeeId}")]
        public ActionResult<Employee> Delete(int EmployeeId)
        {
            var existingEmployee = _employeeService.GetEmployeeById(EmployeeId);
            if (existingEmployee == null)
            {
                return NotFound();
            }
            _employeeService.DeleteEmployee(EmployeeId);
            return existingEmployee;
        }
    }
}
