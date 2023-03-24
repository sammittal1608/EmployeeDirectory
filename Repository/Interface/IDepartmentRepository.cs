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
        public Department Add(Department department);
        public Department GetById(int DepartmentId);
        public List<Department> GetAll();
    }
}
