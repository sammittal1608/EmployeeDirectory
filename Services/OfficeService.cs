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
        public async Task<Office> AddOffice(Office office)
        {
           return await _OfficeRepository.Add(office);
        }

        public async Task<List<Office>> GetAllOffices()
        {
           return await _OfficeRepository.GetAll();
        }

        public async Task<Office> GetOfficeById(int id)
        {
          return await _OfficeRepository.GetById(id);
        }
    }
}
