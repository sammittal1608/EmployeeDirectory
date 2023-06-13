using Models;
using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IOfficeRepository
    {
        public Task<DBOffice> Add(DBOffice office);
        public Task<DBOffice> GetById(string OfficeId);
        public Task<List<DBOffice>> GetAll();
        public Task Update(DBOffice dbOffice);
    }
}
