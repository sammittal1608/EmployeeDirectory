using Models;
using Repository.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OfficeService : IOfficeService
    {
        IOfficeRepository _OfficeRepository;
        public OfficeService(IOfficeRepository officeRepository)
        {
            _OfficeRepository = officeRepository;
        }
        public Office AddOffice(Office office)
        {
           return _OfficeRepository.Add(office);
        }

        public List<Office> GetAllOffices()
        {
           return _OfficeRepository.GetAll();
        }

        public Office GetOfficeById(int id)
        {
          return _OfficeRepository.GetById(id);
        }
    }
}
