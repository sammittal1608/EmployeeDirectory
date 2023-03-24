using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IJobTitleRepository
    {
        public Task<JobTitle> Add(JobTitle jobTitle);
        public Task<JobTitle> GetById(int JobTitleId);
        public Task<List<JobTitle>> GetAll();
    }
}
