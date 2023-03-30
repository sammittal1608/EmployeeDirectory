using AutoMapper;
using Models;
using Models.DBModels;
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
        IMapper _mapper;
        public JobTitleRepository(AppDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<DBJobTitle> Add(DBJobTitle jobTitle)
        {
            dbContext.JobTitles.Add(jobTitle);
            dbContext.SaveChanges();
           
            return jobTitle;
        }
        public async Task<List<DBJobTitle>> GetAll()
        {
            List<DBJobTitle> dBJobTitles= dbContext.JobTitles.ToList();
           
            return dBJobTitles;
        }
        public async Task<DBJobTitle> GetById(int jobTitleId)
        {

                DBJobTitle dbJobTitle =dbContext.JobTitles.Find(jobTitleId);

            return dbJobTitle;
        }
    }
}
