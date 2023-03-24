using Models;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class JobTitleRepository :IJobTitleRepository
    {
        private readonly AppDbContext dbContext;
        public JobTitleRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<JobTitle> Add(JobTitle jobTitle)
        {
            dbContext.JobTitles.Add(jobTitle);
            dbContext.SaveChanges();
            return jobTitle;
        }
        public async Task<List<JobTitle>> GetAll()
        {
            return dbContext.JobTitles.ToList();
        }
        public async Task<JobTitle> GetById(int jobTitleId)
        {
            return dbContext.JobTitles.Find(jobTitleId);
        }
    }
}
