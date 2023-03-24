using Models;
using Repository;
using Repository.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class JobTitleService : IJobTitleService
    {
        IJobTitleRepository _jobTitleRepository;
        public JobTitleService (IJobTitleRepository jobTitleRepository)
        {
            _jobTitleRepository = jobTitleRepository;
        }
        public async Task<JobTitle> AddJobTitle(JobTitle jobTitle)
        {
           return await _jobTitleRepository.Add(jobTitle);
        }
        public async Task<List<JobTitle>>  GetAllJobTitles()
        {
          return await _jobTitleRepository.GetAll();
        }
        public async Task<JobTitle> GetJobTitleById(int id)
        {
           return await _jobTitleRepository.GetById(id);
        }
    }
}
