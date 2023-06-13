using Models;
using Repository.Interface;
using Services.Interface;
using Models.DBModels;
using AutoMapper;

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

        public async Task<Department> GetDepartmentById(string id)
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
        public async Task<bool> UpdateDepartmentCount(string newDepartmentId,string oldDepartmentId = null )
        {
            DBDepartment dbNewDepartment = await this._departmentRepository.GetById(newDepartmentId);
             dbNewDepartment.Count++;
            await _departmentRepository.Update(dbNewDepartment);

            if (oldDepartmentId!=null)
            {
                DBDepartment dbOldDepartment = await this._departmentRepository.GetById(oldDepartmentId);
                dbOldDepartment.Count--;
                await _departmentRepository.Update(dbOldDepartment);
            }

            return true;
        }
    }
}
