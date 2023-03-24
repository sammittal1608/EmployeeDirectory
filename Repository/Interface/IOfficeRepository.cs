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
        public Office Add(Office office);
        public Office GetById(int OfficeId);
        public List<Office> GetAll();
    }
}
