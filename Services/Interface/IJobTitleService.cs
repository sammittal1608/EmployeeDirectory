using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IJobTitleService
    {
        public Task<JobTitle> AddJobTitle(JobTitle jobTitle);
        public Task<List<JobTitle>> GetAllJobTitles();
        public Task<JobTitle> GetJobTitleById(int id);

    }
}
