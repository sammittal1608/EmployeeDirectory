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

        public Office Add(Office office)
        {
            dbContext.Offices.Add(office);
            dbContext.SaveChanges();
            return office;
        }
        public List<Office> GetAll()
        {
            return dbContext.Offices.ToList();
        }
        public Office GetById(int office)
        {
            return dbContext.Offices.Find(office);
        }
    }
}
