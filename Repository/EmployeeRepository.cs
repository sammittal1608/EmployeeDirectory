using Models;
using Repository.Interface;

namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private AppDbContext dbContext;
        public EmployeeRepository(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<Employee> Add(Employee employee)
        {
            await dbContext.Employees.AddAsync(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public async Task<Employee> DeleteById(int EmployeeId)
        {
            var employee = await dbContext.Employees.FindAsync(EmployeeId);
            if(employee != null)
            {
                dbContext.Remove(employee);
                dbContext.SaveChanges();
                
            }
            return employee;
        }
        public async Task<List<Employee>> GetAll()
        {
            return  dbContext.Employees.ToList();
        }

        public async Task<Employee> GetById(int EmployeedId)
        {
          return await dbContext.Employees.FindAsync(EmployeedId);    
        }
        public async Task<Employee> Update(Employee employeeChanges)
        {
            var employee = dbContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return employeeChanges;
        }
    }
}