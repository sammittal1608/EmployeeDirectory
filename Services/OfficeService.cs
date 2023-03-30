using AutoMapper;
using Models;
using Models.DBModels;
using Repository;
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
        IOfficeRepository _officeRepository;
        IMapper _mapper;
        public OfficeService(IOfficeRepository officeRepository,IMapper mapper)
        {
            _officeRepository = officeRepository;
            _mapper = mapper;
        }
        public async Task<Office> AddOffice(Office office)
        {
            var dbOffice = _mapper.Map<DBOffice>(office);
                dbOffice = await _officeRepository.Add(dbOffice);
             office = _mapper.Map<Office>(dbOffice);
            return office;
        }

        public async Task<List<Office>> GetAllOffices()
        {
            List<DBOffice> dbOffices = await _officeRepository.GetAll();
            var offices = dbOffices.Select(dbOffice => _mapper.Map<Office>(dbOffice)).ToList();
            return offices;
        }


        public async Task<Office> GetOfficeById(int id)
        {
                DBOffice dbOffice =await _officeRepository.GetById(id);
            var office = _mapper.Map<Office>(dbOffice);
            return office;
        }
    }
}
