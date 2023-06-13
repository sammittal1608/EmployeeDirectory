using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;
using Repository.Interface;
using Services;
using Services.Interface;

namespace EmployeeDirectory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IOfficeService _officeService;

        public OfficeController(IOfficeService officeService)
        {
            _officeService = officeService;
        }

        //[Authorize]
        [HttpGet("{OfficeId}")]
        public async Task<ActionResult<Office>> Get(string OfficeId)
        {
            var office = await _officeService.GetOfficeById(OfficeId);
            if (office == null)
            {
                return NotFound();
            }
            return Ok(office);
        }

        //[Authorize]
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Office>>> GetAll()
        {
            var office = await _officeService.GetAllOffices();
            return Ok(office);
        }

        //[Authorize]
        //[HttpPost("")]
        //public async Task<ActionResult<Office>> Add(Office office)
        //{
        //      var addedEmployee = await _officeService.AddOffice(office);
        //    return addedEmployee;
        //}

    }
}
