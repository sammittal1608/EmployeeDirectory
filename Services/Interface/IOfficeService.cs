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
        public Office AddOffice(Office office);
        public List<Office> GetAllOffices();
        public Office GetOfficeById(int id);
    }
}
