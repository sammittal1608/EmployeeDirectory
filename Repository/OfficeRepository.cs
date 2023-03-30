using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class OfficeRepository : IOfficeRepository
    {
        private readonly AppDbContext dbContext;
        IMapper _mapper;
        public OfficeRepository(AppDbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<DBOffice> Add(DBOffice dbOffice)
        {
            dbContext.Offices.Add(dbOffice);
            dbContext.SaveChanges();

            return dbOffice;
        }
        public async Task<List<DBOffice>> GetAll()
        {
               List<DBOffice> dbOffices =dbContext.Offices.ToList();
            
            return dbOffices;
        }
        public async Task<DBOffice> GetById(int officeId)
        {

                DBOffice dbOffice = dbContext.Offices.Find(officeId);
          
            return dbOffice;
        }
    }
}
