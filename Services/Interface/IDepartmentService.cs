using Models;
using Models.DBModels;

namespace Services.Interface
{
    public interface IDepartmentService
    {
        //public Task<Department> AddDepartment(Department Department);
        public Task<List<Department>> GetAllDepartments();
        public Task<Department> GetDepartmentById(string id);
        public Task<bool> UpdateDepartmentCount(string newDepartmentId ,string oldDepartmentId = null);
       
        //public void UpdateDepartment(Department oldDepartment, Department newDepartment);
    }
}