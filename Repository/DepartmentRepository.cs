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
        public Department Add(Department department)
        {
            dbContext.Departments.Add(department);
            dbContext.SaveChanges();
            return department;
        }

        public List<Department> GetAll()
        {
            return dbContext.Departments.ToList();
        }

        public Department GetById(int DepartmentId)
        {
            Department department = dbContext.Departments.Find(DepartmentId);
            if(department != null)
            {
                return department;
            }return department;
        }
    }
}