using Models;
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
        public async Task<Department> Add(Department department)
        {
            await dbContext.Departments.AddAsync(department);
            dbContext.SaveChanges();
            return department;
        }

        public async Task<List<Department>> GetAll()
        {
            return dbContext.Departments.ToList();
        }

        public async Task<Department> GetById(int DepartmentId)
        {
            Department department = await dbContext.Departments.FindAsync(DepartmentId);
            if(department != null)
            {
                return department;
            }return department;
        }
    }
}