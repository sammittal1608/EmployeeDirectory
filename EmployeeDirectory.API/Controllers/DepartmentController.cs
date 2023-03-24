using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Services;
using Services.Interface;
using Models;

namespace EmployeeDirectory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("{DepartmentId}")]
        public async Task<ActionResult<Department>> Get(int DepartmentId)
        {
            var department = await _departmentService.GetDepartmentById(DepartmentId);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Department>>> GetAll()
        {
            var departments = await _departmentService.GetAllDepartments();
            return Ok(departments);
        }

        [HttpPost("")]
        public async Task<ActionResult<Department>> Add(Department department)
        {
            var addedDepartment = await _departmentService.AddDepartment(department);
            return CreatedAtAction(nameof(Get), new { DepartmentId = addedDepartment.Id }, addedDepartment);
        }
    }
}
