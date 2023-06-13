using AutoMapper;
using Models;
using Models.DBModels;
using Repository.Interface;

namespace Repository
{
    public class DepartmentRepository: IDepartmentRepository
    {
        private readonly AppDbContext dbContext;
        public DepartmentRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<DBDepartment> Add(DBDepartment dbDepartment)
        {
            await dbContext.Departments.AddAsync(dbDepartment);
            dbContext.SaveChanges();
            return  dbDepartment;
        }

        public async Task<List<DBDepartment>> GetAll()
        {
            List<DBDepartment> dbDepartments = dbContext.Departments.ToList();
            
            return dbDepartments;
        }

        public async Task<DBDepartment> GetById(string DepartmentId)
        {
            DBDepartment dbDepartment = await dbContext.Departments.FindAsync(DepartmentId);
           
            return dbDepartment;
        }
        public async Task Update(DBDepartment dbDepartmentChanges)
        {
            try
            {
                var dbDepartment = dbContext.Departments.Attach(dbDepartmentChanges);
                dbDepartment.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the department: " + ex.Message);
            }
        }

    }
}