using Models;
using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IEmployeeRepository
    {
        public Task<DBEmployee> Add(DBEmployee dbEmployee);
        public Task<DBEmployee> Update(DBEmployee dbEmployee);
        public Task<DBEmployee> GetById(string employeedId);
        public Task<List<DBEmployee>> GetAll();
        public Task<DBEmployee> DeleteById(DBEmployee dBEmployee);
        
    }
}
