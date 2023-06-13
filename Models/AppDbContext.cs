using Microsoft.EntityFrameworkCore;
using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<DBEmployee> Employees { get; set; }
        public DbSet<DBDepartment> Departments { get; set; }
        public DbSet<DBOffice> Offices { get; set; }
        public DbSet<DBJobTitle> JobTitles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            
            var departments = new List<DBDepartment>
            {
                new DBDepartment { Id = Guid.NewGuid().ToString(), Name = "IT", Count = 0 },
                new DBDepartment { Id = Guid.NewGuid().ToString(), Name = "Human Resources", Count = 0 },
                new DBDepartment { Id = Guid.NewGuid().ToString(), Name = "MD", Count = 0 },
                new DBDepartment { Id = Guid.NewGuid().ToString(), Name = "Sales", Count = 0 }
            };

            var offices = new List<DBOffice>
            {
                new DBOffice { Id = Guid.NewGuid().ToString(), CountryName = "India", Count = 0 },
                new DBOffice { Id = Guid.NewGuid().ToString(), CountryName = "Seattle", Count = 0 },
            };

            var jobTitles = new List<DBJobTitle>
            {
                new DBJobTitle { Id = Guid.NewGuid().ToString(), Title = "SharePoint Practice Head", Count = 0 },
                new DBJobTitle { Id = Guid.NewGuid().ToString(), Title = ".Net Development Lead", Count = 0 },
                new DBJobTitle { Id = Guid.NewGuid().ToString(), Title = "Recruiting Expert", Count = 0 },
                new DBJobTitle { Id = Guid.NewGuid().ToString(), Title = "BI Developer", Count = 0 },
                new DBJobTitle { Id = Guid.NewGuid().ToString(), Title = "Business Analyst", Count = 0 },
            };

            modelBuilder.Entity<DBDepartment>().HasData(departments);
            modelBuilder.Entity<DBOffice>().HasData(offices);
            modelBuilder.Entity<DBJobTitle>().HasData(jobTitles);
        }
    }
}
