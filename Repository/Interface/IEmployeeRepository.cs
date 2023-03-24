using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IEmployeeRepository
    {
        public Task<Employee> Add(Employee employee);
        public Task<Employee> Update(Employee employee);
        public Task<Employee> GetById(int EmployeedId);
        public Task<List<Employee>> GetAll();
        public Task<Employee> DeleteById(int EmployeeId);
    }
}
