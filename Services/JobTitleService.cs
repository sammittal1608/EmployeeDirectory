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
        public JobTitleService(IJobTitleRepository jobTitleRepository)
        {
            _jobTitleRepository = jobTitleRepository;
        }
        public JobTitle AddJobTitle(JobTitle jobTitle)
        {
           return _jobTitleRepository.Add(jobTitle);
        }
        public List<JobTitle> GetAllJobTitles()
        {
          return _jobTitleRepository.GetAll();
        }
        public JobTitle GetJobTitleById(int id)
        {
           return _jobTitleRepository.GetById(id);
        }
    }
}
