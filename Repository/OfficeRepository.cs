using Microsoft.EntityFrameworkCore;
using Models;
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
        public OfficeRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Office> Add(Office office)
        {
            dbContext.Offices.Add(office);
            dbContext.SaveChanges();
            return office;
        }
        public async Task<List<Office>> GetAll()
        {
            return dbContext.Offices.ToList();
        }
        public async Task<Office> GetById(int office)
        {
            return dbContext.Offices.Find(office);
        }
    }
}
