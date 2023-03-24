using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Interface
{
    public interface IDepartmentRepository
    {
        public Task<Department> Add(Department department);
        public Task<Department> GetById(int DepartmentId);

        public Task<List<Department>> GetAll();
    }
}
