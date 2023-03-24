using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repository.Interface;
using Services;
using Services.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<ActionResult<Employee>> Get(int EmployeeId)
        {
            var employee = await _employeeService.GetEmployeeById(EmployeeId);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
        {
            var employees = await _employeeService.GetAllEmployees();
            return Ok(employees);
        }

        [HttpPost("")]
        public async Task<ActionResult<Employee>> Add(Employee employee)
        {
            var addedEmployee =  _employeeService.AddEmployee(employee);
            return CreatedAtAction(nameof(Get), new { EmployeeId = addedEmployee.Id }, addedEmployee);
        }

        [HttpPut("{EmployeeId}")]
        public async Task<ActionResult<Employee>> Update(int EmployeeId, Employee employee)
        {
            var existingEmployee = await _employeeService.GetEmployeeById(EmployeeId);
            if (existingEmployee == null)
            {
                return NotFound();
            }
            var updatedEmployee = await _employeeService.UpdateEmployee(employee);
            return updatedEmployee;
        }

        [HttpDelete("{EmployeeId}")]
        public async Task<ActionResult<Employee>> Delete(int EmployeeId)
        {
            var existingEmployee = await _employeeService.DeleteEmployee(EmployeeId);
            if (existingEmployee == null)
            {
                return NotFound();
            }
            return existingEmployee;
        }
    }
}
