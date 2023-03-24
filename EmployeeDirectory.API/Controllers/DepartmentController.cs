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
        private IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("{DepartmentId}")]
        public ActionResult<Department> Get(int DepartmentId)
        {
            var department = _departmentService.GetDepartmentById(DepartmentId);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Department>> GetAll()
        {
            var departments = _departmentService.GetAllDepartments();
            return Ok(departments);
        }

        [HttpPost("")]
        public ActionResult<Department> Add(Department department)
        {
          return _departmentService.AddDepartment(department);
           // return CreatedAtAction(nameof(Get), new { DepartmentId = department.Id }, department);
        }
    }
}
