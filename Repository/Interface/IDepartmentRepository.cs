using Models;
using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Interface
{
    public interface IDepartmentRepository
    {
        public Task<DBDepartment> Add(DBDepartment dbDepartment);
        public Task<DBDepartment> GetById(string DepartmentId);

        public Task<List<DBDepartment>> GetAll();
        public Task Update(DBDepartment dbDepartment);
        
    }
}
