using Microsoft.AspNetCore.Authorization;
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

        //[Authorize]
        [HttpGet("{EmployeeId}")]
        public async Task<ActionResult<Employee>> Get(string  EmployeeId)
        {
            Employee employee = await _employeeService.GetEmployeeById(EmployeeId);
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

        //[Authorize]
        [HttpPost("")]
        public async Task<ActionResult<Employee>> Add(Employee employee)
        {
            Employee addedEmployee = await _employeeService.AddEmployee(employee);
            return addedEmployee;
        }

        //[Authorize]
        [HttpPut("")]
        public async Task<ActionResult<Employee>> Update(Employee employee)
        {
            //var existingEmployee = await _employeeService.GetEmployeeById(employeeId);
            //if (existingEmployee == null)
            //{
            //    return NotFound();
            //}
            var updatedEmployee = await _employeeService.UpdateEmployee(employee);
            return updatedEmployee;
        }

        //[Authorize]
        [HttpDelete("DeleteEmployee")]
        public async Task<ActionResult<Employee>> Delete(string EmployeeId)
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
