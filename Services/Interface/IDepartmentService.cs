using Models;

namespace Services.Interface
{
    public interface IDepartmentService
    {
        public Task<Department> AddDepartment(Department department);
        public Task<List<Department>> GetAllDepartments();
        public Task<Department> GetDepartmentById(int id);
    }
}