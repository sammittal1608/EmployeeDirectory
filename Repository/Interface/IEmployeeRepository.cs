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
        public Employee Add(Employee employee);
        public  Employee Update(Employee employee);
        public Employee GetById(int EmployeedId);
        public List<Employee> GetAll();
        public Employee DeleteById(int EmployeeId);
    }
}
