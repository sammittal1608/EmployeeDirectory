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
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<DBEmployee> Employees { get; set; }
        public DbSet<DBDepartment> Departments { get; set; }
        public DbSet<DBOffice> Offices { get; set; }
        public DbSet<DBJobTitle> JobTitles { get; set; }
    }
}
