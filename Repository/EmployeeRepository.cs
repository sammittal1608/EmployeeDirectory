using AutoMapper;
using Models;
using Models.DBModels;
using Repository.Interface;

namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private AppDbContext dbContext;
        IMapper _mapper;
        public EmployeeRepository(AppDbContext _dbContext,IMapper mapper)
        {
            dbContext = _dbContext;
            _mapper = mapper;
        }
        public async Task<DBEmployee> Add(DBEmployee dbEmployee)
        {
            try
            {
                await dbContext.Employees.AddAsync(dbEmployee);
                return dbEmployee;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<DBEmployee> DeleteById(DBEmployee dbEmployee)
        {
            var DbEmployee = await dbContext.Employees.FindAsync(dbEmployee);
            if(DbEmployee != null)
            {
                dbContext.Remove(DbEmployee);
                dbContext.SaveChanges();
                
            }

            return dbEmployee;
        }
        public async Task<List<DBEmployee>> GetAll()
        {
              List<DBEmployee> dbEmployees= dbContext.Employees.ToList();

            return dbEmployees;
        }

        public async Task<DBEmployee> GetById(string EmployeedId)
        {
            DBEmployee dbEmployee = await dbContext.Employees.FindAsync(EmployeedId);
            
            return dbEmployee;
        }
        public async Task<DBEmployee> Update(DBEmployee dbemployeeChanges)
        {
            var dbEmployee = dbContext.Employees.Attach(dbemployeeChanges);
            dbEmployee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return dbemployeeChanges;
        }

    }
}