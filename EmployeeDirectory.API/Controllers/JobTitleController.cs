using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;
using Repository.Interface;
using Services;
using Services.Interface;
using System.Threading.Tasks;

namespace EmployeeDirectory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTitleController : ControllerBase
    {
        private readonly IJobTitleService _jobTitleService;

        public JobTitleController(IJobTitleService jobTitleService)
        {
            _jobTitleService = jobTitleService;
        }

        //[Authorize]
        [HttpGet("{JobTitleId}")]
        public async Task<ActionResult<JobTitle>> Get(string JobTitleId)
        {
            var jobTitle = await _jobTitleService.GetJobTitleById(JobTitleId);
            if (jobTitle == null)
            {
                return NotFound();
            }
            return Ok(jobTitle);
        }

        //[Authorize]
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<JobTitle>>> GetAll()
        {
            var jobTitles = await _jobTitleService.GetAllJobTitles();
            return Ok(jobTitles);
        }

        //[Authorize]
        //[HttpPost("")]
        //public async Task<ActionResult<JobTitle>> Add(JobTitle jobTitle)
        //{
        //    var addedEmployee = await _jobTitleService.AddJobTitle(jobTitle);
        //    return addedEmployee;
        //}
    }
}
