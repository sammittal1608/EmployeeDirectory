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
       
        public Department AddDepartment(Department department)
        {
            return _departmentRepository.Add(department);
        }
        public Department GetDepartmentById(int id)
        {
            return _departmentRepository.GetById(id);
        }
        public List<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAll();
        }
    }
}
