using Models;
using Repository.Interface;
using Services.Interface;
using Models.DBModels;
using AutoMapper;
using Repository;

namespace Services
{
    public class DepartmentService : IDepartmentService
    {
        IDepartmentRepository _departmentRepository;
        IMapper _mapper
;        public DepartmentService(IDepartmentRepository departmentRepository,IMapper mapper)
        {
            _departmentRepository= departmentRepository;
            _mapper = mapper;
        }
        public async Task<Department> AddDepartment(Department department)
        {
            var dbDepartment = _mapper.Map<DBDepartment>(department);
            dbDepartment = await _departmentRepository.Add(dbDepartment);
          //  var departments = _mapper.Map<Department>(dbDepartment);
            return department;
        }
        public async Task<Department> GetDepartmentById(int id)
        { 
                DBDepartment dbDepartment = await _departmentRepository.GetById(id);
            var department = _mapper.Map<Department>(dbDepartment);
            return department;
        }
        public async Task<List<Department>> GetAllDepartments()
        {
            List<DBDepartment> dbDepartments = await _departmentRepository.GetAll();
            List<Department> departments = dbDepartments.Select(dbDepartment => _mapper.Map<Department>(dbDepartment)).ToList();
            return departments;
        }


    }
}
