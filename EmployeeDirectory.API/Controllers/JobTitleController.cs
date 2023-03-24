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
    public class JobTitleController : ControllerBase
    {
        IJobTitleService _jobTitleService;
        public JobTitleController(IJobTitleService jobTitleService)
        {
            _jobTitleService = jobTitleService;
        }

        [HttpGet("{JobTitleId}")]
        public ActionResult<JobTitle> Get(int JobTitleId)
        {
            var JobTitle = _jobTitleService.GetJobTitleById(JobTitleId);
            if (JobTitle == null)
            {
                return NotFound();
            }
            return Ok(JobTitle);
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<JobTitle>> GetAll()
        {

            var jobTitle = _jobTitleService.GetAllJobTitles();
            return Ok(jobTitle);
        }

        [HttpPost("")]
        public ActionResult<JobTitle> Add(JobTitle jobTitle)
        {
           return _jobTitleService.AddJobTitle(jobTitle);
           // return CreatedAtAction(nameof(Get), new { JobTitleId = jobTitle.Id }, jobTitle);
        }

    }   
}
