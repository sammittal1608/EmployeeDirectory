using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IOfficeRepository
    {
        public Task<Office> Add(Office office);
        public Task<Office> GetById(int OfficeId);
        public Task<List<Office>> GetAll();
    }
}
