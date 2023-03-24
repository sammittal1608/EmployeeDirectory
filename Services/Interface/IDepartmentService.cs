using Models;

namespace Services.Interface
{
    public interface IDepartmentService
    {
        public Department AddDepartment(Department department);
        public List<Department> GetAllDepartments();
        public Department GetDepartmentById(int id);
    }
}