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
        public JobTitle Add(JobTitle jobTitle)
        {
            dbContext.JobTitles.Add(jobTitle);
            dbContext.SaveChanges();
            return jobTitle;
        }

        public List<JobTitle> GetAll()
        {
            return dbContext.JobTitles.ToList();
        }
        public JobTitle GetById(int jobTitleId)
        {
            return dbContext.JobTitles.Find(jobTitleId);
        }
    }
}
