using AutoMapper;
using Models;
using Models.DBModels;

namespace EmployeeDirectory.API.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Employee, DBEmployee>()
            .ForMember(s => s.Office, o => o.MapFrom(d => d.Office))
            .ForMember(s => s.Department, o => o.MapFrom(d => d.Department))

            .ReverseMap();
            //CreateMap<List<DBEmployee>,List<Employee>>().ReverseMap();
            CreateMap<Department, DBDepartment>()
            .ForMember(s => s.Id, o => o.MapFrom(d => d.Id))
            .ReverseMap();
            // CreateMap<List<Department>,List<Department>>().ReverseMap();
            CreateMap<JobTitle, DBJobTitle>()
                .ForMember(s => s.Title, o => o.MapFrom(d => d.Name))
                .ReverseMap();
            // CreateMap<List<JobTitle>,List<JobTitle>>().ReverseMap();
            CreateMap<Office, DBOffice>()
                .ForMember(s => s.CountryName, o => o.MapFrom(d => d.Name))
                .ReverseMap();
            // CreateMap<List<Office>,List<Office>>().ReverseMap();    
        }
    }
}
