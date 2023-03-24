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
        public Employee Add(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public Employee DeleteById(int EmployeeId)
        {
            var employee = dbContext.Employees.Find(EmployeeId);
            if(employee != null)
            {
                dbContext.Remove(employee);
                dbContext.SaveChanges();
                
            }
            return employee;
        }
        public List<Employee> GetAll()
        {
            return dbContext.Employees.ToList();
        }

        public Employee GetById(int EmployeedId)
        {
          return dbContext.Employees.Find(EmployeedId);    
        }
        public Employee Update(Employee employeeChanges)
        {
            var employee = dbContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return employeeChanges;
        }
    }
}