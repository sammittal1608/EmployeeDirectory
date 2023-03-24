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
        IOfficeService _officeService;
        public OfficeController(IOfficeService officeService)
        {
            _officeService = officeService;
        }

        [HttpGet("{OfficeId}")]
        public ActionResult<Office> Get(int OfficeId)
        {
            var office = _officeService.GetOfficeById(OfficeId);
            if (office == null)
            {
                return NotFound();
            }
            return Ok(office);
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Office>> GetAll()
        {

            var office = _officeService.GetAllOffices();
            return Ok(office);
        }

        [HttpPost("")]
        public ActionResult<Office> Add(Office office)
        {
           return _officeService.AddOffice(office);
           // return CreatedAtAction(nameof(Get), new { OfficeId = office.Id }, office);
        }

    }
}
