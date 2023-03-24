using Models;
using Repository.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class DepartmentService : IDepartmentService
    {
        IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository= departmentRepository;
        }
        public async Task<Department> AddDepartment(Department department)
        {
            return await _departmentRepository.Add(department);
        }
        public async Task<Department> GetDepartmentById(int id)
        {
            return await _departmentRepository.GetById(id);
        }
        public async Task<List<Department>> GetAllDepartments()
        {
            return await _departmentRepository.GetAll();
        }
    }
}
