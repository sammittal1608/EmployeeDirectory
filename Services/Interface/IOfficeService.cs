using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services.Interface
{
    public interface IOfficeService
    {
        //public Task<Office> AddOffice(Office office);
        public Task<List<Office>> GetAllOffices();
        public Task<Office> GetOfficeById(string id);
        public Task<bool> UpdateOfficeCount( string newOfficeId, string oldOfficeId = null);
        //public void UpdateOffice(Office oldOffice, Office newOffice);
    }
}
